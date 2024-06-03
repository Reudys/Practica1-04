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
    public partial class frmPuesto : Form
    {
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //Activa las teclas de funciones
            this.Text = "Puestos de Trabajo"; //Cambiamos el titulo del formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // pregunta si presionaste la tecla escape
            {
                this.Close(); // cierra este formulario
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // este metodo limpiara los textbox y los label
            txtIdPosition.Focus();   // envia el cursor hacia el textbox txtUsuario
        }

        private void LimpiarFormulario()
        {
            txtIdPosition.Clear(); // Clear --> limpia el contenido del textbox
            txtNombrePosicion.Clear();
            txtIdFabrica.Clear();
            txtNombreFabrica.Clear();
            txtIdDepartamento.Clear();
            textNombreDepartamento.Clear();
        }
    }
}
