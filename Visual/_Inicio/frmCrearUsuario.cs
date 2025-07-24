using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class frmCrearUsuario : Form
    {
        public SqlConnection ConexionSql;
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

            txtmail.Text="A";
            txtApellido.Text = "A";
            txtNombre.Text = "A";
            TxtPassword.Text = "A";
            TxtConfirmpassword.Text = "A";
            TxtPassword.PasswordChar = '*';
            TxtConfirmpassword.PasswordChar='*';
        }  // El Load del formulario
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConfirmpassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtConfirmpassword.PasswordChar = '*';
            }
        } // El de la contraseña
        private void lblyatengocuen_Click(object sender, EventArgs e)
        {
            Cerrar();
        } // Nos devuelve al incio
        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (RevisarTextbox()== true)
            {
                ValidarLista();
            }
            else { return; }
        }
        private bool RevisarTextbox()
        {
            if (string.IsNullOrEmpty(txtmail.Text))
            {
                MessageBox.Show("Ingrese nombre: ");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese Usuario: ");
                return false;
            }
            if (string.IsNullOrEmpty(txtmail.Text))
            {
                MessageBox.Show("Ingrese Mail: ");
                return false;

            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese contraseña: ");
                return false;

            }
            if (string.IsNullOrEmpty(TxtConfirmpassword.Text))
            {
                MessageBox.Show("Ingrese segunda contraseña: ");
                return false;
            }
            if (TxtPassword.Text != TxtConfirmpassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }
            else
            {
                return true;
            }
        } // Revisa si los textbox estan vacios
        public void ValidarLista()
        {
            string consulta = "INSERT INTO Usuario (Nombre, Apellido, Mail, Contraseña, TipoUsuario) " +
                "VALUES (@Nombre, @Apellido, @Mail, @Contraseña, @TipoUsuario)";
            SqlCommand sqlComando = new SqlCommand(consulta, ConexionSql);
            ConexionSql.Open();
            sqlComando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            sqlComando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            sqlComando.Parameters.AddWithValue("@Mail", txtmail.Text);
            sqlComando.Parameters.AddWithValue("@Contraseña", TxtPassword.Text);
            sqlComando.Parameters.AddWithValue("@TipoUsuario", cbTipoUsuario.Text);
            sqlComando.ExecuteNonQuery();
            ConexionSql.Close();
            MessageBox.Show("Usuario creado correctamente");
            Cerrar();
        } // Funcionamiento del formulario (agrega todo a la database)
        private void Cerrar()
        {
            frmInicio frm = new frmInicio();
            frm.ConexionSql = ConexionSql;
            frm.Show();
            this.Hide();
        } // cierra el form

    }
}
    


    

