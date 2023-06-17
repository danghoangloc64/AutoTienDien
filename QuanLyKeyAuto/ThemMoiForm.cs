using Common.BLL;
using Common.Methods;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKeyAuto
{
    public partial class ThemMoiForm : DevExpress.XtraEditors.XtraForm
    {
        private InformationBLL m_objInformationBLL;
        public ThemMoiForm()
        {
            InitializeComponent();
        }

        public EventHandler EventThemMoiThanhCong;

        private void txtSerialNumber_TextChanged(object sender, EventArgs e)
        {
            txtKey.Text = CommonMethod.SHA2565Hash(CommonMethod.MD5Hash(txtSerialNumber.Text.Trim()));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerialNumber.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenGoiNho.Text))
            {
                return;
            }
            bool resultAdd = m_objInformationBLL.ThemMoiKey(txtTenGoiNho.Text, txtSerialNumber.Text, txtKey.Text);
            if (resultAdd)
            {
                MessageBox.Show(this, "Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EventThemMoiThanhCong.Invoke(null, null);
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Mã do khách hàng cung cấp đã tồn tại.\r\nVui lòng xóa trước khi thêm mới hoặc kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemMoiForm_Load(object sender, EventArgs e)
        {
            m_objInformationBLL = new InformationBLL();
        }
    }
}