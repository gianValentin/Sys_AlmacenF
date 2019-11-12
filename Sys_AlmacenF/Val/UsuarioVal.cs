using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sys_AlmacenF.Val
{
    class UsuarioVal
    {
        MySqlConnection cn = new MySqlConnection(Conexion.cnn);
        public bool verificaAcceso(string usuario,string clave)
        {
            bool ok = false;

            MySqlCommand cmd = new MySqlCommand("select * from usuarios where username='"+usuario+"' and clave='"+clave+"'",cn);

            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ok = true;
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
            }

            return ok;
        }

    }
}
