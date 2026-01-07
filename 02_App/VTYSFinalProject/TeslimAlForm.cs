using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class TeslimAlForm : Form
    {
        public TeslimAlForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(720, 600);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            pnlTop.Dock = DockStyle.Top;
            dgvOduncler.Dock = DockStyle.Fill;
            pnlBottom.Dock = DockStyle.Bottom;
        }

        private async void TeslimAlForm_Load(object sender, EventArgs e)
        {
            chkTeslimEdilmemis.Checked = true;
            await OduncleriYukle();
        }

        private async Task OduncleriYukle(string uyeAra = null)
        {
            // chkTeslimEdilmemis işaretliyse sadece TeslimTarihi NULL olanlar
            string teslimFilter = chkTeslimEdilmemis.Checked ? "AND o.TeslimTarihi IS NULL" : "";

            if (string.IsNullOrWhiteSpace(uyeAra))
            {
                var dt = await Db.QueryAsync($@"
                    SELECT 
                        o.OduncID, o.UyeID, u.Ad, u.Soyad,
                        o.KitapID, k.KitapAdi,
                        o.OduncTarihi, o.SonTeslimTarihi, o.TeslimTarihi
                    FROM odunc o
                    JOIN uye u ON u.UyeID = o.UyeID
                    JOIN kitap k ON k.KitapID = o.KitapID
                    WHERE 1=1 {teslimFilter}
                    ORDER BY o.OduncID DESC;");
                dgvOduncler.DataSource = dt;
            }
            else
            {
                var dt = await Db.QueryAsync($@"
                    SELECT 
                        o.OduncID, o.UyeID, u.Ad, u.Soyad,
                        o.KitapID, k.KitapAdi,
                        o.OduncTarihi, o.SonTeslimTarihi, o.TeslimTarihi
                    FROM odunc o
                    JOIN uye u ON u.UyeID = o.UyeID
                    JOIN kitap k ON k.KitapID = o.KitapID
                    WHERE 1=1 {teslimFilter}
                      AND (u.Ad LIKE CONCAT('%',@q,'%')
                       OR u.Soyad LIKE CONCAT('%',@q,'%')
                       OR u.Email LIKE CONCAT('%',@q,'%'))
                    ORDER BY o.OduncID DESC;",
                    ("@q", uyeAra));
                dgvOduncler.DataSource = dt;
            }
        }

        private void dgvOduncler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncler.CurrentRow == null) return;
            txtOduncId.Text = dgvOduncler.CurrentRow.Cells["OduncID"].Value?.ToString() ?? "";
        }

        private async void btnUyeAra_Click(object sender, EventArgs e)
        {
            await OduncleriYukle(txtUyeAra.Text.Trim());
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            txtUyeAra.Clear();
            await OduncleriYukle();
        }

        private async void chkTeslimEdilmemis_CheckedChanged(object sender, EventArgs e)
        {
            await OduncleriYukle(txtUyeAra.Text.Trim());
        }

        private async void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOduncId.Text, out int oduncId))
            {
                MessageBox.Show("Listeden bir ödünç kaydı seç.");
                return;
            }

            try
            {
                await Db.ExecAsync("CALL sp_KitapTeslimAl(@oid, NOW());", ("@oid", oduncId));

                MessageBox.Show("Teslim alındı ✅");

                // Listeyi yenile
                await OduncleriYukle(txtUyeAra.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teslim alma hatası: " + ex.Message);
            }
        }
    }
}
