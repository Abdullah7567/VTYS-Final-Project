namespace VTYSFinalProject
{
    partial class RaporForm
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
            tabRaporlar = new TabControl();
            tabKitapRapor = new TabPage();
            pnlTopKitap = new Panel();
            btnKitapRaporGetir = new Button();
            chkSon30GunKitap = new CheckBox();
            nudTopN = new NumericUpDown();
            ara = new Label();
            dgvKitapRapor = new DataGridView();
            tabBorcRapor = new TabPage();
            pnlTopBorc = new Panel();
            txtMinBorc = new TextBox();
            btnBorcRaporGetir = new Button();
            chkSadeceBorcOlanlar = new CheckBox();
            label1 = new Label();
            dgvBorcRapor = new DataGridView();
            tabGecikmeRapor = new TabPage();
            pnlTopGecikme = new Panel();
            btnGecikmeRaporGetir = new Button();
            chkSadeceTeslimEdilmemis = new CheckBox();
            chkSadeceGecikmis = new CheckBox();
            dgvGecikmeRapor = new DataGridView();
            tabRaporlar.SuspendLayout();
            tabKitapRapor.SuspendLayout();
            pnlTopKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapRapor).BeginInit();
            tabBorcRapor.SuspendLayout();
            pnlTopBorc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorcRapor).BeginInit();
            tabGecikmeRapor.SuspendLayout();
            pnlTopGecikme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecikmeRapor).BeginInit();
            SuspendLayout();
            // 
            // tabRaporlar
            // 
            tabRaporlar.Controls.Add(tabKitapRapor);
            tabRaporlar.Controls.Add(tabBorcRapor);
            tabRaporlar.Controls.Add(tabGecikmeRapor);
            tabRaporlar.Location = new Point(12, 12);
            tabRaporlar.Name = "tabRaporlar";
            tabRaporlar.SelectedIndex = 0;
            tabRaporlar.Size = new Size(1125, 586);
            tabRaporlar.TabIndex = 0;
            // 
            // tabKitapRapor
            // 
            tabKitapRapor.Controls.Add(pnlTopKitap);
            tabKitapRapor.Controls.Add(dgvKitapRapor);
            tabKitapRapor.Location = new Point(4, 29);
            tabKitapRapor.Name = "tabKitapRapor";
            tabKitapRapor.Padding = new Padding(3);
            tabKitapRapor.Size = new Size(1117, 553);
            tabKitapRapor.TabIndex = 0;
            tabKitapRapor.Text = "En Çok Ödünç Alınan Kitaplar";
            tabKitapRapor.UseVisualStyleBackColor = true;
            // 
            // pnlTopKitap
            // 
            pnlTopKitap.Controls.Add(btnKitapRaporGetir);
            pnlTopKitap.Controls.Add(chkSon30GunKitap);
            pnlTopKitap.Controls.Add(nudTopN);
            pnlTopKitap.Controls.Add(ara);
            pnlTopKitap.Location = new Point(6, 6);
            pnlTopKitap.Name = "pnlTopKitap";
            pnlTopKitap.Size = new Size(1105, 60);
            pnlTopKitap.TabIndex = 17;
            // 
            // btnKitapRaporGetir
            // 
            btnKitapRaporGetir.Font = new Font("Segoe UI", 10F);
            btnKitapRaporGetir.Location = new Point(452, 12);
            btnKitapRaporGetir.Name = "btnKitapRaporGetir";
            btnKitapRaporGetir.Size = new Size(94, 35);
            btnKitapRaporGetir.TabIndex = 4;
            btnKitapRaporGetir.Text = "Getir";
            btnKitapRaporGetir.UseVisualStyleBackColor = true;
            btnKitapRaporGetir.Click += btnKitapRaporGetir_Click;
            // 
            // chkSon30GunKitap
            // 
            chkSon30GunKitap.AutoSize = true;
            chkSon30GunKitap.Location = new Point(310, 19);
            chkSon30GunKitap.Name = "chkSon30GunKitap";
            chkSon30GunKitap.Size = new Size(105, 24);
            chkSon30GunKitap.TabIndex = 3;
            chkSon30GunKitap.Text = "Son 30 gün";
            chkSon30GunKitap.UseVisualStyleBackColor = true;
            // 
            // nudTopN
            // 
            nudTopN.Location = new Point(127, 16);
            nudTopN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTopN.Name = "nudTopN";
            nudTopN.Size = new Size(150, 27);
            nudTopN.TabIndex = 2;
            nudTopN.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(3, 11);
            ara.Name = "ara";
            ara.Size = new Size(118, 32);
            ara.TabIndex = 1;
            ara.Text = "Top N -> ";
            // 
            // dgvKitapRapor
            // 
            dgvKitapRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKitapRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitapRapor.Location = new Point(6, 72);
            dgvKitapRapor.MultiSelect = false;
            dgvKitapRapor.Name = "dgvKitapRapor";
            dgvKitapRapor.ReadOnly = true;
            dgvKitapRapor.RowHeadersWidth = 51;
            dgvKitapRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitapRapor.Size = new Size(1105, 475);
            dgvKitapRapor.TabIndex = 16;
            // 
            // tabBorcRapor
            // 
            tabBorcRapor.Controls.Add(pnlTopBorc);
            tabBorcRapor.Controls.Add(dgvBorcRapor);
            tabBorcRapor.Location = new Point(4, 29);
            tabBorcRapor.Name = "tabBorcRapor";
            tabBorcRapor.Padding = new Padding(3);
            tabBorcRapor.Size = new Size(1117, 553);
            tabBorcRapor.TabIndex = 1;
            tabBorcRapor.Text = "En Borçlu Üyeler";
            tabBorcRapor.UseVisualStyleBackColor = true;
            // 
            // pnlTopBorc
            // 
            pnlTopBorc.Controls.Add(txtMinBorc);
            pnlTopBorc.Controls.Add(btnBorcRaporGetir);
            pnlTopBorc.Controls.Add(chkSadeceBorcOlanlar);
            pnlTopBorc.Controls.Add(label1);
            pnlTopBorc.Location = new Point(6, 6);
            pnlTopBorc.Name = "pnlTopBorc";
            pnlTopBorc.Size = new Size(1105, 60);
            pnlTopBorc.TabIndex = 19;
            // 
            // txtMinBorc
            // 
            txtMinBorc.Font = new Font("Segoe UI", 13F);
            txtMinBorc.Location = new Point(159, 9);
            txtMinBorc.Name = "txtMinBorc";
            txtMinBorc.Size = new Size(238, 36);
            txtMinBorc.TabIndex = 5;
            txtMinBorc.Text = "0";
            // 
            // btnBorcRaporGetir
            // 
            btnBorcRaporGetir.Font = new Font("Segoe UI", 10F);
            btnBorcRaporGetir.Location = new Point(606, 11);
            btnBorcRaporGetir.Name = "btnBorcRaporGetir";
            btnBorcRaporGetir.Size = new Size(94, 35);
            btnBorcRaporGetir.TabIndex = 4;
            btnBorcRaporGetir.Text = "Getir";
            btnBorcRaporGetir.UseVisualStyleBackColor = true;
            btnBorcRaporGetir.Click += btnBorcRaporGetir_Click;
            // 
            // chkSadeceBorcOlanlar
            // 
            chkSadeceBorcOlanlar.AutoSize = true;
            chkSadeceBorcOlanlar.Checked = true;
            chkSadeceBorcOlanlar.CheckState = CheckState.Checked;
            chkSadeceBorcOlanlar.Location = new Point(422, 19);
            chkSadeceBorcOlanlar.Name = "chkSadeceBorcOlanlar";
            chkSadeceBorcOlanlar.Size = new Size(147, 24);
            chkSadeceBorcOlanlar.TabIndex = 3;
            chkSadeceBorcOlanlar.Text = "Sadece borcu > 0";
            chkSadeceBorcOlanlar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 1;
            label1.Text = "Min Borç -> ";
            // 
            // dgvBorcRapor
            // 
            dgvBorcRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorcRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorcRapor.Location = new Point(6, 72);
            dgvBorcRapor.MultiSelect = false;
            dgvBorcRapor.Name = "dgvBorcRapor";
            dgvBorcRapor.ReadOnly = true;
            dgvBorcRapor.RowHeadersWidth = 51;
            dgvBorcRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorcRapor.Size = new Size(1105, 475);
            dgvBorcRapor.TabIndex = 18;
            // 
            // tabGecikmeRapor
            // 
            tabGecikmeRapor.Controls.Add(pnlTopGecikme);
            tabGecikmeRapor.Controls.Add(dgvGecikmeRapor);
            tabGecikmeRapor.Location = new Point(4, 29);
            tabGecikmeRapor.Name = "tabGecikmeRapor";
            tabGecikmeRapor.Padding = new Padding(3);
            tabGecikmeRapor.Size = new Size(1117, 553);
            tabGecikmeRapor.TabIndex = 2;
            tabGecikmeRapor.Text = "Gecikmiş / Teslim Edilmemiş Ödünçler";
            tabGecikmeRapor.UseVisualStyleBackColor = true;
            // 
            // pnlTopGecikme
            // 
            pnlTopGecikme.Controls.Add(btnGecikmeRaporGetir);
            pnlTopGecikme.Controls.Add(chkSadeceTeslimEdilmemis);
            pnlTopGecikme.Controls.Add(chkSadeceGecikmis);
            pnlTopGecikme.Location = new Point(6, 6);
            pnlTopGecikme.Name = "pnlTopGecikme";
            pnlTopGecikme.Size = new Size(1105, 60);
            pnlTopGecikme.TabIndex = 21;
            // 
            // btnGecikmeRaporGetir
            // 
            btnGecikmeRaporGetir.Font = new Font("Segoe UI", 10F);
            btnGecikmeRaporGetir.Location = new Point(402, 11);
            btnGecikmeRaporGetir.Name = "btnGecikmeRaporGetir";
            btnGecikmeRaporGetir.Size = new Size(94, 35);
            btnGecikmeRaporGetir.TabIndex = 4;
            btnGecikmeRaporGetir.Text = "Getir";
            btnGecikmeRaporGetir.UseVisualStyleBackColor = true;
            btnGecikmeRaporGetir.Click += btnGecikmeRaporGetir_Click;
            // 
            // chkSadeceTeslimEdilmemis
            // 
            chkSadeceTeslimEdilmemis.AutoSize = true;
            chkSadeceTeslimEdilmemis.Checked = true;
            chkSadeceTeslimEdilmemis.CheckState = CheckState.Checked;
            chkSadeceTeslimEdilmemis.Location = new Point(14, 18);
            chkSadeceTeslimEdilmemis.Name = "chkSadeceTeslimEdilmemis";
            chkSadeceTeslimEdilmemis.Size = new Size(196, 24);
            chkSadeceTeslimEdilmemis.TabIndex = 3;
            chkSadeceTeslimEdilmemis.Text = "Sadece teslim edilmemiş";
            chkSadeceTeslimEdilmemis.UseVisualStyleBackColor = true;
            // 
            // chkSadeceGecikmis
            // 
            chkSadeceGecikmis.AutoSize = true;
            chkSadeceGecikmis.Checked = true;
            chkSadeceGecikmis.CheckState = CheckState.Checked;
            chkSadeceGecikmis.Location = new Point(226, 18);
            chkSadeceGecikmis.Name = "chkSadeceGecikmis";
            chkSadeceGecikmis.Size = new Size(141, 24);
            chkSadeceGecikmis.TabIndex = 3;
            chkSadeceGecikmis.Text = "Sadece gecikmiş";
            chkSadeceGecikmis.UseVisualStyleBackColor = true;
            // 
            // dgvGecikmeRapor
            // 
            dgvGecikmeRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGecikmeRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGecikmeRapor.Location = new Point(6, 72);
            dgvGecikmeRapor.MultiSelect = false;
            dgvGecikmeRapor.Name = "dgvGecikmeRapor";
            dgvGecikmeRapor.ReadOnly = true;
            dgvGecikmeRapor.RowHeadersWidth = 51;
            dgvGecikmeRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGecikmeRapor.Size = new Size(1105, 475);
            dgvGecikmeRapor.TabIndex = 20;
            // 
            // RaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 610);
            Controls.Add(tabRaporlar);
            Name = "RaporForm";
            Text = "RaporForm";
            Load += RaporForm_Load;
            tabRaporlar.ResumeLayout(false);
            tabKitapRapor.ResumeLayout(false);
            pnlTopKitap.ResumeLayout(false);
            pnlTopKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapRapor).EndInit();
            tabBorcRapor.ResumeLayout(false);
            pnlTopBorc.ResumeLayout(false);
            pnlTopBorc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorcRapor).EndInit();
            tabGecikmeRapor.ResumeLayout(false);
            pnlTopGecikme.ResumeLayout(false);
            pnlTopGecikme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecikmeRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRaporlar;
        private TabPage tabKitapRapor;
        private TabPage tabBorcRapor;
        private TabPage tabGecikmeRapor;
        private DataGridView dgvKitapRapor;
        private Panel pnlTopKitap;
        private CheckBox chkSon30GunKitap;
        private NumericUpDown nudTopN;
        private Label ara;
        private Button btnKitapRaporGetir;
        private Panel pnlTopBorc;
        private Button btnBorcRaporGetir;
        private CheckBox chkSadeceBorcOlanlar;
        private Label label1;
        private DataGridView dgvBorcRapor;
        private TextBox txtMinBorc;
        private Panel pnlTopGecikme;
        private TextBox textBox1;
        private Button btnGecikmeRaporGetir;
        private CheckBox chkSadeceGecikmis;
        private Label label2;
        private DataGridView dgvGecikmeRapor;
        private CheckBox chkSadeceTeslimEdilmemis;
    }
}