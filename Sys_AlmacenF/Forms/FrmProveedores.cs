using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sys_AlmacenF.Val;

namespace Sys_AlmacenF.Forms
{
    public partial class FrmProveedores : Sys_AlmacenF.Forms.FrmPadre
    {
        ProveedoresVal proveedores = new ProveedoresVal();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cargarCodigoNuevo();
            cargarLista();
        }       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] proveedor = new string[8];
            proveedor[0] = txtRuc.Text;
            proveedor[1] = txtRazonsocial.Text;
            proveedor[2] = txtDirec.Text;
            proveedor[3] = txtTel.Text;
            proveedor[4] = txtEmail.Text;
            proveedor[5] = txtObser.Text;
            proveedor[6] = txtRuc.Text;
            proveedor[7] = txtRuc.Text;
            string msg = proveedores.crud(proveedor);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        #region
        private void cargarLista()
        {
            foreach (var data in proveedores.cargarLista())
            {
                lstProveedores.Items.Add(data);
            }
        }

        private void cargarCodigoNuevo()
        {
            txtCod.Text = proveedores.obtenerCodigo();
        }
        #endregion
    }
}
