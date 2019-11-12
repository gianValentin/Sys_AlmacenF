using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sys_AlmacenF.Val
{
    class Conexion
    {
        public static string cnn;
        public static bool iniConexion()
        {
            bool ok = false;
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "db_almacenf";
            sb.UserID = "root";
            sb.Password = "48836498@";
            sb.Port = 3306;
            cnn = sb.ConnectionString;
            MySqlConnection cn = new MySqlConnection(cnn);
            try
            {
                cn.Open();
                ok = true;
                cn.Close();
            }catch(Exception ex)
            {
                cn.Close();            
            }
            return ok;
        }

    }
}
