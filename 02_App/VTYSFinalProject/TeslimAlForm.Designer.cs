namespace VTYSFinalProject
{
    partial class TeslimAlForm
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
            chkTeslimEdilmemis = new CheckBox();
            btnYenile = new Button();
            btnUyeAra = new Button();
            label1 = new Label();
            txtUyeAra = new TextBox();
            ara = new Label();
            dgvOduncler = new DataGridView();
            pnlBottom = new Panel();
            btnTeslimAl = new Button();
            txtOduncId = new TextBox();
            label3 = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOduncler).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(chkTeslimEdilmemis);
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnUyeAra);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(txtUyeAra);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 11, 10, 11);
            pnlTop.Size = new Size(1117, 123);
            pnlTop.TabIndex = 11;
            // 
            // chkTeslimEdilmemis
            // 
            chkTeslimEdilmemis.AutoSize = true;
            chkTeslimEdilmemis.Checked = true;
            chkTeslimEdilmemis.CheckState = CheckState.Checked;
            chkTeslimEdilmemis.Location = new Point(216, 77);
            chkTeslimEdilmemis.Name = "chkTeslimEdilmemis";
            chkTeslimEdilmemis.Size = new Size(18, 17);
            chkTeslimEdilmemis.TabIndex = 4;
            chkTeslimEdilmemis.UseVisualStyleBackColor = true;
            chkTeslimEdilmemis.CheckedChanged += chkTeslimEdilmemis_CheckedChanged;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10F);
            btnYenile.Location = new Point(549, 44);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(94, 35);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnUyeAra
            // 
            btnUyeAra.Font = new Font("Segoe UI", 10F);
            btnUyeAra.Location = new Point(433, 44);
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
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 72);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 0;
            label1.Text = "Sadece Teslim Edilmemiş";
            // 
            // txtUyeAra
            // 
            txtUyeAra.Font = new Font("Segoe UI", 13F);
            txtUyeAra.Location = new Point(156, 22);
            txtUyeAra.Name = "txtUyeAra";
            txtUyeAra.PlaceholderText = "(Ad/Soyad/Email)";
            txtUyeAra.Size = new Size(238, 36);
            txtUyeAra.TabIndex = 1;
            // 
            // ara
            // 
            ara.AutoSize = true;
            ara.Font = new Font("Segoe UI", 14F);
            ara.Location = new Point(13, 22);
            ara.Name = "ara";
            ara.Size = new Size(137, 32);
            ara.TabIndex = 0;
            ara.Text = "Üye Ara -> ";
            // 
            // dgvOduncler
            // 
            dgvOduncler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOduncler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOduncler.Location = new Point(12, 141);
            dgvOduncler.MultiSelect = false;
            dgvOduncler.Name = "dgvOduncler";
            dgvOduncler.ReadOnly = true;
            dgvOduncler.RowHeadersWidth = 51;
            dgvOduncler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOduncler.Size = new Size(1117, 292);
            dgvOduncler.TabIndex = 13;
            dgvOduncler.SelectionChanged += dgvOduncler_SelectionChanged;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnTeslimAl);
            pnlBottom.Controls.Add(txtOduncId);
            pnlBottom.Controls.Add(label3);
            pnlBottom.Location = new Point(12, 439);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(10, 11, 10, 11);
            pnlBottom.Size = new Size(1117, 150);
            pnlBottom.TabIndex = 14;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Font = new Font("Segoe UI", 10F);
            btnTeslimAl.Location = new Point(519, 32);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(94, 35);
            btnTeslimAl.TabIndex = 3;
            btnTeslimAl.Text = "Teslim Al";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // txtOduncId
            // 
            txtOduncId.Font = new Font("Segoe UI", 13F);
            txtOduncId.Location = new Point(225, 31);
            txtOduncId.Name = "txtOduncId";
            txtOduncId.ReadOnly = true;
            txtOduncId.Size = new Size(238, 36);
            txtOduncId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(23, 33);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 0;
            label3.Text = "Seçili OduncID -> ";
            // 
            // TeslimAlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 601);
            Controls.Add(pnlBottom);
            Controls.Add(dgvOduncler);
            Controls.Add(pnlTop);
            Name = "TeslimAlForm";
            Text = "TeslimAlForm";
            Load += TeslimAlForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOduncler).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnYenile;
        private Button btnUyeAra;
        private Label label1;
        private TextBox txtUyeAra;
        private Label ara;
        private CheckBox chkTeslimEdilmemis;
        private DataGridView dgvOduncler;
        private Panel pnlBottom;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtOduncId;
        private Label label3;
        private Button btnTeslimAl;
    }
}