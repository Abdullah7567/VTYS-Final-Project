namespace VTYSFinalProject
{
    partial class UyeForm
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
            pnlTop = new Panel();
            btnYenile = new Button();
            btnAra = new Button();
            txtAra = new TextBox();
            ara = new Label();
            pnlForm = new FlowLayoutPanel();
            tblForm = new TableLayoutPanel();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            txtUyeId = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlButtons = new Panel();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dgvUyeler = new DataGridView();
            lblBorc = new Label();
            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            tblForm.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(txtAra);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 11, 10, 11);
            pnlTop.Size = new Size(1110, 77);
            pnlTop.TabIndex = 9;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10F);
            btnYenile.Location = new Point(490, 23);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(94, 35);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Segoe UI", 10F);
            btnAra.Location = new Point(377, 23);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 35);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 13F);
            txtAra.Location = new Point(101, 23);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "(Ad/Soyad/Email)";
            txtAra.Size = new Size(238, 36);
            txtAra.TabIndex = 1;
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(13, 25);
            ara.Name = "ara";
            ara.Size = new Size(82, 32);
            ara.TabIndex = 0;
            ara.Text = "Ara ->";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(tblForm);
            pnlForm.Location = new Point(12, 95);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(10);
            pnlForm.Size = new Size(1110, 196);
            pnlForm.TabIndex = 10;
            // 
            // tblForm
            // 
            tblForm.ColumnCount = 4;
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.32541F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.67459F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 377F));
            tblForm.Controls.Add(lblBorc, 3, 2);
            tblForm.Controls.Add(txtEmail, 1, 2);
            tblForm.Controls.Add(txtAd, 1, 1);
            tblForm.Controls.Add(txtUyeId, 1, 0);
            tblForm.Controls.Add(txtSoyad, 3, 1);
            tblForm.Controls.Add(txtTelefon, 3, 0);
            tblForm.Controls.Add(label7, 2, 2);
            tblForm.Controls.Add(label6, 2, 1);
            tblForm.Controls.Add(label5, 2, 0);
            tblForm.Controls.Add(label3, 0, 2);
            tblForm.Controls.Add(label2, 0, 1);
            tblForm.Controls.Add(label1, 0, 0);
            tblForm.Location = new Point(13, 13);
            tblForm.Name = "tblForm";
            tblForm.RowCount = 3;
            tblForm.RowStyles.Add(new RowStyle(SizeType.Percent, 49.54955F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50.45045F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblForm.Size = new Size(1085, 170);
            tblForm.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(143, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 36);
            txtEmail.TabIndex = 16;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 13F);
            txtAd.Location = new Point(143, 58);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(238, 36);
            txtAd.TabIndex = 15;
            // 
            // txtUyeId
            // 
            txtUyeId.Font = new Font("Segoe UI", 13F);
            txtUyeId.Location = new Point(143, 3);
            txtUyeId.Name = "txtUyeId";
            txtUyeId.ReadOnly = true;
            txtUyeId.Size = new Size(238, 36);
            txtUyeId.TabIndex = 14;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 13F);
            txtSoyad.Location = new Point(710, 58);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(238, 36);
            txtSoyad.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 13F);
            txtTelefon.Location = new Point(710, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(238, 36);
            txtTelefon.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(536, 111);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 8;
            label7.Text = "Borç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(536, 55);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 7;
            label6.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(536, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 6;
            label5.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 111);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 5;
            label1.Text = "Üye ID";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSil);
            pnlButtons.Controls.Add(btnGuncelle);
            pnlButtons.Controls.Add(btnEkle);
            pnlButtons.Location = new Point(12, 297);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(10, 11, 10, 11);
            pnlButtons.Size = new Size(1110, 77);
            pnlButtons.TabIndex = 11;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 10F);
            btnSil.Location = new Point(629, 21);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 35);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 10F);
            btnGuncelle.Location = new Point(478, 21);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 35);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 10F);
            btnEkle.Location = new Point(322, 21);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 35);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvUyeler
            // 
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(12, 380);
            dgvUyeler.MultiSelect = false;
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.ReadOnly = true;
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(1110, 202);
            dgvUyeler.TabIndex = 12;
            dgvUyeler.SelectionChanged += dgvUyeler_SelectionChanged;
            // 
            // lblBorc
            // 
            lblBorc.AutoSize = true;
            lblBorc.Font = new Font("Segoe UI", 14F);
            lblBorc.Location = new Point(710, 111);
            lblBorc.Name = "lblBorc";
            lblBorc.Size = new Size(27, 32);
            lblBorc.TabIndex = 17;
            lblBorc.Text = "0";
            // 
            // UyeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 594);
            Controls.Add(dgvUyeler);
            Controls.Add(pnlButtons);
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Name = "UyeForm";
            Text = "UyeForm";
            Load += UyeForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlForm.ResumeLayout(false);
            tblForm.ResumeLayout(false);
            tblForm.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblBorc;
        private Panel pnlTop;
        private Button btnYenile;
        private Button btnAra;
        private TextBox txtAra;
        private Label ara;
        private FlowLayoutPanel pnlForm;
        private NumericUpDown nudBasimYili;
        private TextBox txtYazar;
        private Panel pnlButtons;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DataGridView dgvUyeler;
        private TableLayoutPanel tblForm;
        private TextBox txtAd;
        private TextBox txtUyeId;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
    }
}