using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class InformationViewModel
    {
        [DisplayName("Tên key")]
        public string TenKey { get; set; }

        [DisplayName("Mã do khách hàng gửi")]
        public string SerialNumber { get; set; }

        [DisplayName("Mã gửi cho khách hàng")]
        public string Key { get; set; }

        [DisplayName("Khách hàng đã kích hoạt")]
        public bool DaKichHoat { get; set; }

        [DisplayName("Trạng thái đang sử dụng")]
        public bool DangSuDung { get; set; }
    }
}
