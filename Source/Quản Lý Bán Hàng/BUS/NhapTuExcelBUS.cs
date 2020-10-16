using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class NhapTuExcelBUS
    {
        NhapTuExcelDAO nhapTuExcelDAO = new NhapTuExcelDAO();
        public string DungLaiNeuTonTai(List<NhaCungCapDTO_BD> bd)
        {
            for(int i = 0; i < bd.Count;i++)
            {
                DataTable dt = nhapTuExcelDAO.KiemTraNhaCungCapDaTonTai(bd[i].MaNCC);
                if (dt.Rows.Count > 0)
                    return bd[i].MaNCC;
                nhapTuExcelDAO.ThemNhaCungCap(bd[i]);
            }
            return "1";
        }
        public string BoQuaNeuTonTai(List<NhaCungCapDTO_BD> bd)
        {
            for (int i = 0; i < bd.Count; i++)
            {
                DataTable dt = nhapTuExcelDAO.KiemTraNhaCungCapDaTonTai(bd[i].MaNCC);
                if (dt.Rows.Count == 0)
                    nhapTuExcelDAO.ThemNhaCungCap(bd[i]);
            }
            return "1";
        }
        public string CapNhatNeuTonTai(List<NhaCungCapDTO_BD> bd)
        {
            for (int i = 0; i < bd.Count; i++)
            {
                DataTable dt = nhapTuExcelDAO.KiemTraNhaCungCapDaTonTai(bd[i].MaNCC);
                if (dt.Rows.Count > 0)
                    nhapTuExcelDAO.CapNhatNhaCungCap(bd[i]);
                else
                {
                    nhapTuExcelDAO.ThemNhaCungCap(bd[i]);
                }
            }
            return "1";
        }
    }
}
