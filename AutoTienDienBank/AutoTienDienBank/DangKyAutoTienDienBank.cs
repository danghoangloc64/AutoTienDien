using Common.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTienDienBank
{
    public partial class DangKyAutoTienDienBank : Form
    {
        private string m_strSerialNumber;
        private InformationBLL m_objInformationBLL = new InformationBLL();
        public DangKyAutoTienDienBank(string serialNumber)
        {
            InitializeComponent();
            m_strSerialNumber = serialNumber;
            txtSerialNumber.Text = m_strSerialNumber;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                return;
            }
            var dangKyAutoTienDienBank = m_objInformationBLL.DangKyAutoTienDienBank(m_strSerialNumber, txtKey.Text);
            if (dangKyAutoTienDienBank)
            {
                MessageBox.Show(this, "ĐĂNG KÝ AUTO TIỀN ĐIỆN BANK THÀNH CÔNG.\r\nVUI LÒNG KHỞI ĐỘNG LẠI TOOL.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            else
            {
                MessageBox.Show(this, "ĐĂNG KÝ AUTO TIỀN ĐIỆN BANK THẤT BẠI.\r\nVUI LÒNG LIÊN HỆ NHÀ CUNG CẤP.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DangKyAutoTienDienBank_Load(object sender, EventArgs e)
        {
            m_objInformationBLL = new InformationBLL();
        }
    }
}
