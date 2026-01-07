using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class CezaForm : Form
    {
        public CezaForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(720, 600);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            pnlTop.Dock = DockStyle.Top;
            dgvCezalar.Dock = DockStyle.Fill;
            pnlBottom.Dock = DockStyle.Bottom;
        }

        private async void CezaForm_Load(object sender, EventArgs e)
        {
            await CezalariYukle();
        }

        private async Task CezalariYukle(string uyeAra = null)
        {
            string tarihFilter = chkSon30Gun.Checked ? "AND c.CezaTarihi >= DATE_SUB(NOW(), INTERVAL 30 DAY)" : "";

            if (string.IsNullOrWhiteSpace(uyeAra))
            {
                var dt = await Db.QueryAsync($@"
                    SELECT
                        c.CezaID, c.OduncID, c.UyeID,
                        u.Ad, u.Soyad,
                        c.Tutar, c.CezaTarihi, c.Aciklama, c.IslemYapanKullaniciID
                    FROM ceza c
                    JOIN uye u ON u.UyeID = c.UyeID
                    WHERE 1=1 {tarihFilter}
                    ORDER BY c.CezaID DESC;");
                dgvCezalar.DataSource = dt;
            }
            else
            {
                var dt = await Db.QueryAsync($@"
                    SELECT
                        c.CezaID, c.OduncID, c.UyeID,
                        u.Ad, u.Soyad,
                        c.Tutar, c.CezaTarihi, c.Aciklama, c.IslemYapanKullaniciID
                    FROM ceza c
                    JOIN uye u ON u.UyeID = c.UyeID
                    WHERE 1=1 {tarihFilter}
                      AND (u.Ad LIKE CONCAT('%',@q,'%')
                       OR u.Soyad LIKE CONCAT('%',@q,'%')
                       OR u.Email LIKE CONCAT('%',@q,'%'))
                    ORDER BY c.CezaID DESC;",
                    ("@q", uyeAra));
                dgvCezalar.DataSource = dt;
            }
        }

        private async Task UyeBorcGoster(int uyeId)
        {
            var obj = await Db.ScalarAsync("SELECT ToplamBorc FROM uye WHERE UyeID=@id;", ("@id", uyeId));
            string borc = (obj == null || obj == DBNull.Value) ? "0" : Convert.ToDecimal(obj).ToString("0.00");
            lblToplamBorc.Text = borc;
        }

        private async void dgvCezalar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCezalar.CurrentRow == null) return;

            var uyeStr = dgvCezalar.CurrentRow.Cells["UyeID"].Value?.ToString() ?? "";
            txtSeciliUyeId.Text = uyeStr;

            if (int.TryParse(uyeStr, out int uyeId))
                await UyeBorcGoster(uyeId);
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await CezalariYukle(txtUyeAra.Text.Trim());
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            txtUyeAra.Clear();
            await CezalariYukle();
        }

        private async void chkSon30Gun_CheckedChanged(object sender, EventArgs e)
        {
            await CezalariYukle(txtUyeAra.Text.Trim());
        }
    }
}
