using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    public class DataProvider
    {
        private string cnnStr = @"Data Source=DESKTOP-AQ65L5R\SQLEXPRESS;Initial Catalog=DOAN_TEST;Integrated Security=True";
        
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataProvider();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DataProvider()
        {
            cnnStr = @"Data Source=DESKTOP-AQ65L5R\SQLEXPRESS;Initial Catalog=DOAN_TEST;Integrated Security=True";
        }
        public bool ExcuteDB(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnStr))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                return dt;                
            }
        }
        public DataTable ExecuteQueryParam(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(data);
                cnn.Close();
            }
            return data;
        }

        public bool Backup(string browse)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnStr))
                {
                    string database = cnn.Database.ToString();
                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + browse + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    SqlCommand scmd = new SqlCommand(q, cnn);
                    cnn.Open();
                    scmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Restore(string browse)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnStr))
                {
                    cnn.Open();
                    string database = cnn.Database.ToString();

                    string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql1, cnn);
                    cmd1.ExecuteNonQuery();

                    string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + browse + "' WITH REPLACE;");
                    SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                    cmd2.ExecuteNonQuery();

                    string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                    cmd3.ExecuteNonQuery();

                    cnn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
