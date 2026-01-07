using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSFinalProject
{
#nullable disable
    public partial class UyeForm : Form
    {
        public UyeForm()
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
            dgvUyeler.Dock = DockStyle.Fill;
        }

        private async void UyeForm_Load(object sender, EventArgs e)
        {
            if (Session.RolID != 1)
                btnSil.Enabled = false;

            await UyeleriYukle();
        }

        private async Task UyeleriYukle(string ara = null)
        {
            DataTable dt;

            if (string.IsNullOrWhiteSpace(ara))
            {
                dt = await Db.QueryAsync(@"
                    SELECT UyeID, Ad, Soyad, Telefon, Email, ToplamBorc, KayitTarihi
                    FROM uye
                    ORDER BY UyeID DESC;");
            }
            else
            {
                dt = await Db.QueryAsync(@"
                    SELECT UyeID, Ad, Soyad, Telefon, Email, ToplamBorc, KayitTarihi
                    FROM uye
                    WHERE Ad    LIKE CONCAT('%',@q,'%')
                       OR Soyad LIKE CONCAT('%',@q,'%')
                       OR Email LIKE CONCAT('%',@q,'%')
                    ORDER BY UyeID DESC;",
                    ("@q", ara));
            }

            dgvUyeler.DataSource = dt;

            // Liste yüklendikten sonra ilk satırı seçiliyse borcu da yazdır
            BorcLabelGuncelle();
        }

        private void dgvUyeler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;

            txtUyeId.Text = dgvUyeler.CurrentRow.Cells["UyeID"].Value?.ToString() ?? "";
            txtAd.Text = dgvUyeler.CurrentRow.Cells["Ad"].Value?.ToString() ?? "";
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells["Soyad"].Value?.ToString() ?? "";
            txtTelefon.Text = dgvUyeler.CurrentRow.Cells["Telefon"].Value?.ToString() ?? "";
            txtEmail.Text = dgvUyeler.CurrentRow.Cells["Email"].Value?.ToString() ?? "";

            BorcLabelGuncelle();
        }

        // ✅ pnlForm içindeki lblBorc dahil her yerde bulup günceller
        private void BorcLabelGuncelle()
        {
            if (dgvUyeler.CurrentRow == null) return;

            string borcText = dgvUyeler.CurrentRow.Cells["ToplamBorc"].Value?.ToString() ?? "0";

            // Formun tüm alt kontrollerinde ara (panel/table içinde olsa da bulur)
            var found = this.Controls.Find("lblBorc", true);

            if (found.Length > 0 && found[0] is Label lbl)
            {
                lbl.Text = borcText; // Sadece sayı göster
            }
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            await UyeleriYukle();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await UyeleriYukle(txtAra.Text.Trim());
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string tel = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(soyad) ||
                string.IsNullOrWhiteSpace(tel) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ad / Soyad / Telefon / Email boş olamaz.");
                return;
            }

            try
            {
                await Db.ExecAsync(@"
                    INSERT INTO uye (Ad, Soyad, Telefon, Email)
                    VALUES (@ad,@soy,@tel,@em);",
                    ("@ad", ad),
                    ("@soy", soyad),
                    ("@tel", tel),
                    ("@em", email));

                MessageBox.Show("Üye eklendi.");
                await UyeleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUyeId.Text, out int uyeId))
            {
                MessageBox.Show("Güncellemek için listeden üye seç.");
                return;
            }

            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string tel = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(soyad) ||
                string.IsNullOrWhiteSpace(tel) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ad / Soyad / Telefon / Email boş olamaz.");
                return;
            }

            try
            {
                await Db.ExecAsync(@"
                    UPDATE uye
                    SET Ad=@ad, Soyad=@soy, Telefon=@tel, Email=@em
                    WHERE UyeID=@id;",
                    ("@ad", ad),
                    ("@soy", soyad),
                    ("@tel", tel),
                    ("@em", email),
                    ("@id", uyeId));

                MessageBox.Show("Üye güncellendi.");
                await UyeleriYukle();
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

            if (!int.TryParse(txtUyeId.Text, out int uyeId))
            {
                MessageBox.Show("Silmek için listeden üye seç.");
                return;
            }

            var r = MessageBox.Show("Seçili üyeyi silmek istiyor musun?", "Onay", MessageBoxButtons.YesNo);
            if (r != DialogResult.Yes) return;

            try
            {
                await Db.ExecAsync("DELETE FROM uye WHERE UyeID=@id", ("@id", uyeId));
                MessageBox.Show("Üye silindi.");
                await UyeleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
    }
}
