namespace nhap_so_hien_chu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChu = new System.Windows.Forms.TextBox();
            this.txtchuyen = new System.Windows.Forms.Button();
            this.txtThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so tu 0-9";
            // 
            // txtSo
            // 
            this.txtSo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSo.Location = new System.Drawing.Point(183, 20);
            this.txtSo.Multiline = true;
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(109, 21);
            this.txtSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "So có chữ số là: ";
            // 
            // txtChu
            // 
            this.txtChu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChu.Location = new System.Drawing.Point(183, 125);
            this.txtChu.Multiline = true;
            this.txtChu.Name = "txtChu";
            this.txtChu.Size = new System.Drawing.Size(109, 21);
            this.txtChu.TabIndex = 3;
            // 
            // txtchuyen
            // 
            this.txtchuyen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtchuyen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtchuyen.Location = new System.Drawing.Point(183, 68);
            this.txtchuyen.Name = "txtchuyen";
            this.txtchuyen.Size = new System.Drawing.Size(89, 30);
            this.txtchuyen.TabIndex = 4;
            this.txtchuyen.Text = "Chuyển đổi";
            this.txtchuyen.UseVisualStyleBackColor = false;
            this.txtchuyen.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThoat
            // 
            this.txtThoat.Location = new System.Drawing.Point(183, 172);
            this.txtThoat.Name = "txtThoat";
            this.txtThoat.Size = new System.Drawing.Size(75, 27);
            this.txtThoat.TabIndex = 5;
            this.txtThoat.Text = "Thoát";
            this.txtThoat.UseVisualStyleBackColor = true;
            this.txtThoat.Click += new System.EventHandler(this.txtThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 241);
            this.Controls.Add(this.txtThoat);
            this.Controls.Add(this.txtchuyen);
            this.Controls.Add(this.txtChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChu;
        private System.Windows.Forms.Button txtchuyen;
        private System.Windows.Forms.Button txtThoat;
    }
}

