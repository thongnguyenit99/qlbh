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
using System.IO;
using ExcelDataReader;
using Quan_Ly_Ban_Hang.DTO;
using Quan_Ly_Ban_Hang.BUS;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class NhapTuExcel : DevExpress.XtraEditors.XtraForm
    {
        NhapTuExcelBUS nhapTuExcelBUS = new NhapTuExcelBUS();
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public NhapTuExcel()
        {
            InitializeComponent();
            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "Dừng lại nếu tồn tại";
            item1.Value = 1;
            cbluuchon.Items.Add(item1);
            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Bỏ qua nếu tồn tại";
            item2.Value = 2;
            cbluuchon.Items.Add(item2);
            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Cập nhật nếu tồn tại";
            item3.Value = 3;
            cbluuchon.Items.Add(item3);

            cbluuchon.SelectedIndex = 0;

          
        }
        private void NhapTuExcel_Load(object sender, EventArgs e)
        {
        }
        DataTableCollection tableCollection;
        private void btnbrow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files | *.xls; *.xlsx; *.xlsm" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilename.Text = openFileDialog.FileName;
                    try
                    {
                        var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbsheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cbsheet.Items.Add(table.TableName);
                            }
                        }
                    }
                    catch(ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        List<NhaCungCapDTO_BD> nhaCungCap = new List<NhaCungCapDTO_BD>();
        private void NapDuLieu()
        {
            DataTable dt = tableCollection[cbsheet.SelectedItem.ToString()];
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO_BD nhaCungCapDTO_BD = new NhaCungCapDTO_BD();
                    try
                    {
                        nhaCungCapDTO_BD.MaNCC = dt.Rows[i]["Mã số"].ToString();
                        nhaCungCapDTO_BD.TenNCC = dt.Rows[i]["Tên Nhà Cung Cấp"].ToString();
                        if (dt.Rows[i]["Khu Vực"].ToString() == "Miền Bắc")
                        {
                            nhaCungCapDTO_BD.MaKV = "KV000001";
                        }
                        else if (dt.Rows[i]["Khu Vực"].ToString() == "Miền trung")
                        {
                            nhaCungCapDTO_BD.MaKV = "KV000002";
                        }
                        else if (dt.Rows[i]["Khu Vực"].ToString() == "Miền Nam")
                        {
                            nhaCungCapDTO_BD.MaKV = "KV000003";
                        }
                        else
                        {
                            nhaCungCapDTO_BD.MaKV = "KV000001";
                        }
                        nhaCungCapDTO_BD.NguoiLienHe = dt.Rows[i]["Người Liên Hệ"].ToString();
                        nhaCungCapDTO_BD.DiaChi = dt.Rows[i]["Địa Chỉ"].ToString();
                        nhaCungCapDTO_BD.DienThoai = dt.Rows[i]["Điện Thoại"].ToString();
                        nhaCungCapDTO_BD.DiDong = dt.Rows[i]["Di Động"].ToString();
                        nhaCungCapDTO_BD.Fax = dt.Rows[i]["Fax"].ToString();
                        nhaCungCapDTO_BD.ChucVu = dt.Rows[i]["Chức Vụ"].ToString();
                        nhaCungCapDTO_BD.ConQuanLy = true;
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu đầu vào không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    nhaCungCap.Add(nhaCungCapDTO_BD);
                }
                nhaCungCapDTOBDBindingSource.DataSource = nhaCungCap;
            }
        }
        private void cbsheet_SelectedValueChanged(object sender, EventArgs e)
        {
            NapDuLieu();
        }
       
        private void btnimport_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Đang lưu");
            splashScreenManager1.SetWaitFormDescription("Vui lòng đợi...");
            if ((cbluuchon.SelectedItem as ComboboxItem).Value.ToString() == "1")
            {
                string temp = nhapTuExcelBUS.DungLaiNeuTonTai(nhaCungCap);
                splashScreenManager1.CloseWaitForm();
                if (temp == "1")
                {
                    MessageBox.Show("DLNTT: Thêm dữ liệu vô cơ sở dữ liệu thàng công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dừng lại ở nhà cung cấp có mã " + temp, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if ((cbluuchon.SelectedItem as ComboboxItem).Value.ToString() == "2")
            {
                nhapTuExcelBUS.BoQuaNeuTonTai(nhaCungCap);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("BQNTT: Thêm dữ liệu vô cơ sở dữ liệu thàng công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if ((cbluuchon.SelectedItem as ComboboxItem).Value.ToString() == "3")
            {
                nhapTuExcelBUS.CapNhatNeuTonTai(nhaCungCap);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("CNNTT: Thêm dữ liệu vô cơ sở dữ liệu thàng công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnaplai_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = nhaCungCap;
            NapDuLieu();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


    }
}