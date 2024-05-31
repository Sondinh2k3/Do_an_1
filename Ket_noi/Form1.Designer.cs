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
            this.SuspendLayout();
            // 
            // chkAmthanh
            // 
            this.chkAmthanh.AutoSize = true;
            this.chkAmthanh.Location = new System.Drawing.Point(631, 15);
            this.chkAmthanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAmthanh.Name = "chkAmthanh";
            this.chkAmthanh.Size = new System.Drawing.Size(104, 24);
            this.chkAmthanh.TabIndex = 0;
            this.chkAmthanh.Text = "Âm thanh";
            this.chkAmthanh.UseVisualStyleBackColor = true;
            this.chkAmthanh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDocGT
            // 
            this.lblDocGT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDocGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocGT.Location = new System.Drawing.Point(97, 124);
            this.lblDocGT.Name = "lblDocGT";
            this.lblDocGT.Size = new System.Drawing.Size(277, 81);
            this.lblDocGT.TabIndex = 1;
            this.lblDocGT.Text = "Đọc giá trị cảm biến";
            this.lblDocGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDocGT.Click += new System.EventHandler(this.lblDocGT_Click);
            // 
            // txtDataReceive
            // 
            this.txtDataReceive.Location = new System.Drawing.Point(342, 15);
            this.txtDataReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataReceive.Name = "txtDataReceive";
            this.txtDataReceive.Size = new System.Drawing.Size(210, 26);
            this.txtDataReceive.TabIndex = 2;
            this.txtDataReceive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(148, 286);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(147, 62);
            this.btnKetNoi.TabIndex = 3;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(460, 286);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 62);
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
            this.lblHienthi.Location = new System.Drawing.Point(419, 141);
            this.lblHienthi.Name = "lblHienthi";
            this.lblHienthi.Size = new System.Drawing.Size(244, 53);
            this.lblHienthi.TabIndex = 5;
            this.lblHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienthi.Click += new System.EventHandler(this.lblHienthi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 562);
            this.Controls.Add(this.lblHienthi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtDataReceive);
            this.Controls.Add(this.lblDocGT);
            this.Controls.Add(this.chkAmthanh);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}

