using System;
using System.Drawing;
using System.Windows.Forms;

namespace VTYSFinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Form ayarları
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1280, 720);
            this.MinimumSize = new Size(540, 480);
            this.BackColor = Color.FromArgb(233, 233, 233);

            Shown += (_, __) => CenterPanel();
            Resize += (_, __) => CenterPanel();

            // Enter ile giriş / Esc ile geri
            AcceptButton = loginButton;
            CancelButton = backToSplashFormButton;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            // Açılışta kullanıcı adı kutusuna odak ver
            ActiveControl = usernameTextBox;
        }

        private void CenterPanel()
        {
            if (pCenter == null) return;
            pCenter.Left = (ClientSize.Width - pCenter.Width) / 2;
            pCenter.Top = (ClientSize.Height - pCenter.Height) / 2;
        }

        private void BackToSplashFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text.Trim();
            string pass = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            loginButton.Enabled = false;

            try
            {
                var (ok, kullaniciId, rolId) = await Db.LoginAsync(user, pass);

                if (!ok)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
                    return;
                }

                Session.KullaniciID = kullaniciId;
                Session.RolID = rolId;
                Session.KullaniciAdi = user;

                var menu = new MenuForm();

                // Menü kapanınca login de kapansın (gizli form kalmasın)
                menu.FormClosed += (_, __) => this.Close();

                menu.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında hata: " + ex.Message);
            }
            finally
            {
                loginButton.Enabled = true;
            }
        }
    }
}
