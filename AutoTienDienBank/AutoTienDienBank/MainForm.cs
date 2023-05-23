using Common.BLL;
using Common.Methods;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTienDienBank
{
    public partial class MainForm : Form
    {
        private List<ExcelDataModel> m_listExcelDataModels;
        private string m_strDeviceID;
        private bool m_bRunning;
        private int m_iSleepTime;

        public MainForm()
        {
            InitializeComponent();
        }
        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtExcel.Text = openFileDialog.FileName;
                }
            }
        }

        private void NhapOTPVIB(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 24.0, 73.1);

            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.1, 72.6);

            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 73.7, 72.2);

            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 21.4, 79.0);

            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 47.0, 79.4);

            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 75.2, 79.9);

            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 21.0, 85.1);

            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.5, 84.8);

            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 71.8, 84.9);

            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 46.6, 91.0);

            }
        }

        private void NhapOPTVPB(string so)
        {
            if (so == "1")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 27.4, 28.4);
            }
            if (so == "2")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 28.2);
            }
            if (so == "3")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 73.3, 27.9);
            }
            if (so == "4")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 26.3, 37.7);
            }
            if (so == "5")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 51.1, 36.9);
            }
            if (so == "6")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 73.3, 37.9);
            }
            if (so == "7")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 26.3, 46.8);
            }
            if (so == "8")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 51.5, 47.0);
            }
            if (so == "9")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 72.2, 47.0);
            }
            if (so == "0")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.4, 56.7);
            }
        }

        private async void btnChay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExcel.Text)
                || string.IsNullOrEmpty(txtMaPin1.Text)
                || string.IsNullOrEmpty(txtMaPin2.Text)
                || string.IsNullOrEmpty(txtMaPin3.Text)
                || string.IsNullOrEmpty(txtMaPin4.Text)
                || string.IsNullOrEmpty(txtSleep.Text))
            {
                MessageBox.Show(this, "Vui lòng nhập đầy đủ thông tin.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                m_iSleepTime = int.Parse(txtSleep.Text) * 1000;
            }
            catch
            {
                m_iSleepTime = 0;
            }
            if (m_iSleepTime == 0)
            {
                MessageBox.Show(this, "Vui lòng nhập đầy đủ thông tin.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var listDevice = KAutoHelper.ADBHelper.GetDevices();
                if (listDevice != null && listDevice.Count > 0)
                {
                    m_strDeviceID = listDevice.First();
                }
                else
                {
                    m_strDeviceID = string.Empty;
                }
            }
            catch
            {
                m_strDeviceID = string.Empty;
            }
            if (string.IsNullOrEmpty(m_strDeviceID))
            {
                MessageBox.Show(this, "Không tìm thấy thiết bị.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Check.CheckDevice(m_strDeviceID);

            m_listExcelDataModels = new List<ExcelDataModel>();
            using (FileStream stream = File.Open(txtExcel.Text, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
                    DataSet dataSet = reader.AsDataSet();
                    DataTable dt = dataSet.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ExcelDataModel excelDataModel = new ExcelDataModel()
                        {
                            Ma = dt.Rows[i][0].ToString(),
                            Tien = int.Parse(dt.Rows[i][1].ToString()),
                        };
                        m_listExcelDataModels.Add(excelDataModel);
                    }
                }
            }
            m_listExcelDataModels.RemoveAll(x => string.IsNullOrWhiteSpace(x.Ma));
            if (m_listExcelDataModels.Count == 0)
            {
                MessageBox.Show(this, "Không tìm thấy thiết bị.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_bRunning = true;
            await Task.Run(() =>
            {
                if (radioButtonVIB.Checked)
                {
                    RunVIB();
                }
                else if (radioButtonVPB.Checked)
                {
                    RunVPB();
                }
            });
        }

        private void RunVPB()
        {
            foreach (var data in m_listExcelDataModels)
            {
                // Nhấn điện
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 10.9, 29.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn điện lực toàn quốc
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 33.4, 38.2);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn nguồn tiền
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 45.9, 18.4);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn chọn thẻ tín dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 39.1, 52.9);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn chọn textbox mã khách hàng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 21.8, 38.4);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhập mã khách hàng
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình nhập mã
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 55.8);
                if (!m_bRunning) break;
                Thread.Sleep(8000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                Thread.Sleep(8000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                Thread.Sleep(8000);
                if (!m_bRunning) break;
                // Nhap OTP
                NhapOPTVPB(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB(txtMaPin4.Text);
                Thread.Sleep(8000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                Thread.Sleep(10000);
                if (!m_bRunning) break;
                // Nhấn quay lại trang chu
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 93.3, 7.1);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn trang chủ
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 7.5, 91.0);
                Thread.Sleep(5000);
                if (!m_bRunning) break;

                int iSleep = 0;
                if (!m_bRunning) break;
                while (iSleep < m_iSleepTime)
                {
                    // Nhấn điện
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 10.9, 29.6);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Nhấn trang chủ
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 7.5, 91.0);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 10000;
                }
            }
        }

        private void RunVIB()
        {
            foreach (var data in m_listExcelDataModels)
            {
                if (!m_bRunning) break;
                // Chọn giao dịch
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 29.8, 91.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Chọn thanh toán
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 26.5, 33.5);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Chọn điện
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 28.4, 21.6);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhập mã
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn ngoài để ẩn bàn phím
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.7, 41.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 52.2, 89.5);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn từ
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 45.5, 80.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Chọn thẻ tín dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 45.5, 80.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình chọn thẻ tính dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.2);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình xác nhận
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.2);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhập mã pin
                NhapOTPVIB(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục lúc nhập mã pin xong
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.8, 63.8);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn x để quay lại ban đầu
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 91.0, 6.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;

                int iSleep = 0;

                while (iSleep < m_iSleepTime)
                {
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 9.0, 91.9);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn giao dịch
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 29.8, 91.7);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 9.0, 91.9);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 15000;
                    if (!m_bRunning) break;
                }
            }
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            m_bRunning = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtMa.Text = CommonMethod.GetSerialNumber();
        }
    }
}
