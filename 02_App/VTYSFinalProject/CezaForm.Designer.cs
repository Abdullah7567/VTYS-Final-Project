namespace VTYSFinalProject
{
    partial class CezaForm
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
            chkSon30Gun = new CheckBox();
            btnYenile = new Button();
            btnAra = new Button();
            label1 = new Label();
            txtUyeAra = new TextBox();
            ara = new Label();
            dgvCezalar = new DataGridView();
            pnlBottom = new Panel();
            txtSeciliUyeId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblToplamBorc = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCezalar).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(chkSon30Gun);
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(txtUyeAra);
            pnlTop.Controls.Add(ara);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 11, 10, 11);
            pnlTop.Size = new Size(1126, 123);
            pnlTop.TabIndex = 12;
            // 
            // chkSon30Gun
            // 
            chkSon30Gun.AutoSize = true;
            chkSon30Gun.Checked = true;
            chkSon30Gun.CheckState = CheckState.Checked;
            chkSon30Gun.Location = new Point(173, 78);
            chkSon30Gun.Name = "chkSon30Gun";
            chkSon30Gun.Size = new Size(18, 17);
            chkSon30Gun.TabIndex = 4;
            chkSon30Gun.UseVisualStyleBackColor = true;
            chkSon30Gun.CheckedChanged += chkSon30Gun_CheckedChanged;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10F);
            btnYenile.Location = new Point(379, 67);
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
            btnAra.Location = new Point(263, 67);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 35);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 73);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 0;
            label1.Text = "Sadece son 30 gün";
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
            ara.Location = new Point(13, 24);
            ara.Name = "ara";
            ara.Size = new Size(137, 32);
            ara.TabIndex = 0;
            ara.Text = "Üye Ara -> ";
            // 
            // dgvCezalar
            // 
            dgvCezalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCezalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCezalar.Location = new Point(12, 141);
            dgvCezalar.MultiSelect = false;
            dgvCezalar.Name = "dgvCezalar";
            dgvCezalar.ReadOnly = true;
            dgvCezalar.RowHeadersWidth = 51;
            dgvCezalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCezalar.Size = new Size(1126, 292);
            dgvCezalar.TabIndex = 14;
            dgvCezalar.SelectionChanged += dgvCezalar_SelectionChanged;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(txtSeciliUyeId);
            pnlBottom.Controls.Add(lblToplamBorc);
            pnlBottom.Controls.Add(label2);
            pnlBottom.Controls.Add(label3);
            pnlBottom.Location = new Point(12, 439);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(10, 11, 10, 11);
            pnlBottom.Size = new Size(1126, 133);
            pnlBottom.TabIndex = 15;
            // 
            // txtSeciliUyeId
            // 
            txtSeciliUyeId.Font = new Font("Segoe UI", 13F);
            txtSeciliUyeId.Location = new Point(199, 19);
            txtSeciliUyeId.Name = "txtSeciliUyeId";
            txtSeciliUyeId.ReadOnly = true;
            txtSeciliUyeId.Size = new Size(238, 36);
            txtSeciliUyeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(180, 32);
            label3.TabIndex = 0;
            label3.Text = "Seçili ÜyeID -> ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 0;
            label2.Text = "Toplam Borç -> ";
            // 
            // lblToplamBorc
            // 
            lblToplamBorc.AutoSize = true;
            lblToplamBorc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblToplamBorc.Location = new Point(199, 70);
            lblToplamBorc.Name = "lblToplamBorc";
            lblToplamBorc.Size = new Size(28, 32);
            lblToplamBorc.TabIndex = 0;
            lblToplamBorc.Text = "0";
            // 
            // CezaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 584);
            Controls.Add(pnlBottom);
            Controls.Add(dgvCezalar);
            Controls.Add(pnlTop);
            Name = "CezaForm";
            Text = "CezaForm";
            Load += CezaForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCezalar).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private CheckBox chkSon30Gun;
        private Button btnYenile;
        private Button btnAra;
        private Label label1;
        private TextBox txtUyeAra;
        private Label ara;
        private DataGridView dgvCezalar;
        private Panel pnlBottom;
        private TextBox txtSeciliUyeId;
        private Label label3;
        private Label lblToplamBorc;
        private Label label2;
    }
}