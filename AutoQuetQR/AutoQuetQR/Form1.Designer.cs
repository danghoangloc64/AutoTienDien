
namespace AutoQuetQR
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
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.cbbProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaProfile = new System.Windows.Forms.Button();
            this.btnMoProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey2Captcha = new System.Windows.Forms.TextBox();
            this.cbbSoLuongProfile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChay = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNghi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKeyTinsoft = new System.Windows.Forms.TextBox();
            this.checkBoxUseProxy = new System.Windows.Forms.CheckBox();
            this.btnLogInGmail = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbSoLuongTaoProfile = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(175, 48);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(105, 23);
            this.btnNewProfile.TabIndex = 4;
            this.btnNewProfile.Text = "2. Tạo profile mới";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // cbbProfile
            // 
            this.cbbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProfile.FormattingEnabled = true;
            this.cbbProfile.Location = new System.Drawing.Point(106, 77);
            this.cbbProfile.Name = "cbbProfile";
            this.cbbProfile.Size = new System.Drawing.Size(174, 21);
            this.cbbProfile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách Profile:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSoLuongTaoProfile);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnXoaProfile);
            this.groupBox1.Controls.Add(this.btnMoProfile);
            this.groupBox1.Controls.Add(this.btnLogInGmail);
            this.groupBox1.Controls.Add(this.btnNewProfile);
            this.groupBox1.Controls.Add(this.cbbProfile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt Profile";
            // 
            // btnXoaProfile
            // 
            this.btnXoaProfile.Location = new System.Drawing.Point(195, 104);
            this.btnXoaProfile.Name = "btnXoaProfile";
            this.btnXoaProfile.Size = new System.Drawing.Size(85, 21);
            this.btnXoaProfile.TabIndex = 7;
            this.btnXoaProfile.Text = "Xóa profile";
            this.btnXoaProfile.UseVisualStyleBackColor = true;
            this.btnXoaProfile.Click += new System.EventHandler(this.btnXoaProfile_Click);
            // 
            // btnMoProfile
            // 
            this.btnMoProfile.Location = new System.Drawing.Point(6, 104);
            this.btnMoProfile.Name = "btnMoProfile";
            this.btnMoProfile.Size = new System.Drawing.Size(183, 21);
            this.btnMoProfile.TabIndex = 7;
            this.btnMoProfile.Text = "3. Mở profile để đăng nhập vban";
            this.btnMoProfile.UseVisualStyleBackColor = true;
            this.btnMoProfile.Click += new System.EventHandler(this.btnMoProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key 2captcha:";
            // 
            // txtKey2Captcha
            // 
            this.txtKey2Captcha.Location = new System.Drawing.Point(94, 155);
            this.txtKey2Captcha.Name = "txtKey2Captcha";
            this.txtKey2Captcha.Size = new System.Drawing.Size(204, 20);
            this.txtKey2Captcha.TabIndex = 8;
            this.txtKey2Captcha.TextChanged += new System.EventHandler(this.txtKey2Captcha_TextChanged);
            // 
            // cbbSoLuongProfile
            // 
            this.cbbSoLuongProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoLuongProfile.FormattingEnabled = true;
            this.cbbSoLuongProfile.Location = new System.Drawing.Point(177, 235);
            this.cbbSoLuongProfile.Name = "cbbSoLuongProfile";
            this.cbbSoLuongProfile.Size = new System.Drawing.Size(121, 21);
            this.cbbSoLuongProfile.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số lượng profile chạy cùng lúc:";
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(12, 372);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(286, 23);
            this.btnChay.TabIndex = 11;
            this.btnChay.Text = "Chạy";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(12, 401);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(286, 23);
            this.btnDung.TabIndex = 11;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(304, 12);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(484, 412);
            this.richTextBoxLog.TabIndex = 12;
            this.richTextBoxLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(94, 181);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(204, 20);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "File excel:";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(94, 207);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.ReadOnly = true;
            this.txtExcel.Size = new System.Drawing.Size(137, 20);
            this.txtExcel.TabIndex = 8;
            this.txtExcel.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(238, 206);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(60, 23);
            this.btnSelectExcel.TabIndex = 13;
            this.btnSelectExcel.Text = "Chọn";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thời gian nghỉ:";
            // 
            // txtNghi
            // 
            this.txtNghi.Location = new System.Drawing.Point(94, 262);
            this.txtNghi.Name = "txtNghi";
            this.txtNghi.Size = new System.Drawing.Size(166, 20);
            this.txtNghi.TabIndex = 8;
            this.txtNghi.Text = "60";
            this.txtNghi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNghi.TextChanged += new System.EventHandler(this.txtNghi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "giây";
            // 
            // cbbMien
            // 
            this.cbbMien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMien.FormattingEnabled = true;
            this.cbbMien.Items.AddRange(new object[] {
            "Điện lực Hà Nội",
            "Điện lực Hồ Chí Minh",
            "Điện lực miền Bắc",
            "Điện lực miền Trung",
            "Điện lực miền Nam"});
            this.cbbMien.Location = new System.Drawing.Point(94, 288);
            this.cbbMien.Name = "cbbMien";
            this.cbbMien.Size = new System.Drawing.Size(166, 21);
            this.cbbMien.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chọn miền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Key tinsoftproxy:";
            this.label9.Visible = false;
            // 
            // txtKeyTinsoft
            // 
            this.txtKeyTinsoft.Location = new System.Drawing.Point(94, 315);
            this.txtKeyTinsoft.Name = "txtKeyTinsoft";
            this.txtKeyTinsoft.Size = new System.Drawing.Size(204, 20);
            this.txtKeyTinsoft.TabIndex = 8;
            this.txtKeyTinsoft.Visible = false;
            this.txtKeyTinsoft.TextChanged += new System.EventHandler(this.txttinsoftproxy_TextChanged);
            // 
            // checkBoxUseProxy
            // 
            this.checkBoxUseProxy.AutoSize = true;
            this.checkBoxUseProxy.Location = new System.Drawing.Point(94, 315);
            this.checkBoxUseProxy.Name = "checkBoxUseProxy";
            this.checkBoxUseProxy.Size = new System.Drawing.Size(125, 17);
            this.checkBoxUseProxy.TabIndex = 14;
            this.checkBoxUseProxy.Text = "Sử dụng proxy tinsoft";
            this.checkBoxUseProxy.UseVisualStyleBackColor = true;
            this.checkBoxUseProxy.CheckedChanged += new System.EventHandler(this.checkBoxUseProxy_CheckedChanged);
            // 
            // btnLogInGmail
            // 
            this.btnLogInGmail.Location = new System.Drawing.Point(6, 19);
            this.btnLogInGmail.Name = "btnLogInGmail";
            this.btnLogInGmail.Size = new System.Drawing.Size(274, 23);
            this.btnLogInGmail.TabIndex = 4;
            this.btnLogInGmail.Text = "1. Đăng nhập Gmail mới";
            this.btnLogInGmail.UseVisualStyleBackColor = true;
            this.btnLogInGmail.Click += new System.EventHandler(this.btnLogInGmail_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số profile muốn tạo:";
            // 
            // cbbSoLuongTaoProfile
            // 
            this.cbbSoLuongTaoProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoLuongTaoProfile.FormattingEnabled = true;
            this.cbbSoLuongTaoProfile.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbSoLuongTaoProfile.Location = new System.Drawing.Point(106, 49);
            this.cbbSoLuongTaoProfile.Name = "cbbSoLuongTaoProfile";
            this.cbbSoLuongTaoProfile.Size = new System.Drawing.Size(63, 21);
            this.cbbSoLuongTaoProfile.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.checkBoxUseProxy);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMien);
            this.Controls.Add(this.cbbSoLuongProfile);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.txtNghi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtKeyTinsoft);
            this.Controls.Add(this.txtKey2Captcha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Tien Dien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.ComboBox cbbProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoProfile;
        private System.Windows.Forms.Button btnXoaProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey2Captcha;
        private System.Windows.Forms.ComboBox cbbSoLuongProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNghi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKeyTinsoft;
        private System.Windows.Forms.CheckBox checkBoxUseProxy;
        private System.Windows.Forms.Button btnLogInGmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbSoLuongTaoProfile;
    }
}

