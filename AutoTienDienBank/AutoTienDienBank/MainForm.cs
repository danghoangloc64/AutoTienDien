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
        private int m_iIndexThe;

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

        private void NhapOTPVIB_A51(string soPin)
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

        private void NhapOTPVIB_Note10Lite(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 18.8, 68.7);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 68.2);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 81.2, 68.2);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 18.4, 74.8);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 75.5);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 83.1, 75.3);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 18.8, 81.6);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.8, 81.1);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 83.5, 81.6);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 47.0, 89.5);
            }
        }

        private void NhapOPTVPB_A51(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 27.4, 28.4);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 28.2);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 73.3, 27.9);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 26.3, 37.7);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 51.1, 36.9);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 73.3, 37.9);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 26.3, 46.8);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 51.5, 47.0);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 72.2, 47.0);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.4, 56.7);
            }
        }
        private void NhapOPTVPB_Note20Ultra5G(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)218.4, (int)1485.0);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)524.3, (int)1563.5);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)845.9, (int)1477.2);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)238.0, (int)1712.5);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)508.6, (int)1692.9);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)869.4, (int)1728.2);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)226.3, (int)1865.4);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)540.0, (int)1881.1);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)877.3, (int)1857.6);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)555.7, (int)2085.0);
            }
        }
        private void NhapOPTVPB_Note10Lite(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 19.1, 67.3);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.5, 66.7);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 83.5, 66.2);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 19.9, 74.4);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.4, 74.4);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 79.7, 74.4);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 18.8, 82.1);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.5, 82.1);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 80.5, 82.4);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.0);
            }
        }
        private void NhapOTPVIB_Note20Ultra5G(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)183.1, (int)1571.3);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.1, (int)1551.7);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)896.9, (int)1563.5);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)183.1, (int)1700.7);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.1, (int)1692.9);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)853.7, (int)1692.9);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)198.8, (int)1857.6);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)528.2, (int)1900.7);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)889.0, (int)1865.4);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)551.8, (int)2038.0);
            }
        }
        private void NhapOTPVPB_S215G(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)215.6, (int)1604.7);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)530.3, (int)1533.3);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)877.4, (int)1617.7);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)215.6, (int)1734.5);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.8, (int)1776.7);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)896.9, (int)1753.9);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)218.8, (int)1935.6);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.8, (int)1938.9);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)861.2, (int)1938.9);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)543.2, (int)2127.1);
            }
        }

        private void NhapOTPVIB_S215G(string soPin)
        {
            if (soPin == "1")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)199.3, (int)1627.4);
            }
            if (soPin == "2")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.8, (int)1637.1);
            }
            if (soPin == "3")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)883.9, (int)1624.2);
            }
            if (soPin == "4")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)222.0, (int)1786.4);
            }
            if (soPin == "5")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.5, (int)1802.6);
            }
            if (soPin == "6")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)880.7, (int)1789.6);
            }
            if (soPin == "7")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)238.3, (int)1958.3);
            }
            if (soPin == "8")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)530.3, (int)1945.4);
            }
            if (soPin == "9")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)848.2, (int)1932.4);
            }
            if (soPin == "0")
            {
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)530.3, 1932 + 145);
            }
        }

        private List<ExcelDataModel> GetListExcelDataModels()
        {
            List<ExcelDataModel> result = new List<ExcelDataModel>();
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
                        result.Add(excelDataModel);
                    }
                }
            }
            result.RemoveAll(x => string.IsNullOrWhiteSpace(x.Ma));
            return result;
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
            m_listExcelDataModels = GetListExcelDataModels();
            if (m_listExcelDataModels.Count == 0)
            {
                MessageBox.Show(this, "Không tìm thấy thiết bị.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_bRunning = true;
            m_iIndexThe = int.Parse(cbbThe.Text) - 1;
            await Task.Run(() =>
            {
                if (radioButtonVIB.Checked)
                {
                    if (cbbModel.SelectedIndex == 0)
                    {
                        RunVIB_A51();
                    }
                    else if (cbbModel.SelectedIndex == 1)
                    {
                        RunVIB_Note10Lite();
                    }
                    else if (cbbModel.SelectedIndex == 2)
                    {
                        RunVIB_Note20Ultra5G();
                    }
                    else if (cbbModel.SelectedIndex == 3)
                    {
                        RunVIB_S215G();
                    }
                }
                else if (radioButtonVPB.Checked)
                {
                    if (cbbModel.SelectedIndex == 0)
                    {
                        RunVPB_A51();
                    }
                    else if (cbbModel.SelectedIndex == 1)
                    {
                        RunVPB_Note10Lite();
                    }
                    else if (cbbModel.SelectedIndex == 2)
                    {
                        RunVPB_Note20Ultra5G();
                    }
                    else if (cbbModel.SelectedIndex == 3)
                    {
                        RunVPB_S215G();
                    }
                }
            });
        }

        private void RunVPB_Note20Ultra5G()
        {
            foreach (var data in m_listExcelDataModels)
            {
                // Nhấn điện
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)89.0, (int)716.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn điện lực toàn quốc
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)312.5, (int)888.9);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn nguồn tiền
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)300.8, (int)430.1);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn thẻ tín dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)359.6, (int)1214.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn textbox mã khách hàng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)214.5, (int)908.5);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã khách hàng
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình nhập mã
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)512.5, (int)1238.0);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)540.0, (int)2104.6);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)540.0, (int)2104.6);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhap OTP
                NhapOPTVPB_Note20Ultra5G(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note20Ultra5G(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note20Ultra5G(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note20Ultra5G(txtMaPin4.Text);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.4, (int)2073.3);
                Thread.Sleep(10000);
                if (!m_bRunning) break;
                // Nhấn quay lại trang chu
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)1010.6, (int)147.8);
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn trang chủ
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)77.3, (int)2120.3);
                Thread.Sleep(5000);
                if (!m_bRunning) break;

                int iSleep = 0;
                if (!m_bRunning) break;
                while (iSleep < m_iSleepTime)
                {
                    // Nhấn điện
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)89.0, (int)692.9);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Nhấn trang chủ
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)77.3, (int)2120.3);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 10000;
                }
            }
        }

        private void RunVPB_S215G()
        {
            foreach (var data in m_listExcelDataModels)
            {
                // Nhấn điện
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)140.9, (int)800.1);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                //// Nhấn điện lực toàn quốc
                //KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 36.5, 35.2);
                //if (!m_bRunning) break;
                //Thread.Sleep(2000);
                //if (!m_bRunning) break;
                // Nhấn nhà cung cấp
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)325.9, (int)877.9);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn điện lực toàn quốc
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)286.9, (int)2049.2);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn nguồn tiền
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)303.2, (int)478.9);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn thẻ tín dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)423.2, (int)1290.0);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn textbox mã khách hàng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)254.5, (int)1079.1);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã khách hàng
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Click ra ngoài
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)488.1, (int)1173.2);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình nhập mã
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.5, (int)2162.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.5, (int)2162.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.5, (int)2162.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhap OTP
                NhapOTPVPB_S215G(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVPB_S215G(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVPB_S215G(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVPB_S215G(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)520.5, (int)2162.7);
                if (!m_bRunning) break;
                Thread.Sleep(10000);
                if (!m_bRunning) break;
                // Nhấn quay lại trang chu
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)1000.7, (int)183.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;

                int iSleep = 0;
                while (iSleep < m_iSleepTime)
                {
                    // Nhấn điện
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)166.9, (int)787.1);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Nhấn trang chủ
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)59.8, (int)170.7);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 10000;
                }
            }
        }


        private void RunVPB_A51()
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
                NhapOPTVPB_A51(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB_A51(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB_A51(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOPTVPB_A51(txtMaPin4.Text);
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
        private void RunVPB_Note10Lite()
        {
            foreach (var data in m_listExcelDataModels)
            {
                // Nhấn điện
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 10.5, 30.3);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                //// Nhấn điện lực toàn quốc
                //KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 36.5, 35.2);
                //if (!m_bRunning) break;
                //Thread.Sleep(2000);
                //if (!m_bRunning) break;
                // Nhấn nhà cung cấp
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 41.0, 32.3);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn điện lực toàn quốc
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 25.2, 88.2);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn nguồn tiền
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 34.9, 18.1);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn thẻ tín dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.1, 53.8);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn chọn textbox mã khách hàng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 23.3, 40.2);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã khách hàng
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Click ra ngoài
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.1, 50.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình nhập mã
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 51.5, 91.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhap OTP
                NhapOPTVPB_Note10Lite(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note10Lite(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note10Lite(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOPTVPB_Note10Lite(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Tiep tuc xac nhan
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 48.9, 91.6);
                if (!m_bRunning) break;
                Thread.Sleep(10000);
                if (!m_bRunning) break;
                // Nhấn quay lại trang chu
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 93.3, 6.4);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;

                int iSleep = 0;
                while (iSleep < m_iSleepTime)
                {
                    // Nhấn điện
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 9.4, 29.7);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Nhấn trang chủ
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 4.5, 6.9);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 10000;
                }
            }
        }
        private void RunVIB_A51()
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
                NhapOTPVIB_A51(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB_A51(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB_A51(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(1000);
                if (!m_bRunning) break;
                NhapOTPVIB_A51(txtMaPin4.Text);
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
        private void RunVIB_Note10Lite()
        {
            foreach (var data in m_listExcelDataModels)
            {
                if (!m_bRunning) break;
                // Chọn giao dịch
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 28.6, 91.6);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thanh toán
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 34.9, 33.6);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn điện
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 21.0, 22.5);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn ngoài để ẩn bàn phím
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 46.6, 39.1);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.4);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn từ
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 45.9, 80.5);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thẻ tín dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 40.6, 90.4 - 8 * m_iIndexThe);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình chọn thẻ tính dụng
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.0);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình xác nhận
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 49.2, 90.0);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhập mã pin
                NhapOTPVIB_Note10Lite(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note10Lite(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note10Lite(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note10Lite(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                // Nhấn tiếp tục lúc nhập mã pin xong
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 50.8, 52.8);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn x để quay lại ban đầu
                KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 91.0, 6.7);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;

                int iSleep = 0;

                while (iSleep < m_iSleepTime)
                {
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 10.1, 92.2);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn giao dịch
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 31.6, 92.6);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 10.1, 92.2);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 15000;
                    if (!m_bRunning) break;
                }
            }
        }
        private void RunVIB_Note20Ultra5G()
        {
            foreach (var data in m_listExcelDataModels)
            {
                if (!m_bRunning) break;
                // Chọn giao dịch
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)328.2, (int)2116.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thanh toán
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)300.8, (int)790.9);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn điện
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)316.5, (int)504.6);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn ngoài để ẩn bàn phím
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)492.9, (int)818.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.1, (int)2069.3);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn từ
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)477.3, (int)1888.9);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thẻ tín dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)473.3, 2100 - 200 * m_iIndexThe);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình chọn thẻ tính dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)508.6, (int)2073.3);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình xác nhận
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)508.6, (int)2073.3);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhập mã pin
                NhapOTPVIB_Note20Ultra5G(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note20Ultra5G(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note20Ultra5G(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_Note20Ultra5G(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                // Nhấn tiếp tục lúc nhập mã pin xong
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)536.1, (int)1198.7);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn x để quay lại ban đầu
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)983.1, (int)147.8);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;

                int iSleep = 0;

                while (iSleep < m_iSleepTime)
                {
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)81.2, (int)2128.2);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn giao dịch
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)320.4, (int)2124.2);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)81.2, (int)2128.2);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    iSleep += 15000;
                    if (!m_bRunning) break;
                }
            }
        }

        private void RunVIB_S215G()
        {
            foreach (var data in m_listExcelDataModels)
            {
                if (!m_bRunning) break;
                // Chọn giao dịch
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int) 319.4, (int)2172.5);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thanh toán
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)338.8, (int)903.9);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn điện
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)286.9, (int)598.9);
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhập mã
                KAutoHelper.ADBHelper.InputText(m_strDeviceID, data.Ma);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn ngoài để ẩn bàn phím
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)471.9, (int)910.4);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)514.0, (int)2133.5);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Swipe				
                KAutoHelper.ADBHelper.Swipe(m_strDeviceID, 540, 1620, 540, 500);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn từ
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)475.1, (int)1718.3);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Chọn thẻ tín dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)473.3, 2100 - 200 * m_iIndexThe);
                if (!m_bRunning) break;
                Thread.Sleep(2000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình chọn thẻ tính dụng
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)517.3, (int)2130.3);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhấn tiếp tục màn hình xác nhận
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)517.3, (int)2130.3);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;
                // Nhập mã pin
                NhapOTPVIB_S215G(txtMaPin1.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_S215G(txtMaPin2.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_S215G(txtMaPin3.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                NhapOTPVIB_S215G(txtMaPin4.Text);
                if (!m_bRunning) break;
                Thread.Sleep(300);
                if (!m_bRunning) break;
                // Nhấn tiếp tục lúc nhập mã pin xong
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)533.5, (int)1228.3);
                if (!m_bRunning) break;
                Thread.Sleep(5000);
                if (!m_bRunning) break;
                // Nhấn x để quay lại ban đầu
                KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)974.8, (int)154.4);
                if (!m_bRunning) break;
                Thread.Sleep(3000);
                if (!m_bRunning) break;

                int iSleep = 0;

                while (iSleep < m_iSleepTime)
                {
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)79.3, (int)2185.5);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn giao dịch
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)325.9, (int)2156.3);
                    if (!m_bRunning) break;
                    Thread.Sleep(5000);
                    if (!m_bRunning) break;
                    // Chọn tài khoản
                    KAutoHelper.ADBHelper.Tap(m_strDeviceID, (int)79.3, (int)2185.5);
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
            radioButtonVIB.Checked = Properties.Settings.Default.VIB;
            radioButtonVPB.Checked = Properties.Settings.Default.VPB;
            cbbModel.SelectedIndex = Properties.Settings.Default.ModelDienThoai;
            cbbThe.SelectedIndex = Properties.Settings.Default.HangThe;
        }

        private void radioButtonVIB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VIB = true;
            Properties.Settings.Default.VPB = false;
            Properties.Settings.Default.Save();
        }

        private void radioButtonVPB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VIB = false;
            Properties.Settings.Default.VPB = true;
            Properties.Settings.Default.Save();
        }

        private void cbbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModelDienThoai = cbbModel.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void cbbThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HangThe = cbbThe.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
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
            // Nhấn từ
            KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 45.9, 80.5);
            Thread.Sleep(2000);
            // Chọn thẻ tín dụng

            m_iIndexThe = int.Parse(cbbThe.Text) - 1;
            KAutoHelper.ADBHelper.TapByPercent(m_strDeviceID, 40.6, 90.4 - 8 * m_iIndexThe);
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            KAutoHelper.ADBHelper.Swipe(m_strDeviceID, 540, 1620, 540, 500);
        }
    }
}
