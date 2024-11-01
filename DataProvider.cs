using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phát_triển_phần_mềm_bán_sách
{
    public class DataProvider
    {
        private String connectString = @"Data Source=DESKTOP-LBORLDH\SQLEXPRESS;Initial Catalog=Quan_ly_cua_hang_sach;Integrated Security=True;Trust Server Certificate=True";
    public DataTable execQuery(String query)    // select các bảng, trả về datatable
        {
            DataTable data = new DataTable();
            using (SqlConnection con = newSqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

   

        public int execNonQuery(String query) // so dong bi tac dong
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return (data);
        }
        public object execScaler(String query) // xu ly du lieu
        {
            object data = 0;     
            using(SqlConnection con= new SqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd= new SqlCommand(query, con);
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
