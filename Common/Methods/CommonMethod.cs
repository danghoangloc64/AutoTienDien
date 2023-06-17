using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Methods
{
    public static class CommonMethod
    {
        public static string GetSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                foreach (ManagementObject wmi_HD in searcher.Get())
                {
                    // get the hardware serial no.
                    if (wmi_HD["SerialNumber"] != null)
                    {
                        return SHA2565Hash(MD5Hash(wmi_HD["SerialNumber"].ToString().Trim()));
                    }
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string MD5Hash(string data)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(data));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static string SHA2565Hash(string data)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(data));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
}
