namespace VTYSFinalProject
{
    partial class KitapForm
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
            cmbKategori = new ComboBox();
            nudToplamAdet = new NumericUpDown();
            nudBasimYili = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtYayinevi = new TextBox();
            txtYazar = new TextBox();
            txtKitapAdi = new TextBox();
            txtKitapID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlButtons = new Panel();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dgvKitaplar = new DataGridView();
            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            tblForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudToplamAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBasimYili).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(txtAra);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(11, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 11, 10, 11);
            pnlTop.Size = new Size(1099, 77);
            pnlTop.TabIndex = 1;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10F);
            btnYenile.Location = new Point(478, 20);
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
            btnAra.Location = new Point(363, 19);
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
            txtAra.Location = new Point(90, 19);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "(Ad/Yazar)";
            txtAra.Size = new Size(238, 36);
            txtAra.TabIndex = 1;
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(10, 19);
            ara.Name = "ara";
            ara.Size = new Size(82, 32);
            ara.TabIndex = 0;
            ara.Text = "Ara ->";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(tblForm);
            pnlForm.Location = new Point(11, 95);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1099, 200);
            pnlForm.TabIndex = 4;
            // 
            // tblForm
            // 
            tblForm.ColumnCount = 4;
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.32541F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.67459F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 377F));
            tblForm.Controls.Add(cmbKategori, 3, 2);
            tblForm.Controls.Add(nudToplamAdet, 3, 1);
            tblForm.Controls.Add(nudBasimYili, 3, 0);
            tblForm.Controls.Add(label7, 2, 2);
            tblForm.Controls.Add(label6, 2, 1);
            tblForm.Controls.Add(label5, 2, 0);
            tblForm.Controls.Add(txtYayinevi, 1, 3);
            tblForm.Controls.Add(txtYazar, 1, 2);
            tblForm.Controls.Add(txtKitapAdi, 1, 1);
            tblForm.Controls.Add(txtKitapID, 1, 0);
            tblForm.Controls.Add(label4, 0, 3);
            tblForm.Controls.Add(label3, 0, 2);
            tblForm.Controls.Add(label2, 0, 1);
            tblForm.Controls.Add(label1, 0, 0);
            tblForm.Location = new Point(3, 3);
            tblForm.Name = "tblForm";
            tblForm.RowCount = 4;
            tblForm.RowStyles.Add(new RowStyle(SizeType.Percent, 43.3734932F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Percent, 56.6265068F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblForm.Size = new Size(1097, 197);
            tblForm.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(722, 95);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 5;
            // 
            // nudToplamAdet
            // 
            nudToplamAdet.Location = new Point(722, 43);
            nudToplamAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudToplamAdet.Name = "nudToplamAdet";
            nudToplamAdet.Size = new Size(150, 27);
            nudToplamAdet.TabIndex = 6;
            // 
            // nudBasimYili
            // 
            nudBasimYili.Location = new Point(722, 3);
            nudBasimYili.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudBasimYili.Minimum = new decimal(new int[] { 1500, 0, 0, 0 });
            nudBasimYili.Name = "nudBasimYili";
            nudBasimYili.Size = new Size(150, 27);
            nudBasimYili.TabIndex = 5;
            nudBasimYili.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(548, 92);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 8;
            label7.Text = "Kategori";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(548, 40);
            label6.Name = "label6";
            label6.Size = new Size(149, 32);
            label6.TabIndex = 7;
            label6.Text = "Toplam Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(548, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 6;
            label5.Text = "Basım Yılı";
            // 
            // txtYayinevi
            // 
            txtYayinevi.Font = new Font("Segoe UI", 13F);
            txtYayinevi.Location = new Point(146, 146);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(238, 36);
            txtYayinevi.TabIndex = 8;
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI", 13F);
            txtYazar.Location = new Point(146, 95);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(238, 36);
            txtYazar.TabIndex = 7;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI", 13F);
            txtKitapAdi.Location = new Point(146, 43);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(238, 36);
            txtKitapAdi.TabIndex = 6;
            // 
            // txtKitapID
            // 
            txtKitapID.Font = new Font("Segoe UI", 13F);
            txtKitapID.Location = new Point(146, 3);
            txtKitapID.Name = "txtKitapID";
            txtKitapID.ReadOnly = true;
            txtKitapID.Size = new Size(238, 36);
            txtKitapID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 143);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 8;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 7;
            label3.Text = "Yazar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 6;
            label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 5;
            label1.Text = "KitapID";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSil);
            pnlButtons.Controls.Add(btnGuncelle);
            pnlButtons.Controls.Add(btnEkle);
            pnlButtons.Location = new Point(11, 301);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(10, 11, 10, 11);
            pnlButtons.Size = new Size(1099, 77);
            pnlButtons.TabIndex = 5;
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
            // dgvKitaplar
            // 
            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(11, 384);
            dgvKitaplar.MultiSelect = false;
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.ReadOnly = true;
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(1099, 220);
            dgvKitaplar.TabIndex = 6;
            dgvKitaplar.SelectionChanged += dgvKitaplar_SelectionChanged;
            // 
            // KitapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 616);
            Controls.Add(dgvKitaplar);
            Controls.Add(pnlButtons);
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Name = "KitapForm";
            Text = "KitapForm";
            Load += KitapForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlForm.ResumeLayout(false);
            tblForm.ResumeLayout(false);
            tblForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudToplamAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBasimYili).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTop;
        private TextBox txtAra;
        private Label ara;
        private Button button2;
        private Button btnAra;
        private Button btnYenile;
        private FlowLayoutPanel pnlForm;
        private TableLayoutPanel tblForm;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox txtYayinevi;
        private TextBox txtYazar;
        private TextBox txtKitapAdi;
        private TextBox txtKitapID;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbKategori;
        private NumericUpDown nudToplamAdet;
        private NumericUpDown nudBasimYili;
        private Label label7;
        private Panel pnlButtons;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DataGridView dgvKitaplar;
    }
}