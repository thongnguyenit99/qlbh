using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class InPhieuChi : DevExpress.XtraReports.UI.XtraReport
    {
        public InPhieuChi()
        {
            InitializeComponent();
        }
        public void GanDuLieu(string nguoinhan, string diachi, string lydo, decimal sotien, string sotienbangchu, string mapnh, string mapc, string nv, int vt)
        {
            if(vt == 1)
            {
                xrLabel6.Text = "Phiếu Thu";
            }
            pnguoinhantien.Value = nguoinhan;
            pdiachi.Value = diachi;
            psotien.Value = sotien;
            plydo.Value = lydo;
            psotienbangchu.Value = sotienbangchu;
            pchungtugoc.Value = mapnh;
            pso.Value = mapc;
            pnhanvien.Value = nv;
            pthang.Value = DateTime.Today.Month.ToString("00");
            pngay.Value = DateTime.Today.Day.ToString("00");
            pnam.Value = DateTime.Today.Year.ToString("0000");
        }
    }
}
