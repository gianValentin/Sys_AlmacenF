using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sys_AlmacenF.Val
{
    class ProveedoresVal
    {
        MySqlConnection cn = new MySqlConnection(Conexion.cnn);

        public List<ListViewItem> cargarLista()
        {
            List<ListViewItem> lstProveedore = new List<ListViewItem>();

            MySqlCommand cmd = new MySqlCommand("select * from proveedores", cn);
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string[] fila = new string[8];
                        for (int i = 0; i < fila.Length; i++)
                        {
                            fila[i] = dr[i].ToString();
                        }                        
                        ListViewItem item = new ListViewItem(fila);
                        lstProveedore.Add(item);
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
            }
            return lstProveedore;
        }

        public string obtenerCodigo()
        {
            string cod = "";
            MySqlCommand cmd = new MySqlCommand("select id_proveedor from proveedores limit 1;", cn);
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cod = dr[0].ToString();
                }
                else
                {
                    cod = "1";
                }
                cn.Close();
            }catch(Exception ex)
            {
                cn.Close();
            }
            return cod;
        }

        public string crud(string[] proveedor)
        {
            string msg = "";
            return msg;

        }
    }
}
