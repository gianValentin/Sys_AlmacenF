using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sys_AlmacenF.Forms;
using Sys_AlmacenF.Val;

namespace Sys_AlmacenF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Conexion.iniConexion())
            {
                Application.Run(new FrmLogin());
            }
            else
            {
                MessageBox.Show("- Problemas al conectar con la Base de Datos\n- Verifique su conxión de Intenet \n- Si el proble persiste ponerse en contacto con el desarrollador","Error Conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }
    }
}
