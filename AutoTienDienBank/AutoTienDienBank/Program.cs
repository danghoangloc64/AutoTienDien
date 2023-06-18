using Common.BLL;
using Common.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTienDienBank
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
            string serialNumber = CommonMethod.GetSerialNumber("AutoTienDienBank");
            if ((new InformationBLL()).CheckSerialNumber(serialNumber, "AutoTienDienBank") == false)
            {
                Application.Run(new DangKyAutoTienDienBank(serialNumber));
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
