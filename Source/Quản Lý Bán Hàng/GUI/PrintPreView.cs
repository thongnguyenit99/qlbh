using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class PrintPreView : DevExpress.XtraEditors.XtraForm
    {
        public PrintPreView(string nguoinhan, string diachi, string lydo, float sotien, string sotienbangchu, string mapnh, string mapc, string nv, int vt)
        {
            InitializeComponent();
            InPhieuChi inPhieuChi = new InPhieuChi();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in inPhieuChi.Parameters)
                p.Visible = false;
            inPhieuChi.GanDuLieu(nguoinhan, diachi, lydo, decimal.Parse(sotien.ToString()), sotienbangchu, mapnh, mapc, nv, vt);
            documentViewer1.DocumentSource = inPhieuChi;
        }
        public void InPhieuChiTheoMa()
        {

        }
    }
}