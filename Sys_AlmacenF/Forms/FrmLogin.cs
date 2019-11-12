using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sys_AlmacenF.Val;

namespace Sys_AlmacenF.Forms
{
    public partial class FrmLogin : Form
    {
        UsuarioVal usuarioVal = new UsuarioVal();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            string username = txtUsuario.Text;
            string clave = txtContraseña.Text;

            if (usuarioVal.verificaAcceso(username, clave))
            {
                this.Hide();
                FrmHome frmHome = new FrmHome();
                frmHome.FormClosed += (s, args) => this.Close();
                frmHome.Show();
                
            }
            else
            {
                MessageBox.Show("usuario Incorrecto");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
