namespace VTYSFinalProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            backToSplashFormButton = new Button();
            pCenter = new Panel();
            loginLabel = new Label();
            pCenter.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 13F);
            usernameTextBox.Location = new Point(0, 69);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Kullanıcı Adı";
            usernameTextBox.Size = new Size(250, 36);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 13F);
            passwordTextBox.Location = new Point(0, 118);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Şifre";
            passwordTextBox.Size = new Size(250, 36);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 13F);
            loginButton.Location = new Point(143, 184);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(107, 41);
            loginButton.TabIndex = 2;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // backToSplashFormButton
            // 
            backToSplashFormButton.Font = new Font("Segoe UI", 13F);
            backToSplashFormButton.Location = new Point(0, 184);
            backToSplashFormButton.Name = "backToSplashFormButton";
            backToSplashFormButton.Size = new Size(107, 41);
            backToSplashFormButton.TabIndex = 3;
            backToSplashFormButton.Text = "Geri";
            backToSplashFormButton.UseVisualStyleBackColor = true;
            backToSplashFormButton.Click += BackToSplashFormButton_Click;
            // 
            // pCenter
            // 
            pCenter.Anchor = AnchorStyles.Bottom;
            pCenter.AutoSize = true;
            pCenter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pCenter.Controls.Add(loginLabel);
            pCenter.Controls.Add(usernameTextBox);
            pCenter.Controls.Add(passwordTextBox);
            pCenter.Controls.Add(loginButton);
            pCenter.Controls.Add(backToSplashFormButton);
            pCenter.Location = new Point(373, 108);
            pCenter.Name = "pCenter";
            pCenter.Size = new Size(253, 228);
            pCenter.TabIndex = 5;
            // 
            // loginLabel
            // 
            loginLabel.Font = new Font("Segoe UI", 14F);
            loginLabel.Location = new Point(0, 10);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(250, 45);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Lütfen Giriş Yapınız";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 553);
            Controls.Add(pCenter);
            Name = "LoginForm";
            Text = "LoginForm";
            Shown += LoginForm_Shown;
            Click += LoginForm_Shown;
            pCenter.ResumeLayout(false);
            pCenter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button backToSplashFormButton;
        private Label loginStateLabel;
        private Panel pCenter;
        private Label loginLabel;
    }
}