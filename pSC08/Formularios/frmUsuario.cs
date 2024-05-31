using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pSC08
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.Text = "Maestro de Usuario";
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // pregunta si presionaste la tecla escape
            {
                this.Close(); // cierra este formulario
            }
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Clear(); // Clear --> limpia el contenido del textbox
            txtNombre.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtPuesto.Clear();

            lblPuesto.Text = "";  // comilla doble limpia el contenido del label
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // este metodo limpiara los textbox y los label
            txtUsuario.Focus();   // envia el cursor hacia el textbox txtUsuario
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra este formularo
        }
    }
}
