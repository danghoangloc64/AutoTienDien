﻿
namespace AutoTienDienBank
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
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPin1 = new System.Windows.Forms.TextBox();
            this.txtMaPin2 = new System.Windows.Forms.TextBox();
            this.txtMaPin3 = new System.Windows.Forms.TextBox();
            this.txtMaPin4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonVIB = new System.Windows.Forms.RadioButton();
            this.radioButtonVPB = new System.Windows.Forms.RadioButton();
            this.btnChay = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(454, 11);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(83, 23);
            this.btnSelectExcel.TabIndex = 16;
            this.btnSelectExcel.Text = "Chọn";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(197, 12);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.ReadOnly = true;
            this.txtExcel.Size = new System.Drawing.Size(251, 20);
            this.txtExcel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "File excel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã PIN:";
            // 
            // txtMaPin1
            // 
            this.txtMaPin1.Location = new System.Drawing.Point(197, 39);
            this.txtMaPin1.Name = "txtMaPin1";
            this.txtMaPin1.Size = new System.Drawing.Size(46, 20);
            this.txtMaPin1.TabIndex = 27;
            this.txtMaPin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaPin2
            // 
            this.txtMaPin2.Location = new System.Drawing.Point(249, 39);
            this.txtMaPin2.Name = "txtMaPin2";
            this.txtMaPin2.Size = new System.Drawing.Size(46, 20);
            this.txtMaPin2.TabIndex = 27;
            this.txtMaPin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaPin3
            // 
            this.txtMaPin3.Location = new System.Drawing.Point(301, 39);
            this.txtMaPin3.Name = "txtMaPin3";
            this.txtMaPin3.Size = new System.Drawing.Size(46, 20);
            this.txtMaPin3.TabIndex = 27;
            this.txtMaPin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaPin4
            // 
            this.txtMaPin4.Location = new System.Drawing.Point(353, 39);
            this.txtMaPin4.Name = "txtMaPin4";
            this.txtMaPin4.Size = new System.Drawing.Size(46, 20);
            this.txtMaPin4.TabIndex = 27;
            this.txtMaPin4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thời gian nghỉ giữa các khách hàng:";
            // 
            // txtSleep
            // 
            this.txtSleep.Location = new System.Drawing.Point(197, 65);
            this.txtSleep.Name = "txtSleep";
            this.txtSleep.Size = new System.Drawing.Size(98, 20);
            this.txtSleep.TabIndex = 28;
            this.txtSleep.Text = "70";
            this.txtSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "(giây)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Chọn app bank:";
            // 
            // radioButtonVIB
            // 
            this.radioButtonVIB.AutoSize = true;
            this.radioButtonVIB.Checked = true;
            this.radioButtonVIB.Location = new System.Drawing.Point(197, 91);
            this.radioButtonVIB.Name = "radioButtonVIB";
            this.radioButtonVIB.Size = new System.Drawing.Size(42, 17);
            this.radioButtonVIB.TabIndex = 30;
            this.radioButtonVIB.TabStop = true;
            this.radioButtonVIB.Text = "VIB";
            this.radioButtonVIB.UseVisualStyleBackColor = true;
            // 
            // radioButtonVPB
            // 
            this.radioButtonVPB.AutoSize = true;
            this.radioButtonVPB.Location = new System.Drawing.Point(245, 91);
            this.radioButtonVPB.Name = "radioButtonVPB";
            this.radioButtonVPB.Size = new System.Drawing.Size(46, 17);
            this.radioButtonVPB.TabIndex = 30;
            this.radioButtonVPB.Text = "VPB";
            this.radioButtonVPB.UseVisualStyleBackColor = true;
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(12, 114);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(525, 23);
            this.btnChay.TabIndex = 31;
            this.btnChay.Text = "Chạy";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(12, 143);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(525, 23);
            this.btnDung.TabIndex = 31;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 175);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.radioButtonVPB);
            this.Controls.Add(this.radioButtonVIB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSleep);
            this.Controls.Add(this.txtMaPin4);
            this.Controls.Add(this.txtMaPin3);
            this.Controls.Add(this.txtMaPin2);
            this.Controls.Add(this.txtMaPin1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Tien Dien Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPin1;
        private System.Windows.Forms.TextBox txtMaPin2;
        private System.Windows.Forms.TextBox txtMaPin3;
        private System.Windows.Forms.TextBox txtMaPin4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonVIB;
        private System.Windows.Forms.RadioButton radioButtonVPB;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnDung;
    }
}
