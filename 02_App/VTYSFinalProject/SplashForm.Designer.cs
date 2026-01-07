namespace VTYSFinalProject
{
    partial class SplashForm
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
            welcomeMessage = new Label();
            girisEkraninaGec = new Button();
            SuspendLayout();
            // 
            // welcomeMessage
            // 
            welcomeMessage.AutoSize = true;
            welcomeMessage.Location = new Point(514, 138);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(163, 20);
            welcomeMessage.TabIndex = 0;
            welcomeMessage.Text = "Projemize Hoş Geldiniz";
            welcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // girisEkraninaGec
            // 
            girisEkraninaGec.Location = new Point(431, 345);
            girisEkraninaGec.Name = "girisEkraninaGec";
            girisEkraninaGec.Size = new Size(332, 61);
            girisEkraninaGec.TabIndex = 1;
            girisEkraninaGec.Text = "Giriş Yapmak İçin Tıklayınız";
            girisEkraninaGec.UseVisualStyleBackColor = true;
            girisEkraninaGec.Click += this.OpenLoginScreenButton;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1171, 519);
            Controls.Add(girisEkraninaGec);
            Controls.Add(welcomeMessage);
            Name = "SplashForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeMessage;
        private Button girisEkraninaGec;
    }
}