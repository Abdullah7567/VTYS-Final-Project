namespace VTYSFinalProject
{
    partial class DinamikSorguForm
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
            cmbHazirSorgular = new ComboBox();
            btnTemizle = new Button();
            btnCalistir = new Button();
            btnYukle = new Button();
            ara = new Label();
            txtSql = new TextBox();
            lblUyari = new Label();
            dgvSonuc = new DataGridView();
            pnlBottom = new Panel();
            lblMesaj = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(cmbHazirSorgular);
            pnlTop.Controls.Add(btnTemizle);
            pnlTop.Controls.Add(btnCalistir);
            pnlTop.Controls.Add(btnYukle);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1106, 90);
            pnlTop.TabIndex = 0;
            // 
            // cmbHazirSorgular
            // 
            cmbHazirSorgular.FormattingEnabled = true;
            cmbHazirSorgular.Location = new Point(202, 29);
            cmbHazirSorgular.Name = "cmbHazirSorgular";
            cmbHazirSorgular.Size = new Size(151, 28);
            cmbHazirSorgular.TabIndex = 9;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI", 10F);
            btnTemizle.Location = new Point(648, 26);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 35);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnCalistir
            // 
            btnCalistir.Font = new Font("Segoe UI", 10F);
            btnCalistir.Location = new Point(528, 26);
            btnCalistir.Name = "btnCalistir";
            btnCalistir.Size = new Size(94, 35);
            btnCalistir.TabIndex = 8;
            btnCalistir.Text = "Çalıştır";
            btnCalistir.UseVisualStyleBackColor = true;
            btnCalistir.Click += btnCalistir_Click;
            // 
            // btnYukle
            // 
            btnYukle.Font = new Font("Segoe UI", 10F);
            btnYukle.Location = new Point(405, 26);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(94, 35);
            btnYukle.TabIndex = 8;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(26, 25);
            ara.Name = "ara";
            ara.Size = new Size(178, 32);
            ara.TabIndex = 5;
            ara.Text = "Hazır Sorgu -> ";
            // 
            // txtSql
            // 
            txtSql.Font = new Font("Consolas", 9F);
            txtSql.Location = new Point(12, 108);
            txtSql.Multiline = true;
            txtSql.Name = "txtSql";
            txtSql.ScrollBars = ScrollBars.Both;
            txtSql.Size = new Size(1106, 200);
            txtSql.TabIndex = 1;
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.ForeColor = Color.Navy;
            lblUyari.Location = new Point(12, 311);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(258, 20);
            lblUyari.TabIndex = 10;
            lblUyari.Text = "Sadece SELECT sorgularına izin verilir.";
            // 
            // dgvSonuc
            // 
            dgvSonuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonuc.Location = new Point(12, 334);
            dgvSonuc.Name = "dgvSonuc";
            dgvSonuc.ReadOnly = true;
            dgvSonuc.RowHeadersWidth = 51;
            dgvSonuc.Size = new Size(1106, 207);
            dgvSonuc.TabIndex = 11;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(lblMesaj);
            pnlBottom.Location = new Point(12, 547);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1106, 32);
            pnlBottom.TabIndex = 12;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.ForeColor = Color.Navy;
            lblMesaj.Location = new Point(3, 0);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(13, 20);
            lblMesaj.TabIndex = 11;
            lblMesaj.Text = " ";
            // 
            // DinamikSorguForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 591);
            Controls.Add(pnlBottom);
            Controls.Add(dgvSonuc);
            Controls.Add(lblUyari);
            Controls.Add(txtSql);
            Controls.Add(pnlTop);
            Name = "DinamikSorguForm";
            Text = "DinamikSorguForm";
            Load += DinamikSorguForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private ComboBox cmbHazirSorgular;
        private Button btnYukle;
        private Label ara;
        private Button btnTemizle;
        private Button btnCalistir;
        private TextBox txtSql;
        private Label lblUyari;
        private DataGridView dgvSonuc;
        private Panel pnlBottom;
        private Label lblMesaj;
    }
}