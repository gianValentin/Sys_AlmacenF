using System;
using System.Windows.Forms;
using Sys_AlmacenF.Forms;


namespace Sys_AlmacenF
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
        }

        private void FrmHome_Resize(object sender, EventArgs e)
        {
            Responzive.responziveSize(this, groupBox1);
            Responzive.responzivePoint(this, groupBox1);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
        }
    }
}
