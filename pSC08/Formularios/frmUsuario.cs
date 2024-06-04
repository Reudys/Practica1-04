using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            this.KeyPreview = true; //Activa las teclas de funciones
            this.Text = "Maestro de Usuario"; //Cambiamos el titulo del formulario
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // pregunta si presionaste la tecla escape
            {
                this.Close(); // cierra este formulario
            }
        }

        //---------------Btns-------------------

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

        //---------------TextBox-------------------

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtUsuario.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // mueve el cursor hacia el textbox txtNombre
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
            {
                BuscarUsuario(txtUsuario.Text);  // mueve el cursor hacia el textbox txtNombre
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) // pregunta si presionaste la tecla F4
            {
                
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtNombre.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    txtCorreo.Focus();  // mueve el cursor hacia el textbox txtCorreo
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtCorreo.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    txtPassword.Focus();  // mueve el cursor hacia el textbox txtPassword
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtPassword.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    txtPuesto.Focus();  // mueve el cursor hacia el textbox txtPuesto
                }
            }
        }

        private void txtPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) // pregunta si presionaste la tecla F4
            {

            }
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtPuesto.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    btnGuardar.Focus();  // mueve el cursor hacia el textbox btnGuardar
                }
            }
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {

        }

        //--------------Metodos-----------------

        private void LimpiarFormulario()
        {
            txtUsuario.Clear(); // Clear --> limpia el contenido del textbox
            txtNombre.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtPuesto.Clear();

            lblPuesto.Text = "";  // comilla doble limpia el contenido del label
        }

        private void BuscarUsuario(string nombreUsuario)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stQuery = "SELECT NOMBRECORTO, NOMBRECOMPLETO, CORREO, CLAVE, POSICION FROM "
                             + "USUARIO WHERE ACTIVO = 'TRUE' AND NOMBRECORTO = @A1";

            SqlCommand cmd = new SqlCommand(stQuery, cnx); //Enviamos el script al motor de SQL
            cmd.Parameters.AddWithValue("@A1", nombreUsuario); //Declaro la variable y le asigno su valor correspondiente
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read()) // Aquí pregunta HasRow = true
            {
                txtUsuario.Text = rcd["NOMBRECORTO"].ToString();
                txtNombre.Text = rcd["NOMBRECOMPLETO"].ToString();
                txtCorreo.Text = rcd["CORREO"].ToString();
                txtPassword.Text = rcd["CLAVE"].ToString();
                txtPuesto.Text = rcd["POSICION"].ToString();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
