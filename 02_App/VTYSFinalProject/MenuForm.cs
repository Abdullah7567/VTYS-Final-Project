using System;
using System.Drawing;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(540, 600);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Dock ayarları
            pUser.Dock = DockStyle.Top;
            pButtonsContainer.Dock = DockStyle.Fill;

            Shown += (_, __) => CenterButtons();
            pButtonsContainer.Resize += (_, __) => CenterButtons();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (Session.KullaniciID <= 0)
            {
                MessageBox.Show("Oturum bulunamadı. Lütfen tekrar giriş yapın.");
                Close();
                return;
            }

            string rol = Session.RolID == 1 ? "Admin" : "Görevli";
            lblKullanici.Text = $"Kullanıcı -> {Session.KullaniciAdi}";
            lblRol.Text = $"Rol         -> {rol}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            var login = new LoginForm();
            login.Show();

            Close();
        }

        private void btnKitaplar_Click(object sender, EventArgs e) => new KitapForm().ShowDialog();
        private void btnUyeler_Click(object sender, EventArgs e) => new UyeForm().ShowDialog();
        private void btnOduncVer_Click(object sender, EventArgs e) => new OduncVerForm().ShowDialog();
        private void btnTeslimAl_Click(object sender, EventArgs e) => new TeslimAlForm().ShowDialog();
        private void btnCezalar_Click(object sender, EventArgs e) => new CezaForm().ShowDialog();
        private void btnRaporlar_Click(object sender, EventArgs e) => new RaporForm().ShowDialog();
        private void btnDinamikSorgu_Click(object sender, EventArgs e) => new DinamikSorguForm().ShowDialog();

        private void CenterButtons()
        {
            if (pButtons == null || pButtonsContainer == null) return;

            pButtons.Left = (pButtonsContainer.ClientSize.Width - pButtons.Width) / 2;
            pButtons.Top = (pButtonsContainer.ClientSize.Height - pButtons.Height) / 2;
        }
    }
}
