using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(1280, 720);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            pnlTop.Dock = DockStyle.Top;
            dgvUyeler.Dock = DockStyle.Fill;
            dgvKitaplar.Dock = DockStyle.Fill;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer2.Dock = DockStyle.Bottom;
        }

        private async void OduncVerForm_Load(object sender, EventArgs e)
        {
            await UyeleriYukle();
            await KitaplariYukle();
        }

        private async Task UyeleriYukle(string ara = null)
        {
            DataTable dt;
            if (string.IsNullOrWhiteSpace(ara))
            {
                dt = await Db.QueryAsync("SELECT UyeID, Ad, Soyad, Email, ToplamBorc FROM uye ORDER BY UyeID DESC;");
            }
            else
            {
                dt = await Db.QueryAsync(@"
                    SELECT UyeID, Ad, Soyad, Email, ToplamBorc
                    FROM uye
                    WHERE Ad LIKE CONCAT('%',@q,'%')
                       OR Soyad LIKE CONCAT('%',@q,'%')
                       OR Email LIKE CONCAT('%',@q,'%')
                    ORDER BY UyeID DESC;", ("@q", ara));
            }

            dgvUyeler.DataSource = dt;
        }

        private async Task KitaplariYukle(string ara = null)
        {
            DataTable dt;
            if (string.IsNullOrWhiteSpace(ara))
            {
                dt = await Db.QueryAsync(@"
                    SELECT KitapID, KitapAdi, Yazar, MevcutAdet
                    FROM kitap
                    ORDER BY KitapID DESC;");
            }
            else
            {
                dt = await Db.QueryAsync(@"
                    SELECT KitapID, KitapAdi, Yazar, MevcutAdet
                    FROM kitap
                    WHERE KitapAdi LIKE CONCAT('%',@q,'%')
                       OR Yazar   LIKE CONCAT('%',@q,'%')
                    ORDER BY KitapID DESC;", ("@q", ara));
            }

            dgvKitaplar.DataSource = dt;
        }

        private void dgvUyeler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;
            txtSeciliUyeId.Text = dgvUyeler.CurrentRow.Cells["UyeID"].Value?.ToString() ?? "";
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow == null) return;
            txtSeciliKitapId.Text = dgvKitaplar.CurrentRow.Cells["KitapID"].Value?.ToString() ?? "";
        }

        private async void btnUyeAra_Click(object sender, EventArgs e)
        {
            await UyeleriYukle(txtUyeAra.Text.Trim());
        }

        private async void btnKitapAra_Click(object sender, EventArgs e)
        {
            await KitaplariYukle(txtKitapAra.Text.Trim());
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            txtUyeAra.Clear();
            txtKitapAra.Clear();
            await UyeleriYukle();
            await KitaplariYukle();
        }

        private async void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSeciliUyeId.Text, out int uyeId))
            {
                MessageBox.Show("Listeden bir üye seç.");
                return;
            }

            if (!int.TryParse(txtSeciliKitapId.Text, out int kitapId))
            {
                MessageBox.Show("Listeden bir kitap seç.");
                return;
            }

            try
            {
                // Limit = 5
                await Db.ExecAsync("CALL sp_YeniOduncVer(@uye,@kitap,@kul,@limit);",
                    ("@uye", uyeId),
                    ("@kitap", kitapId),
                    ("@kul", Session.KullaniciID),
                    ("@limit", 5));

                MessageBox.Show("Ödünç verildi ✅");

                // stok güncellendiği için kitapları yenilemek iyi olur
                await KitaplariYukle(txtKitapAra.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödünç verme hatası: " + ex.Message);
            }
        }

    }
}
