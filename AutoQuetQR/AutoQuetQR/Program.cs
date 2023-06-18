using Common.BLL;
using Common.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoQuetQR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string serialNumber = CommonMethod.GetSerialNumber("AutoQuetQR");
            if ((new InformationBLL()).CheckSerialNumber(serialNumber, "AutoQuetQR") == false)
            {
                Application.Run(new DangKyAutoQuetQR(serialNumber));
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
