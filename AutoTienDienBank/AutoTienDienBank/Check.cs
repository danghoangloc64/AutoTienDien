using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTienDienBank
{
    public static class Check
    {
        public static void CheckDevice(string device)
        {
            if (device != "R58NC0PXPTZ" && device != "RR8N400N23N" && device != "R3CN70E6VGB" && device != "R5CR20B8NDM" && device != "RF8N309EJWL" && device != "R5CW40EEF6R")
            {
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
        }
    }
}
