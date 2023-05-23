using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class InformationModel : AuditableEntity<int>
    {
        public string TenKey { get; set; }
        public string SerialNumber { get; set; }
        public string Key { get; set; }
        public bool DangSuDung { get; set; }
        public bool DaKichHoat { get; set; }
    }
}
