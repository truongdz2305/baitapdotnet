using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_thuc_hanh_14__11
{
    class KetNoi
    {
        private string conStr = "Server=127.0.0.1,1433;Database=SanBay;User Id=sa;Password=12345;Integrated Security=true; TrustServerCertificate=true;";
        private SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }

        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }

        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi thực thi: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool CapNhatDuLieu(string tableName, string columnName, object newValue, string condition)
        {
            try
            {
                string truyvan = $"UPDATE {tableName} SET {columnName} = @NewValue WHERE {condition}";
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                cmd.Parameters.AddWithValue("@NewValue", newValue);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi cập nhật dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool XoaDuLieu(string tableName, string condition)
        {
            try
            {
                string truyvan = $"DELETE FROM {tableName} WHERE {condition}";
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi xóa dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool ThemDuLieu(string tableName, Dictionary<string, object> columns)
        {
            try
            {
                string columnNames = string.Join(", ", columns.Keys);
                string paramNames = string.Join(", ", columns.Keys.Select(key => "@" + key));
                string truyvan = $"INSERT INTO {tableName} ({columnNames}) VALUES ({paramNames})";

                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);

                foreach (var column in columns)
                {
                    cmd.Parameters.AddWithValue("@" + column.Key, column.Value);
                }

                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi thêm dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
