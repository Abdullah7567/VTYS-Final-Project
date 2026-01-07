using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(1280, 720);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock sırası
            tabRaporlar.Dock = DockStyle.Fill;
            pnlTopKitap.Dock = DockStyle.Top;
            dgvKitapRapor.Dock = DockStyle.Bottom;
            pnlTopBorc.Dock = DockStyle.Top;
            dgvBorcRapor.Dock = DockStyle.Bottom;
            pnlTopGecikme.Dock = DockStyle.Top;
            dgvGecikmeRapor.Dock = DockStyle.Bottom;
        }

        private async void RaporForm_Load(object sender, EventArgs e)
        {
            // Varsayılanlar
            if (nudTopN != null) nudTopN.Value = 10;
            if (txtMinBorc != null) txtMinBorc.Text = "0";
            if (chkSadeceBorcOlanlar != null) chkSadeceBorcOlanlar.Checked = true;
            if (chkSadeceTeslimEdilmemis != null) chkSadeceTeslimEdilmemis.Checked = true;
            if (chkSadeceGecikmis != null) chkSadeceGecikmis.Checked = true;

            // Açılışta ilk raporu yükle
            await KitapRaporGetir();
        }

        // ---------------- TAB 1: En çok ödünç alınan kitaplar ----------------
        private async Task KitapRaporGetir()
        {
            int topN = (int)nudTopN.Value;
            bool son30 = chkSon30GunKitap.Checked;

            string tarihFilter = son30 ? "WHERE o.OduncTarihi >= DATE_SUB(NOW(), INTERVAL 30 DAY)" : "";

            var dt = await Db.QueryAsync($@"
                SELECT
                    k.KitapID,
                    k.KitapAdi,
                    k.Yazar,
                    COUNT(*) AS OduncSayisi
                FROM odunc o
                JOIN kitap k ON k.KitapID = o.KitapID
                {tarihFilter}
                GROUP BY k.KitapID, k.KitapAdi, k.Yazar
                ORDER BY OduncSayisi DESC
                LIMIT {topN};");

            dgvKitapRapor.DataSource = dt;
        }

        private async void btnKitapRaporGetir_Click(object sender, EventArgs e)
        {
            await KitapRaporGetir();
        }

        // ---------------- TAB 2: En borçlu üyeler ----------------
        private async Task BorcRaporGetir()
        {
            // min borç parse
            decimal minBorc = 0;
            decimal.TryParse(txtMinBorc.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out minBorc);

            bool sadeceBorcOlan = chkSadeceBorcOlanlar.Checked;

            string where = "WHERE 1=1 ";
            if (sadeceBorcOlan) where += "AND u.ToplamBorc > 0 ";
            where += "AND u.ToplamBorc >= @min ";

            var dt = await Db.QueryAsync($@"
                SELECT
                    u.UyeID,
                    u.Ad,
                    u.Soyad,
                    u.Email,
                    u.Telefon,
                    u.ToplamBorc
                FROM uye u
                {where}
                ORDER BY u.ToplamBorc DESC, u.UyeID DESC
                LIMIT 50;",
                ("@min", minBorc));

            dgvBorcRapor.DataSource = dt;
        }

        private async void btnBorcRaporGetir_Click(object sender, EventArgs e)
        {
            await BorcRaporGetir();
        }

        // ---------------- TAB 3: Gecikmiş / teslim edilmemiş ödünçler ----------------
        private async Task GecikmeRaporGetir()
        {
            bool sadeceTeslimEdilmemis = chkSadeceTeslimEdilmemis.Checked;
            bool sadeceGecikmis = chkSadeceGecikmis.Checked;

            // Base query
            string where = "WHERE 1=1 ";

            if (sadeceTeslimEdilmemis)
                where += "AND o.TeslimTarihi IS NULL ";

            if (sadeceGecikmis)
            {
                // gecikmiş tanımı:
                // - teslim edilmemiş ve son teslim geçmiş
                // veya
                // - teslim edilmiş ama geç teslim edilmiş
                where += @"AND (
                    (o.TeslimTarihi IS NULL AND NOW() > o.SonTeslimTarihi)
                    OR
                    (o.TeslimTarihi IS NOT NULL AND o.TeslimTarihi > o.SonTeslimTarihi)
                ) ";
            }

            var dt = await Db.QueryAsync($@"
                SELECT
                    o.OduncID,
                    o.UyeID,
                    u.Ad,
                    u.Soyad,
                    o.KitapID,
                    k.KitapAdi,
                    o.OduncTarihi,
                    o.SonTeslimTarihi,
                    o.TeslimTarihi,
                    CASE
                        WHEN o.TeslimTarihi IS NULL AND NOW() > o.SonTeslimTarihi
                            THEN DATEDIFF(NOW(), o.SonTeslimTarihi)
                        WHEN o.TeslimTarihi IS NOT NULL AND o.TeslimTarihi > o.SonTeslimTarihi
                            THEN DATEDIFF(o.TeslimTarihi, o.SonTeslimTarihi)
                        ELSE 0
                    END AS GecikmeGun
                FROM odunc o
                JOIN uye u ON u.UyeID = o.UyeID
                JOIN kitap k ON k.KitapID = o.KitapID
                {where}
                ORDER BY o.OduncID DESC
                LIMIT 200;");

            dgvGecikmeRapor.DataSource = dt;
        }

        private async void btnGecikmeRaporGetir_Click(object sender, EventArgs e)
        {
            await GecikmeRaporGetir();
        }
    }
}
