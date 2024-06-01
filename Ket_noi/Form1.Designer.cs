namespace Ket_noi
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
            this.components = new System.ComponentModel.Container();
            this.chkAmthanh = new System.Windows.Forms.CheckBox();
            this.lblDocGT = new System.Windows.Forms.Label();
            this.txtDataReceive = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.lblHienthi = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAmthanh
            // 
            this.chkAmthanh.AutoSize = true;
            this.chkAmthanh.Location = new System.Drawing.Point(561, 12);
            this.chkAmthanh.Name = "chkAmthanh";
            this.chkAmthanh.Size = new System.Drawing.Size(84, 20);
            this.chkAmthanh.TabIndex = 0;
            this.chkAmthanh.Text = "Âm thanh";
            this.chkAmthanh.UseVisualStyleBackColor = true;
            this.chkAmthanh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDocGT
            // 
            this.lblDocGT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDocGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocGT.Location = new System.Drawing.Point(68, 173);
            this.lblDocGT.Name = "lblDocGT";
            this.lblDocGT.Size = new System.Drawing.Size(246, 65);
            this.lblDocGT.TabIndex = 1;
            this.lblDocGT.Text = "Đọc giá trị cảm biến";
            this.lblDocGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDocGT.Click += new System.EventHandler(this.lblDocGT_Click);
            // 
            // txtDataReceive
            // 
            this.txtDataReceive.Location = new System.Drawing.Point(304, 12);
            this.txtDataReceive.Name = "txtDataReceive";
            this.txtDataReceive.Size = new System.Drawing.Size(187, 22);
            this.txtDataReceive.TabIndex = 2;
            this.txtDataReceive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(112, 301);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(131, 50);
            this.btnKetNoi.TabIndex = 3;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(413, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 50);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // lblHienthi
            // 
            this.lblHienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHienthi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthi.Location = new System.Drawing.Point(371, 184);
            this.lblHienthi.Name = "lblHienthi";
            this.lblHienthi.Size = new System.Drawing.Size(217, 42);
            this.lblHienthi.TabIndex = 5;
            this.lblHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienthi.Click += new System.EventHandler(this.lblHienthi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(139, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 41);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Ứng dụng demo project Địa đạo Củ Chi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHienthi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtDataReceive);
            this.Controls.Add(this.lblDocGT);
            this.Controls.Add(this.chkAmthanh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAmthanh;
        private System.Windows.Forms.Label lblDocGT;
        private System.Windows.Forms.TextBox txtDataReceive;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnThoat;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Label lblHienthi;
        private System.Windows.Forms.Label lblTitle;
    }
}

