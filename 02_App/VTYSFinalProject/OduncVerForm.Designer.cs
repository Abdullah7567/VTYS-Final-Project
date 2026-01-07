namespace VTYSFinalProject
{
    partial class OduncVerForm
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
            btnKitapAra = new Button();
            txtKitapAra = new TextBox();
            btnUyeAra = new Button();
            label1 = new Label();
            txtUyeAra = new TextBox();
            ara = new Label();
            dgvUyeler = new DataGridView();
            dgvKitaplar = new DataGridView();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label2 = new Label();
            txtSeciliUyeId = new TextBox();
            txtSeciliKitapId = new TextBox();
            label3 = new Label();
            btnOduncVer = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnKitapAra);
            pnlTop.Controls.Add(txtKitapAra);
            pnlTop.Controls.Add(btnUyeAra);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(txtUyeAra);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 11, 10, 11);
            pnlTop.Size = new Size(1115, 123);
            pnlTop.TabIndex = 10;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10F);
            btnYenile.Location = new Point(551, 44);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(94, 35);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKitapAra
            // 
            btnKitapAra.Font = new Font("Segoe UI", 10F);
            btnKitapAra.Location = new Point(435, 67);
            btnKitapAra.Name = "btnKitapAra";
            btnKitapAra.Size = new Size(94, 35);
            btnKitapAra.TabIndex = 2;
            btnKitapAra.Text = "Ara";
            btnKitapAra.UseVisualStyleBackColor = true;
            btnKitapAra.Click += btnKitapAra_Click;
            // 
            // txtKitapAra
            // 
            txtKitapAra.Font = new Font("Segoe UI", 13F);
            txtKitapAra.Location = new Point(169, 64);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.PlaceholderText = "(Ad/Yazar)";
            txtKitapAra.Size = new Size(238, 36);
            txtKitapAra.TabIndex = 1;
            // 
            // btnUyeAra
            // 
            btnUyeAra.Font = new Font("Segoe UI", 10F);
            btnUyeAra.Location = new Point(435, 26);
            btnUyeAra.Name = "btnUyeAra";
            btnUyeAra.Size = new Size(94, 35);
            btnUyeAra.TabIndex = 2;
            btnUyeAra.Text = "Ara";
            btnUyeAra.UseVisualStyleBackColor = true;
            btnUyeAra.Click += btnUyeAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(13, 66);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Kitap Ara -> ";
            // 
            // txtUyeAra
            // 
            txtUyeAra.Font = new Font("Segoe UI", 13F);
            txtUyeAra.Location = new Point(169, 22);
            txtUyeAra.Name = "txtUyeAra";
            txtUyeAra.PlaceholderText = "(Ad/Soyad/Email)";
            txtUyeAra.Size = new Size(238, 36);
            txtUyeAra.TabIndex = 1;
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(13, 25);
            ara.Name = "ara";
            ara.Size = new Size(137, 32);
            ara.TabIndex = 0;
            ara.Text = "Üye Ara -> ";
            // 
            // dgvUyeler
            // 
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(0, 0);
            dgvUyeler.MultiSelect = false;
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.ReadOnly = true;
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(551, 272);
            dgvUyeler.TabIndex = 11;
            dgvUyeler.SelectionChanged += dgvUyeler_SelectionChanged;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(-1, 0);
            dgvKitaplar.MultiSelect = false;
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.ReadOnly = true;
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(555, 272);
            dgvKitaplar.TabIndex = 12;
            dgvKitaplar.SelectionChanged += dgvKitaplar_SelectionChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 141);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvUyeler);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvKitaplar);
            splitContainer1.Size = new Size(1115, 272);
            splitContainer1.SplitterDistance = 554;
            splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(12, 419);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(txtSeciliUyeId);
            splitContainer2.Panel1.Controls.Add(txtSeciliKitapId);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnOduncVer);
            splitContainer2.Size = new Size(1115, 136);
            splitContainer2.SplitterDistance = 555;
            splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 1;
            label2.Text = "Seçili ÜyeID -> ";
            // 
            // txtSeciliUyeId
            // 
            txtSeciliUyeId.Font = new Font("Segoe UI", 13F);
            txtSeciliUyeId.Location = new Point(199, 11);
            txtSeciliUyeId.Name = "txtSeciliUyeId";
            txtSeciliUyeId.ReadOnly = true;
            txtSeciliUyeId.Size = new Size(238, 36);
            txtSeciliUyeId.TabIndex = 2;
            // 
            // txtSeciliKitapId
            // 
            txtSeciliKitapId.Font = new Font("Segoe UI", 13F);
            txtSeciliKitapId.Location = new Point(199, 53);
            txtSeciliKitapId.Name = "txtSeciliKitapId";
            txtSeciliKitapId.ReadOnly = true;
            txtSeciliKitapId.Size = new Size(238, 36);
            txtSeciliKitapId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 55);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 1;
            label3.Text = "Seçili KitapID -> ";
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI", 10F);
            btnOduncVer.Location = new Point(415, 13);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(125, 43);
            btnOduncVer.TabIndex = 3;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // OduncVerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 560);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Controls.Add(pnlTop);
            Name = "OduncVerForm";
            Text = "OduncVerForm";
            Load += OduncVerForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnYenile;
        private Button btnUyeAra;
        private TextBox txtUyeAra;
        private Label ara;
        private Button button2;
        private Button btnKitapAra;
        private TextBox txtKitapAra;
        private Label label1;
        private DataGridView dgvUyeler;
        private DataGridView dgvKitaplar;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox txtSeciliUyeId;
        private Label label2;
        private Label label3;
        private TextBox txtSeciliKitapId;
        private Button btnOduncVer;
    }
}