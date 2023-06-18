using Common.DAL;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BLL
{
    public class InformationBLL
    {
        public List<InformationViewModel> GetListInformationViewModels()
        {
            List<InformationViewModel> informationViewModels = new List<InformationViewModel>();
            using (var context = new AutoTienDienBankContext())
            {
                var datas = context.Informations.Where(x => x.Deleted == false);
                foreach (var data in datas)
                {
                    InformationViewModel informationViewModel = new InformationViewModel()
                    {
                        TenKey = data.TenKey,
                        DangSuDung = data.DangSuDung,
                        Key = data.Key,
                        SerialNumber = data.SerialNumber,
                        DaKichHoat = data.DaKichHoat,
                        LoaiTool = data.LoaiTool,
                        HanSuDung = data.HanSuDung.ToString("dd/MM/yyyy")
                    };
                    informationViewModels.Add(informationViewModel);
                }
            }
            return informationViewModels;
        }

        public bool ThemMoiKey(string tenGoiNho, string serialNumber, string key, string loaiTool, DateTime hsd)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber && x.Key == key && x.LoaiTool == loaiTool);
                if (data != null)
                {
                    return false;
                }
                else
                {
                    InformationModel informationModel = new InformationModel()
                    {
                        TenKey = tenGoiNho,
                        SerialNumber = serialNumber,
                        Key = key,
                        DaKichHoat = false,
                        DangSuDung = true,
                        LoaiTool = loaiTool,
                        HanSuDung = hsd
                    };
                    context.Informations.Add(informationModel);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public void XoaSerialNumber(string serialNumber)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber);
                if (data != null)
                {
                    data.Deleted = true;
                    context.SaveChanges();
                }
            }
        }

        public bool DangKyAutoTienDienBank(string serialNumber, string key, string loaiTool)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber && x.DangSuDung == true && x.Key == key && x.LoaiTool == loaiTool && x.HanSuDung > DateTime.Now);
                if (data != null)
                {
                    data.DaKichHoat = true;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void KhoaSerialNumber(string serialNumber)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber);
                if (data != null)
                {
                    data.DangSuDung = false;
                    context.SaveChanges();
                }
            }
        }

        public void MoKhoaSerialNumber(string serialNumber)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber);
                if (data != null)
                {
                    data.DangSuDung = true;
                    context.SaveChanges();
                }
            }
        }

        public bool CheckSerialNumber(string serialNumber, string loaiTool)
        {
            using (var context = new AutoTienDienBankContext())
            {
                var data = context.Informations.FirstOrDefault(x => x.Deleted == false && x.SerialNumber == serialNumber && x.DangSuDung == true && x.DaKichHoat == true && x.LoaiTool == loaiTool && x.HanSuDung > DateTime.Now);
                if (data != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
