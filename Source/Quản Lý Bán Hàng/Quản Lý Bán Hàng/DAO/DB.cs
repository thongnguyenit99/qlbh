using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Bán_Hàng.DAO
{
    public class DB
    {
        public static SqlConnection sqlConnection = new SqlConnection("server=; database=QLBH_Deploy99; Trusted_Connection = True;");
        //Hàm rút trích dữ liệu tổng quát
        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        // Hàm thực thi một câu truy vấn
        public int ExcuteSql(string sql)
        {
            int rs = 0;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            rs = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rs;
        }
        // Hàm thực thi một proc
        public int ExecuteStore(string sql, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //Thêm tham số
            sqlCommand.Parameters.AddRange(param);
            sqlConnection.Open();
            //Trả về số dòng bị ảnh hưởng
            var affectedRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return affectedRows;
        }
    }
}
