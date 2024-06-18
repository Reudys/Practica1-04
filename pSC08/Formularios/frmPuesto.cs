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
    public partial class frmPuesto : Form
    {
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //Activa las teclas de funciones
            this.Text = "Maestro de Puestos"; //Cambiamos el titulo del formulario
        }

        private void frmPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // pregunta si presionaste la tecla escape
            {
                this.Close(); // cierra este formulario
            }
        }

        //----------------------------Botones---------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // este metodo limpiara los textbox y los label
            txtNombrePosicion.Focus();   // envia el cursor hacia el textbox txtUsuario
        }

        //--------------------------TexBox-------------------------------------
        private void txtIdPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtNombrePosicion.Text.Trim() != string.Empty)  // aqui pregunta que si el el textbox es diferente de vacio
                {
                    txtIdPosicion.Focus();  // mueve el cursor hacia el textbox txtNombre
                }
            }
        }

        private void txtIdPosicion_Leave(object sender, EventArgs e)
        {

        }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePosicion_Leave(object sender, EventArgs e)
        {

        }

        private void txtIdPosicion_Leave_1(object sender, EventArgs e)
        {
            BuscarUsuario(txtIdPosicion.Text);
        }

        private void txtIdPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui que si la tecla que presionaste es igual a ENTER
            {
                e.Handled = true;
                if (txtIdPosicion.Text.Trim() != string.Empty)  // aqui pregunta que si el textbox es diferente de vacio
                {
                    txtNombrePosicion.Focus();  // mueve el cursor hacia el textbox txtPuesto
                }
            }
        }

        //------------------------Labels-------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //------------------------Metodos-------------------------
        private void LimpiarFormulario()
        {
            txtNombrePosicion.Clear(); // Clear --> limpia el contenido del textbox
            txtIdPosicion.Clear();
            txtNombreFabrica.Clear();
            txtIdFabrica.Clear();
            txtIdDepartamento.Clear();
        }

        private void BuscarUsuario(String IdPosicion)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stQuery = "SELECT T1.NombreDePosicion, T1.Fabrica, T1.Departamento, T2.NombreDefabrica, T2.IDfabrica " +
                             "FROM POSICIONES T1 " +
                             "INNER JOIN FABRICA T2 ON T1.Fabrica = T2.IDfabrica " +
                             "INNER JOIN POSICIONES T3 ON T1.Departamento = T3.IDposicion " +
                             "WHERE T1.IDposicion = @A";

            SqlCommand cmd = new SqlCommand(stQuery, cnx); //Enviamos el script al motor de SQL
            cmd.Parameters.AddWithValue("@A", IdPosicion); //Declaro la variable y le asigno su valor correspondiente
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read()) // Aquí pregunta HasRow = true
            {
                txtNombrePosicion.Text = rcd["NombreDePosicion"].ToString();
                txtIdFabrica.Text = rcd["IDfabrica"].ToString();
                txtNombreFabrica.Text = rcd["NombreDefabrica"].ToString();
                txtIdDepartamento.Text = rcd["Departamento"].ToString();
            }
        }
    }
}
