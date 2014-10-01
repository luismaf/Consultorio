using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }
        private string ValidarUsuario() {
            Business.Logic.Usuario oUsuario = new Business.Logic.Usuario();
            return oUsuario.Validar(txtUsuario.Text.Trim(), txtClave.Text);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Valido que el Nombre de Usuario y Contrasena son correctos
            if (ValidarUsuario()!= null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(null,"Recordatorio de Contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidarUsuario()!=null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Dispose();
                Application.Exit();
            }
        }
    }
}