namespace BT010_NapDaySoTinhTong
{
    partial class FormNhapDaySo
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
            this.tbInputForm = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInputForm
            // 
            this.tbInputForm.Location = new System.Drawing.Point(3, 12);
            this.tbInputForm.Name = "tbInputForm";
            this.tbInputForm.Size = new System.Drawing.Size(260, 20);
            this.tbInputForm.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoEllipsis = true;
            this.btnThoat.BackColor = System.Drawing.Color.Cyan;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(210, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(53, 23);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoEllipsis = true;
            this.btnOK.BackColor = System.Drawing.Color.Cyan;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(141, 48);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NhapDaySo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 71);
            this.Controls.Add(this.tbInputForm);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Name = "NhapDaySo";
            this.Text = "Nhập Dãy Số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputForm;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnOK;
    }
}