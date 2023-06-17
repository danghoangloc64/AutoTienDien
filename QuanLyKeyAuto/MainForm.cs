using Common.BLL;
using Common.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private InformationBLL m_objInformationBLL;
        private List<InformationViewModel> m_listInformationViewModels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_objInformationBLL = new InformationBLL();
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
            foreach (GridColumn objCol in gridViewListKey.Columns)
            {
                objCol.AppearanceHeader.BackColor = Color.FromArgb(50, 196, 255);
                objCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                objCol.AppearanceHeader.Font = new Font("Tahoma", 9, FontStyle.Bold);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemMoiForm themMoiForm = new ThemMoiForm();
            themMoiForm.EventThemMoiThanhCong += nhanEventThemMoiThanhCong;
            themMoiForm.ShowDialog();
        }

        private void nhanEventThemMoiThanhCong(object sender, EventArgs e)
        {
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetCurrentSerialNumber()))
            {
                return;
            }
            m_objInformationBLL.XoaSerialNumber(GetCurrentSerialNumber());
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
        }
        private string GetCurrentSerialNumber()
        {
            try
            {
                int arrSelectedRows = gridViewListKey.GetSelectedRows()[0];
                return gridViewListKey.GetRowCellValue(arrSelectedRows, "SerialNumber").ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetCurrentSerialNumber()))
            {
                return;
            }
            m_objInformationBLL.KhoaSerialNumber(GetCurrentSerialNumber());
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetCurrentSerialNumber()))
            {
                return;
            }
            m_objInformationBLL.MoKhoaSerialNumber(GetCurrentSerialNumber());
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_listInformationViewModels = m_objInformationBLL.GetListInformationViewModels();
            gridControlListKey.DataSource = m_listInformationViewModels;
        }
    }
}