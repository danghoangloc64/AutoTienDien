using _2CaptchaAPI;
using ExcelDataReader;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _2CaptchaAPI._2Captcha;
using static OpenQA.Selenium.PrintOptions;

namespace AutoQuetQR
{
    public partial class Form1 : Form
    {
        private List<ExcelDataModel> m_listExcelDataModels;

        _2Captcha captcha;
        _2Captcha.Result balance;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            balance = await captcha.GetBalance();
        }
        private void CloseAllChromeDriver()
        {
            try
            {
                Process[] arrayProcesses = Process.GetProcessesByName("chromedriver");
                if (arrayProcesses != null && arrayProcesses.Length > 0)
                {
                    foreach (var process in arrayProcesses)
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {

            }
        }

        private void CloseAllChrome()
        {
            try
            {
                Process[] arrayProcesses = Process.GetProcessesByName("chrome");
                if (arrayProcesses != null && arrayProcesses.Length > 0)
                {
                    foreach (var process in arrayProcesses)
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {

            }
        }

        private void LoadProfile()
        {
            cbbProfile.Items.Clear();
            cbbSoLuongProfile.Items.Clear();
            int count = 1;
            for (int i = 1; i < 100; i++)
            {
                string folderProfile = "profile" + i;
                if (Directory.Exists(folderProfile))
                {
                    cbbProfile.Items.Add(folderProfile);
                    cbbProfile.SelectedIndex = 0;
                    cbbSoLuongProfile.Items.Add((count++).ToString());
                    cbbSoLuongProfile.SelectedIndex = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check.CheckTime();
            LoadProfile();
            txtKey2Captcha.Text = Properties.Settings.Default.Key2Captcha;
            txtSDT.Text = Properties.Settings.Default.SDT;
            txtExcel.Text = Properties.Settings.Default.ExcelFile;
            txtNghi.Text = Properties.Settings.Default.Nghi;
            txtKeyTinsoft.Text = Properties.Settings.Default.Keytinsoftproxy;
            checkBoxUseProxy.Checked = Properties.Settings.Default.UserProxy;
            cbbSoLuongTaoProfile.SelectedIndex = 0;
            cbbMien.SelectedIndex = 3;
            //balance = await captcha.GetBalance();
        }
        private void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            int iSoLuong = int.Parse(cbbSoLuongTaoProfile.Text);
            for (int i = 0; i < iSoLuong; i++)
            {
                int soProfile = 1;
                if (File.Exists("profile") == false)
                {
                    File.WriteAllText("profile", "1");
                }
                else
                {
                    soProfile = int.Parse(File.ReadAllText("profile"));
                    soProfile++;
                    File.WriteAllText("profile", soProfile.ToString());
                }
                CopyFilesRecursively(@"GoogleChromePortable\Data\profile", $"profile{soProfile}");
            }
            LoadProfile();
            MessageBox.Show(this, $"Đã tạo xong {iSoLuong} profile.\r\nCác profile vừa tạo đã được đăng nhập gmail ở bước 1.\r\nVui lòng mở từng profile ở bước 3 để chọn đăng nhập vban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKey2Captcha_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Key2Captcha = txtKey2Captcha.Text;
            Properties.Settings.Default.Save();
        }

        private void btnXoaProfile_Click(object sender, EventArgs e)
        {
            CloseAllChrome();
            CloseAllChromeDriver();
            try
            {
                Directory.Delete(cbbProfile.Text, true);
                LoadProfile();
            }
            catch (Exception ex)
            {
                LoadProfile();
                MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoProfile_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllChrome();
                CloseAllChromeDriver();
                ChromeOptions options = new ChromeOptions();
                options.BinaryLocation = Environment.CurrentDirectory + "\\GoogleChromePortable\\App\\Chrome-bin\\chrome.exe";
                options.AddArgument(@"user-data-dir=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cbbProfile.Text));
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                options.AddArgument("--start-maximized");
                service.HideCommandPromptWindow = true;
                var driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl("https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");
                MessageBox.Show(this, "Vui lòng đăng nhập vban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<string> m_listKeyProxy;

        private void btnChay_Click(object sender, EventArgs e)
        {
            CloseAllChrome();
            CloseAllChromeDriver();
            Check.CheckTime();

            if (File.Exists("qr.png"))
            {
                File.Delete("qr");
            }

            captcha = new _2Captcha(txtKey2Captcha.Text);

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

            int thoiGianNghi = int.Parse(txtNghi.Text) * 1000;
            string sdt = txtSDT.Text;
            string mien = cbbMien.Text;
            int soLuong = int.Parse(cbbSoLuongProfile.Text);
            if (soLuong <= 0)
            {
                soLuong = 1;
            }

            int soItemMoiLuong = Convert.ToInt32(Math.Ceiling(m_listExcelDataModels.Count / Convert.ToDouble(soLuong)));
            if (soItemMoiLuong <= 0)
            {
                soItemMoiLuong = 1;
            }
            richTextBoxLog.Clear();
            m_listKeyProxy = new List<string>();
            if (checkBoxUseProxy.Checked)
            {
                if (File.Exists("ProxyKey.txt") == false)
                {
                    MessageBox.Show(this, "Không tìm thấy file ProxyKey.txt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    m_listKeyProxy = File.ReadAllLines("ProxyKey.txt").ToList();
                }

                if (m_listKeyProxy.Count < soLuong)
                {
                    MessageBox.Show(this, $"Proxy không đủ để chạy {soLuong} luồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < soLuong; i++)
            {
                Check.CheckTime();
                m_bIsRunning = true;
                var queryResultPage = m_listExcelDataModels.Skip(soItemMoiLuong * i).Take(soItemMoiLuong).ToList();
                string profile = cbbProfile.Items[i].ToString();
                Run(queryResultPage, thoiGianNghi, sdt, profile, i, mien);
            }

        }

        private object lockobject = new object();

        private void Run(List<ExcelDataModel> excelDataModels, int sleep, string sdt, string profile, int stt, string mien)
        {
            new Thread(async () =>
            {
                Thread.CurrentThread.IsBackground = true;
                int countCheck = 0;
                try
                {
                    string strProxy = "";
                    if (m_listKeyProxy.Count > 0)
                    {
                        TinsoftProxy myProxy;
                        myProxy = new TinsoftProxy("");
                        myProxy.api_key = m_listKeyProxy[stt];
                        myProxy.location = 0;


                        while (true)
                        {
                            if (myProxy.changeProxy())
                            {
                                strProxy = myProxy.proxy;
                                break;

                            }
                            else
                            {
                                string errorCode = myProxy.errorCode;
                                AddLog($"Key {m_listKeyProxy[stt]} lỗi tạo proxy, đang chờ lấy proxy mới. Có thể do key hết hạn hoặc gọi api quá nhanh, vui lòng đợi hoặc check lại.");
                            }
                            Thread.Sleep(10000);
                        }
                    }

                    ChromeOptions options = new ChromeOptions();

                    options.AddArgument(@"user-data-dir=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, profile));
                    options.AddArgument("--app=https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");
                    options.BinaryLocation = Environment.CurrentDirectory + "\\GoogleChromePortable\\App\\Chrome-bin\\chrome.exe";
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();

                    if (string.IsNullOrEmpty(strProxy) == false)
                    {
                        var proxy = new Proxy();
                        proxy.Kind = ProxyKind.Manual;
                        proxy.IsAutoDetect = false;
                        proxy.HttpProxy =
                        proxy.SslProxy = strProxy;
                        options.Proxy = proxy;
                        options.AddArgument("ignore-certificate-errors");
                    }


                    service.HideCommandPromptWindow = true;
                    ChromeDriver driver = new ChromeDriver(service, options);
                    driver.Manage().Window.Size = new Size(300, 800);
                    driver.Manage().Window.Position = new Point(stt * 290, 0);




                    foreach (var data in excelDataModels)
                    {
                        Check.CheckTime();
                        try
                        {
                            if (countCheck > 3)
                            {
                                driver.Close();
                                driver.Quit();
                                strProxy = "";
                                if (m_listKeyProxy.Count > 0)
                                {
                                    TinsoftProxy myProxy;
                                    myProxy = new TinsoftProxy("");
                                    myProxy.api_key = m_listKeyProxy[stt];
                                    myProxy.location = 0;


                                    while (true)
                                    {
                                        if (myProxy.changeProxy())
                                        {
                                            strProxy = myProxy.proxy;
                                            break;

                                        }
                                        else
                                        {
                                            string errorCode = myProxy.errorCode;
                                            AddLog($"Key {m_listKeyProxy[stt]} lỗi tạo proxy, đang chờ lấy proxy mới. Có thể do key hết hạn hoặc gọi api quá nhanh, vui lòng đợi hoặc check lại.");
                                        }
                                        Thread.Sleep(10000);
                                    }
                                }

                                options = new ChromeOptions();
                                options.AddArgument(@"user-data-dir=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, profile));
                                options.AddArgument("--app=https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");
                                options.BinaryLocation = Environment.CurrentDirectory + "\\GoogleChromePortable\\App\\Chrome-bin\\chrome.exe";
                                service = ChromeDriverService.CreateDefaultService();

                                if (string.IsNullOrEmpty(strProxy) == false)
                                {
                                    var proxy = new Proxy();
                                    proxy.Kind = ProxyKind.Manual;
                                    proxy.IsAutoDetect = false;
                                    proxy.HttpProxy =
                                    proxy.SslProxy = strProxy;
                                    options.Proxy = proxy;
                                    options.AddArgument("ignore-certificate-errors");
                                }


                                service.HideCommandPromptWindow = true;
                                driver = new ChromeDriver(service, options);
                                driver.Manage().Window.Size = new Size(300, 800);
                                driver.Manage().Window.Position = new Point(stt * 290, 0);
                            }

                            IJavaScriptExecutor executorUseData = driver;
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            driver.Navigate().GoToUrl("https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");


                            var txtMien = driver.FindElement(By.XPath("//select[@id='selectprovider']"));
                            var selectElement = new SelectElement(txtMien);
                            selectElement.SelectByText(mien);

                            var dataSite = driver.FindElement(By.XPath("//div[@class='g-recaptcha ng-pristine ng-untouched ng-valid']")).GetAttribute("data-sitekey");

                            AddLog($"Mã {data.Ma} đang giải capcha.");
                            var reCaptchaV3 = await captcha.SolveReCaptchaV2(dataSite, "https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            var txtMa = driver.FindElement(By.XPath("//input[@id='billcode']"));
                            txtMa.Clear();
                            txtMa.SendKeys(data.Ma);
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            var txtSDT = driver.FindElement(By.XPath("//input[@id='cusphone']"));
                            txtSDT.Clear();
                            txtSDT.SendKeys(sdt);
                            if (m_bIsRunning == false)
                            {
                                return;
                            }

                            var txtKeyRecaptcha = driver.FindElement(By.XPath("//textarea[@id='g-recaptcha-response']"));
                            executorUseData.ExecuteScript("arguments[0].setAttribute('style','type: text; visibility:visible;');", txtKeyRecaptcha);
                            txtKeyRecaptcha.SendKeys(reCaptchaV3.Response);

                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            var btnNext = driver.FindElement(By.XPath("//button[@ng-click='nextToPay()']"));
                            executorUseData.ExecuteScript("arguments[0].click()", btnNext);
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            Thread.Sleep(5000);



                            if (driver.PageSource.ToLower().Contains("không nợ cước"))
                            {
                                AddLog($"Mã {data.Ma} không nợ cước.");
                                continue;
                            }

                            if (driver.PageSource.ToLower().Contains("không tồn tại"))
                            {
                                AddLog($"Mã {data.Ma} không tồn tại hoặc chưa được hỗ trợ.");
                                continue;
                            }
                            //var checkTien = int.Parse(driver.FindElement(By.XPath("//span[@class='lightred ng-binding']")).Text.Replace(".", "").Replace("VND", "").Trim());
                            //if (checkTien != data.Tien)
                            //{
                            //    AddLog($"Mã {data.Ma} có tiền không khớp.");
                            //    continue;
                            //}
                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            var btnVN = driver.FindElement(By.XPath("//button[@ng-click='ChoosenVnpayQrTab()']"));
                            executorUseData.ExecuteScript("arguments[0].click()", btnVN);

                            Thread.Sleep(5000);

                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            var js = String.Format("window.scrollTo({0}, {1})", 0, 200);
                            executorUseData.ExecuteScript(js);

                            if (m_bIsRunning == false)
                            {
                                return;
                            }
                            //var element = driver.FindElement(By.XPath("//div[@class='qr qr-size-default']"));
                            //Actions actions = new Actions(driver);
                            //actions.MoveToElement(element);
                            //actions.Perform();
                            Thread.Sleep(2000);


                            lock (lockobject)
                            {
                                if (!m_bIsRunTay)
                                {
                                    Random rnd = new Random();
                                    while (File.Exists("qr.png"))
                                    {
                                        if (m_bIsRunning == false)
                                        {
                                            return;
                                        }
                                        Thread.Sleep(rnd.Next(2000, 5000));
                                    }
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }


                                    ss.SaveAsFile("qr.png", ScreenshotImageFormat.Png);

                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    Thread.Sleep(2000);
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    CopyAndRefreshADB();
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    AddLog($"Mã {data.Ma} đang quét QR.");
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    RunAutoPhone();
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                }
                                string url = driver.Url;

                                while (true)
                                {
                                    if (m_bIsRunning == false)
                                    {
                                        return;
                                    }
                                    Thread.Sleep(1000);
                                    if (driver.PageSource.ToLower().Contains("giao dịch thành công"))
                                    {
                                        File.Delete("qr.png");
                                        driver.Navigate().GoToUrl("https://www.vban.vn/dich-vu/thanh-toan-hoa-don-tien-dien.aspx");
                                        break;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            countCheck++;
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }).Start();
        }

        private void RunAutoPhone()
        {
            if (m_bIsRunning == false)
            {
                return;
            }
            string deviceID = string.Empty;
            var listDevice = KAutoHelper.ADBHelper.GetDevices();
            try
            {

                if (listDevice != null && listDevice.Count > 0)
                {
                    deviceID = listDevice.First();
                }
                else
                {
                    deviceID = string.Empty;
                }
            }
            catch
            {
                deviceID = string.Empty;
            }
            if (m_bIsRunning == false)
            {
                return;
            }
            if (string.IsNullOrEmpty(deviceID))
            {
                return;
            }
            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn QR Pay
            KAutoHelper.ADBHelper.Tap(deviceID, (int)820.4, (int)555.4);
            Thread.Sleep(3000);
            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn ảnh từ trong máy
            KAutoHelper.ADBHelper.Tap(deviceID, (int)527.8, (int)2124.1);
            Thread.Sleep(3000);

            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn ảnh mới nhất
            KAutoHelper.ADBHelper.Tap(deviceID, (int)174.3, (int)1055.3);
            //KAutoHelper.ADBHelper.Tap(deviceID, (int)162.1, (int)559.5);
            Thread.Sleep(5000);

            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn tiếp tục
            KAutoHelper.ADBHelper.Tap(deviceID, (int)531.9, (int)2156.6);
            Thread.Sleep(6000);

            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn xác nhận và hoàn tất
            KAutoHelper.ADBHelper.Tap(deviceID, (int)531.9, (int)2156.6);
            Thread.Sleep(10000);

            if (m_bIsRunning == false)
            {
                return;
            }
            // Chọn trang chủ
            KAutoHelper.ADBHelper.Tap(deviceID, (int)889.5, (int)177.5);
            //KAutoHelper.ADBHelper.Tap(deviceID, (int)893.6, (int)185.6);
        }

        private void CopyAndRefreshADB()
        {
            using (Process cmd = new Process())
            {
                cmd.StartInfo.FileName = "adb.exe";
                cmd.StartInfo.Arguments = $"push qr.png /sdcard/Pictures/qr.png";
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.WaitForExit();
            }
            Thread.Sleep(1000);
            using (Process cmd = new Process())
            {
                cmd.StartInfo.FileName = "adb.exe";
                cmd.StartInfo.Arguments = $"shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d file:///sdcard/Pictures";
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.WaitForExit();
            }
        }
        private void Stop()
        {
            if (m_bIsRunning == false)
            {
                return;
            }
        }

        private void AddLog(string log)
        {
            richTextBoxLog.Invoke(new Action(() =>
            {
                richTextBoxLog.AppendText(log + Environment.NewLine);
            }));
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SDT = txtSDT.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtExcel.Text = openFileDialog.FileName;
                    Properties.Settings.Default.ExcelFile = openFileDialog.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void txtNghi_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Nghi = txtNghi.Text;
            Properties.Settings.Default.Save();
        }
        private bool m_bIsRunning = false;
        private void btnDung_Click(object sender, EventArgs e)
        {
            m_bIsRunning = false;
        }

        private void txttinsoftproxy_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Keytinsoftproxy = txtKeyTinsoft.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserProxy = checkBoxUseProxy.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnLogInGmail_Click(object sender, EventArgs e)
        {
            CloseAllChrome();
            CloseAllChromeDriver();

            cbbProfile.Items.Clear();
            cbbSoLuongProfile.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
                string folderProfile = "profile" + i;
                if (Directory.Exists(folderProfile))
                {
                    Directory.Delete(folderProfile, true);
                }
            }
            if (Directory.Exists(@"GoogleChromePortable\Data\profile"))
            {
                Directory.Delete(@"GoogleChromePortable\Data\profile", true);
            }
            if (File.Exists(@"profile"))
            {
                File.Delete(@"profile");
            }

            Process.Start(@"GoogleChromePortable\GoogleChromePortable.exe");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string deviceID = string.Empty;
            var listDevice = KAutoHelper.ADBHelper.GetDevices();
            try
            {

                if (listDevice != null && listDevice.Count > 0)
                {
                    deviceID = listDevice.First();
                }
                else
                {
                    deviceID = string.Empty;
                }
            }
            catch
            {
                deviceID = string.Empty;
            }

            if (string.IsNullOrEmpty(deviceID))
            {
                MessageBox.Show(this, $"Lỗi. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, $"Thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool m_bIsRunTay = false;

        private void btnRunTay_Click(object sender, EventArgs e)
        {
            m_bIsRunTay = true;
            btnChay_Click(null, null);
        }

        private void btnChay_Click_1(object sender, EventArgs e)
        {
            m_bIsRunTay = false;
            btnChay_Click(null, null);
        }
    }
}
