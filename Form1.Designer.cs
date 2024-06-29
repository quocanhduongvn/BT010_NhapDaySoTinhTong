namespace BT010_NapDaySoTinhTong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDaySo = new System.Windows.Forms.TextBox();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.tbTongChan = new System.Windows.Forms.TextBox();
            this.tbTongLe = new System.Windows.Forms.TextBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số Và Tính Tổng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy Số Bạn Vừa Nhập Là:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Chẵn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Lẻ:";
            // 
            // tbDaySo
            // 
            this.tbDaySo.Location = new System.Drawing.Point(37, 96);
            this.tbDaySo.Name = "tbDaySo";
            this.tbDaySo.Size = new System.Drawing.Size(177, 20);
            this.tbDaySo.TabIndex = 5;
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(228, 95);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(52, 20);
            this.tbTong.TabIndex = 6;
            // 
            // tbTongChan
            // 
            this.tbTongChan.Location = new System.Drawing.Point(110, 135);
            this.tbTongChan.Name = "tbTongChan";
            this.tbTongChan.Size = new System.Drawing.Size(52, 20);
            this.tbTongChan.TabIndex = 7;
            // 
            // tbTongLe
            // 
            this.tbTongLe.Location = new System.Drawing.Point(229, 135);
            this.tbTongLe.Name = "tbTongLe";
            this.tbTongLe.Size = new System.Drawing.Size(52, 20);
            this.tbTongLe.TabIndex = 8;
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.AutoEllipsis = true;
            this.btnNhapSo.BackColor = System.Drawing.Color.Cyan;
            this.btnNhapSo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNhapSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSo.Location = new System.Drawing.Point(37, 168);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(142, 23);
            this.btnNhapSo.TabIndex = 9;
            this.btnNhapSo.Text = "Nhập Số Và Tính Tổng";
            this.btnNhapSo.UseVisualStyleBackColor = false;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoEllipsis = true;
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(185, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoEllipsis = true;
            this.btnThoat.BackColor = System.Drawing.Color.Cyan;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(244, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(53, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(37, 211);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(260, 20);
            this.tbInput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 243);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.tbTongLe);
            this.Controls.Add(this.tbTongChan);
            this.Controls.Add(this.tbTong);
            this.Controls.Add(this.tbDaySo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhạp Dãy Số Tính Tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDaySo;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.TextBox tbTongChan;
        private System.Windows.Forms.TextBox tbTongLe;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbInput;
    }
}

