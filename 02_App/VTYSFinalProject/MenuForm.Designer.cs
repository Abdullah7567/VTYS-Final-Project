namespace VTYSFinalProject
{
    partial class MenuForm
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
            btnLogout = new Button();
            lblKullanici = new Label();
            lblRol = new Label();
            pUser = new Panel();
            pButtonsContainer = new Panel();
            pButtons = new Panel();
            btnUyeler = new Button();
            btnKitaplar = new Button();
            btnDinamikSorgu = new Button();
            btnTeslimAl = new Button();
            btnOduncVer = new Button();
            btnCezalar = new Button();
            btnRaporlar = new Button();
            pUser.SuspendLayout();
            pButtonsContainer.SuspendLayout();
            pButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.Font = new Font("Segoe UI", 13F);
            btnLogout.Location = new Point(682, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 60);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Font = new Font("Segoe UI", 13F);
            lblKullanici.Location = new Point(23, 20);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(121, 30);
            lblKullanici.TabIndex = 1;
            lblKullanici.Text = "Kullanıcı ->";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 13F);
            lblRol.Location = new Point(23, 50);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(121, 30);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol         ->";
            // 
            // pUser
            // 
            pUser.AutoSize = true;
            pUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pUser.Controls.Add(lblKullanici);
            pUser.Controls.Add(btnLogout);
            pUser.Controls.Add(lblRol);
            pUser.Location = new Point(12, 12);
            pUser.Name = "pUser";
            pUser.Padding = new Padding(20);
            pUser.Size = new Size(799, 103);
            pUser.TabIndex = 3;
            // 
            // pButtonsContainer
            // 
            pButtonsContainer.Anchor = AnchorStyles.None;
            pButtonsContainer.AutoSize = true;
            pButtonsContainer.Controls.Add(pButtons);
            pButtonsContainer.Location = new Point(12, 121);
            pButtonsContainer.Name = "pButtonsContainer";
            pButtonsContainer.Size = new Size(799, 511);
            pButtonsContainer.TabIndex = 4;
            // 
            // pButtons
            // 
            pButtons.AutoSize = true;
            pButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pButtons.Controls.Add(btnUyeler);
            pButtons.Controls.Add(btnKitaplar);
            pButtons.Controls.Add(btnDinamikSorgu);
            pButtons.Controls.Add(btnTeslimAl);
            pButtons.Controls.Add(btnOduncVer);
            pButtons.Controls.Add(btnCezalar);
            pButtons.Controls.Add(btnRaporlar);
            pButtons.Location = new Point(263, 70);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(264, 357);
            pButtons.TabIndex = 7;
            // 
            // btnUyeler
            // 
            btnUyeler.Font = new Font("Segoe UI", 13F);
            btnUyeler.Location = new Point(3, 3);
            btnUyeler.Name = "btnUyeler";
            btnUyeler.Size = new Size(258, 45);
            btnUyeler.TabIndex = 0;
            btnUyeler.Text = "Üye Yönetimi";
            btnUyeler.UseVisualStyleBackColor = true;
            btnUyeler.Click += btnUyeler_Click;
            // 
            // btnKitaplar
            // 
            btnKitaplar.Font = new Font("Segoe UI", 13F);
            btnKitaplar.Location = new Point(3, 54);
            btnKitaplar.Name = "btnKitaplar";
            btnKitaplar.Size = new Size(258, 45);
            btnKitaplar.TabIndex = 6;
            btnKitaplar.Text = "Kitap Yönetimi";
            btnKitaplar.UseVisualStyleBackColor = true;
            btnKitaplar.Click += btnKitaplar_Click;
            // 
            // btnDinamikSorgu
            // 
            btnDinamikSorgu.Font = new Font("Segoe UI", 13F);
            btnDinamikSorgu.Location = new Point(3, 309);
            btnDinamikSorgu.Name = "btnDinamikSorgu";
            btnDinamikSorgu.Size = new Size(258, 45);
            btnDinamikSorgu.TabIndex = 2;
            btnDinamikSorgu.Text = "Dinamik Sorgu";
            btnDinamikSorgu.UseVisualStyleBackColor = true;
            btnDinamikSorgu.Click += btnDinamikSorgu_Click;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Font = new Font("Segoe UI", 13F);
            btnTeslimAl.Location = new Point(3, 156);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(258, 45);
            btnTeslimAl.TabIndex = 4;
            btnTeslimAl.Text = "Teslim Alma";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI", 13F);
            btnOduncVer.Location = new Point(3, 105);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(258, 45);
            btnOduncVer.TabIndex = 1;
            btnOduncVer.Text = "Ödünç Verme";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnCezalar
            // 
            btnCezalar.Font = new Font("Segoe UI", 13F);
            btnCezalar.Location = new Point(3, 207);
            btnCezalar.Name = "btnCezalar";
            btnCezalar.Size = new Size(258, 45);
            btnCezalar.TabIndex = 5;
            btnCezalar.Text = "Ceza Görüntüleme";
            btnCezalar.UseVisualStyleBackColor = true;
            btnCezalar.Click += btnCezalar_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Font = new Font("Segoe UI", 13F);
            btnRaporlar.Location = new Point(3, 258);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(258, 45);
            btnRaporlar.TabIndex = 3;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 644);
            Controls.Add(pButtonsContainer);
            Controls.Add(pUser);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            pUser.ResumeLayout(false);
            pUser.PerformLayout();
            pButtonsContainer.ResumeLayout(false);
            pButtonsContainer.PerformLayout();
            pButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label lblKullanici;
        private Label lblRol;
        private Panel pUser;
        private Panel pButtonsContainer;
        private Button btnKitaplar;
        private Button btnCezalar;
        private Button btnTeslimAl;
        private Button btnRaporlar;
        private Button btnDinamikSorgu;
        private Button btnOduncVer;
        private Button btnUyeler;
        private Panel pButtons;
    }
}