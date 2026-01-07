using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class DinamikSorguForm : Form
    {
        public DinamikSorguForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(1280, 720);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            pnlTop.Dock = DockStyle.Top;
            txtSql.Dock = DockStyle.Top;
            lblUyari.Dock = DockStyle.Top;
            dgvSonuc.Dock = DockStyle.Fill;
            pnlBottom.Dock = DockStyle.Bottom;
        }

        private void DinamikSorguForm_Load(object sender, EventArgs e)
        {
            // Hazır sorgular
            cmbHazirSorgular.Items.Clear();
            cmbHazirSorgular.Items.Add("1) Kitapları listele (MevcutAdet desc)");
            cmbHazirSorgular.Items.Add("2) En borçlu 10 üye");
            cmbHazirSorgular.Items.Add("3) Teslim edilmemiş ödünçler");
            cmbHazirSorgular.Items.Add("4) Kategoriye göre kitap sayısı");
            cmbHazirSorgular.Items.Add("5) Son 30 gün ceza kayıtları");
            cmbHazirSorgular.SelectedIndex = 0;

            lblUyari.Text = "Uyarı: Sadece SELECT sorgularına izin verilir.";
            lblMesaj.Text = "";
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            switch (cmbHazirSorgular.SelectedIndex)
            {
                case 0:
                    txtSql.Text = "SELECT KitapID, KitapAdi, Yazar, MevcutAdet FROM kitap ORDER BY MevcutAdet DESC;";
                    break;
                case 1:
                    txtSql.Text = "SELECT UyeID, Ad, Soyad, ToplamBorc FROM uye ORDER BY ToplamBorc DESC LIMIT 10;";
                    break;
                case 2:
                    txtSql.Text = @"SELECT o.OduncID, u.Ad, u.Soyad, k.KitapAdi, o.OduncTarihi, o.SonTeslimTarihi
FROM odunc o
JOIN uye u ON u.UyeID=o.UyeID
JOIN kitap k ON k.KitapID=o.KitapID
WHERE o.TeslimTarihi IS NULL
ORDER BY o.OduncID DESC;";
                    break;
                case 3:
                    txtSql.Text = @"SELECT kat.KategoriAdi, COUNT(*) AS KitapSayisi
FROM kitap k
JOIN kategori kat ON kat.KategoriID = k.KategoriID
GROUP BY kat.KategoriAdi
ORDER BY KitapSayisi DESC;";
                    break;
                case 4:
                    txtSql.Text = @"SELECT CezaID, UyeID, Tutar, CezaTarihi, Aciklama
FROM ceza
WHERE CezaTarihi >= DATE_SUB(NOW(), INTERVAL 30 DAY)
ORDER BY CezaID DESC;";
                    break;
            }
        }

        private async void btnCalistir_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";

            string sql = (txtSql.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(sql))
            {
                MessageBox.Show("SQL boş olamaz.");
                return;
            }

            // Güvenlik: Sadece SELECT
            if (!SadeceSelectMi(sql))
            {
                MessageBox.Show("Sadece SELECT sorgularına izin verilir.\n(INSERT/UPDATE/DELETE/DROP vb. yasak)");
                return;
            }

            try
            {
                var dt = await Db.QueryAsync(sql);
                dgvSonuc.DataSource = dt;

                lblMesaj.Text = $"OK - {dt.Rows.Count} satır geldi.";
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Hata: " + ex.Message;
                MessageBox.Show("Sorgu hatası: " + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSql.Clear();
            dgvSonuc.DataSource = null;
            lblMesaj.Text = "";
        }

        // SELECT kontrolü (basit ama iş görür)
        private bool SadeceSelectMi(string sql)
        {
            string s = sql.Trim().ToLowerInvariant();

            // Birden fazla komut / noktalı virgül engeli (tek sorgu)
            // Son ; olabilir ama arada ekstra ; olmasın
            if (s.Count(c => c == ';') > 1) return false;

            // SELECT ile başlamalı
            if (!s.StartsWith("select")) return false;

            // Yasaklı kelimeler (çok temel koruma)
            string[] banned =
            {
                "insert", "update", "delete", "drop", "truncate", "alter", "create",
                "replace", "grant", "revoke", "shutdown", "rename", "call", "procedure"
            };

            // SELECT içinde subquery olabilir; ama yasaklı kelimeler geçmesin
            foreach (var b in banned)
            {
                if (s.Contains(b + " ")) return false;
                if (s.Contains(b + "\n")) return false;
                if (s.Contains(b + "\r")) return false;
                if (s.Contains(b + "\t")) return false;
            }

            return true;
        }
    }
}
