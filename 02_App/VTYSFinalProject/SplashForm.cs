using System;
using System.Drawing;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(540, 480);
            this.BackColor = Color.FromArgb(233, 233, 233);

            // Yazı boyutları (isteğe bağlı)
            girisEkraninaGec.Font = new Font(girisEkraninaGec.Font.FontFamily, 14f, girisEkraninaGec.Font.Style);
            welcomeMessage.Font = new Font(welcomeMessage.Font.FontFamily, 24f, welcomeMessage.Font.Style);
            welcomeMessage.BackColor = Color.Transparent;
            welcomeMessage.ForeColor = Color.Black;

            Shown += (_, __) => LayoutControls();
            Resize += (_, __) => LayoutControls();
        }

        private void OpenLoginScreenButton(object sender, EventArgs e)
        {
            using var login = new LoginForm();
            Hide();
            login.ShowDialog();
        }

        private void LayoutControls()
        {
            CenterControl(girisEkraninaGec);
            CenterHorizontalControl(welcomeMessage);
        }

        private void CenterControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
            c.Top = (ClientSize.Height - c.Height) / 2;
        }

        private void CenterHorizontalControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
            c.Top = (ClientSize.Height - c.Height) / 4;
        }
    }
}
