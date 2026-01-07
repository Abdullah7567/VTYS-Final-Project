using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(1280, 720);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            pnlTop.Dock = DockStyle.Top;
            pnlForm.Dock = DockStyle.Top;
            pnlButtons.Dock = DockStyle.Top;
            dgvKitaplar.Dock = DockStyle.Fill;
        }

        private async void KitapForm_Load(object sender, EventArgs e)
        {
            if (Session.RolID != 1)
                btnSil.Enabled = false;

            await KategorileriDoldur();
            await KitaplariYukle();
        }

        private async Task KategorileriDoldur()
        {
            var dt = await Db.QueryAsync("SELECT KategoriID, KategoriAdi FROM kategori ORDER BY KategoriAdi;");
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource = dt;
            cmbKategori.SelectedIndex = -1;
        }

        private async Task KitaplariYukle(string ara = null)
        {
            DataTable dt;

            if (string.IsNullOrWhiteSpace(ara))
            {
                dt = await Db.QueryAsync(@"
                    SELECT 
                        k.KitapID, k.KitapAdi, k.Yazar,
                        k.KategoriID, kat.KategoriAdi,
                        k.Yayinevi, k.BasimYili,
                        k.ToplamAdet, k.MevcutAdet
                    FROM kitap k
                    JOIN kategori kat ON kat.KategoriID = k.KategoriID
                    ORDER BY k.KitapID DESC;");
            }
            else
            {
                dt = await Db.QueryAsync(@"
                    SELECT 
                        k.KitapID, k.KitapAdi, k.Yazar,
                        k.KategoriID, kat.KategoriAdi,
                        k.Yayinevi, k.BasimYili,
                        k.ToplamAdet, k.MevcutAdet
                    FROM kitap k
                    JOIN kategori kat ON kat.KategoriID = k.KategoriID
                    WHERE k.KitapAdi LIKE CONCAT('%',@q,'%')
                       OR k.Yazar   LIKE CONCAT('%',@q,'%')
                    ORDER BY k.KitapID DESC;",
                    ("@q", ara));
            }

            dgvKitaplar.DataSource = dt;
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow == null) return;

            txtKitapID.Text = dgvKitaplar.CurrentRow.Cells["KitapID"].Value?.ToString() ?? "";
            txtKitapAdi.Text = dgvKitaplar.CurrentRow.Cells["KitapAdi"].Value?.ToString() ?? "";
            txtYazar.Text = dgvKitaplar.CurrentRow.Cells["Yazar"].Value?.ToString() ?? "";
            txtYayinevi.Text = dgvKitaplar.CurrentRow.Cells["Yayinevi"].Value?.ToString() ?? "";

            if (int.TryParse(dgvKitaplar.CurrentRow.Cells["BasimYili"].Value?.ToString(), out int by))
                nudBasimYili.Value = Clamp(by, (int)nudBasimYili.Minimum, (int)nudBasimYili.Maximum);

            if (int.TryParse(dgvKitaplar.CurrentRow.Cells["ToplamAdet"].Value?.ToString(), out int ta))
                nudToplamAdet.Value = Clamp(ta, (int)nudToplamAdet.Minimum, (int)nudToplamAdet.Maximum);

            // KategoriID varsa direkt seç
            var katIdObj = dgvKitaplar.CurrentRow.Cells["KategoriID"].Value;
            if (katIdObj != null && katIdObj != DBNull.Value)
                cmbKategori.SelectedValue = Convert.ToInt32(katIdObj);
        }

        private static int Clamp(int v, int min, int max) => v < min ? min : (v > max ? max : v);

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            await KitaplariYukle();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await KitaplariYukle(txtAra.Text.Trim());
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori seç.");
                return;
            }

            string kitapAdi = txtKitapAdi.Text.Trim();
            string yazar = txtYazar.Text.Trim();
            string yayinevi = txtYayinevi.Text.Trim();
            int basimYili = (int)nudBasimYili.Value;
            int toplamAdet = (int)nudToplamAdet.Value;
            int kategoriId = Convert.ToInt32(cmbKategori.SelectedValue);

            if (string.IsNullOrWhiteSpace(kitapAdi) ||
                string.IsNullOrWhiteSpace(yazar) ||
                string.IsNullOrWhiteSpace(yayinevi))
            {
                MessageBox.Show("Kitap Adı / Yazar / Yayınevi boş olamaz.");
                return;
            }

            try
            {
                await Db.ExecAsync(@"
                    INSERT INTO kitap (KitapAdi, Yazar, KategoriID, Yayinevi, BasimYili, ToplamAdet, MevcutAdet)
                    VALUES (@ad,@y,@kat,@yay,@by,@ta,@ta);",
                    ("@ad", kitapAdi),
                    ("@y", yazar),
                    ("@kat", kategoriId),
                    ("@yay", yayinevi),
                    ("@by", basimYili),
                    ("@ta", toplamAdet));

                MessageBox.Show("Kitap eklendi.");
                FormTemizle();
                await KitaplariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtKitapID.Text, out int kitapId))
            {
                MessageBox.Show("Güncellemek için listeden kitap seç.");
                return;
            }

            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori seç.");
                return;
            }

            string kitapAdi = txtKitapAdi.Text.Trim();
            string yazar = txtYazar.Text.Trim();
            string yayinevi = txtYayinevi.Text.Trim();
            int basimYili = (int)nudBasimYili.Value;
            int toplamAdet = (int)nudToplamAdet.Value;
            int kategoriId = Convert.ToInt32(cmbKategori.SelectedValue);

            if (string.IsNullOrWhiteSpace(kitapAdi) ||
                string.IsNullOrWhiteSpace(yazar) ||
                string.IsNullOrWhiteSpace(yayinevi))
            {
                MessageBox.Show("Kitap Adı / Yazar / Yayınevi boş olamaz.");
                return;
            }

            try
            {
                var mevcutObj = await Db.ScalarAsync("SELECT MevcutAdet FROM kitap WHERE KitapID=@id", ("@id", kitapId));
                int mevcut = Convert.ToInt32(mevcutObj ?? 0);

                if (mevcut > toplamAdet)
                {
                    MessageBox.Show($"MevcutAdet ({mevcut}) yeni ToplamAdet'ten ({toplamAdet}) büyük olamaz.");
                    return;
                }

                await Db.ExecAsync(@"
                    UPDATE kitap
                    SET KitapAdi=@ad, Yazar=@y, KategoriID=@kat, Yayinevi=@yay,
                        BasimYili=@by, ToplamAdet=@ta
                    WHERE KitapID=@id;",
                    ("@ad", kitapAdi),
                    ("@y", yazar),
                    ("@kat", kategoriId),
                    ("@yay", yayinevi),
                    ("@by", basimYili),
                    ("@ta", toplamAdet),
                    ("@id", kitapId));

                MessageBox.Show("Kitap güncellendi.");
                await KitaplariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (Session.RolID != 1)
            {
                MessageBox.Show("Silme yetkin yok.");
                return;
            }

            if (!int.TryParse(txtKitapID.Text, out int kitapId))
            {
                MessageBox.Show("Silmek için listeden kitap seç.");
                return;
            }

            var r = MessageBox.Show("Seçili kitabı silmek istiyor musun?", "Onay", MessageBoxButtons.YesNo);
            if (r != DialogResult.Yes) return;

            try
            {
                await Db.ExecAsync("DELETE FROM kitap WHERE KitapID=@id;", ("@id", kitapId));
                MessageBox.Show("Kitap silindi.");
                FormTemizle();
                await KitaplariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void FormTemizle()
        {
            txtKitapID.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinevi.Clear();
            cmbKategori.SelectedIndex = -1;
            nudBasimYili.Value = nudBasimYili.Minimum;
            nudToplamAdet.Value = nudToplamAdet.Minimum;
        }
    }
}
