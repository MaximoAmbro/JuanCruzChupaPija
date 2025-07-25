using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visual
{
    public partial class frmInicio : Form
    {

        public SqlConnection ConexionSql;
        public frmInicio()
        {
            InitializeComponent();
            string miConexion =
            ConfigurationManager.ConnectionStrings["Visual.Properties.Settings.BddEventAura"].ConnectionString;
            ConexionSql = new SqlConnection(miConexion);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtMailLogin.Text = "";
            txtContraseñaLogin.Text = "";
            txtContraseñaLogin.PasswordChar = '*';
        }
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                txtContraseñaLogin.PasswordChar = '\0';
            }
            else
            {
                txtContraseñaLogin.PasswordChar = '*';
            }
        } //Le pone el asterisco a la contraseña
        private void lblolividarcontra_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frm = new frmCambiarContraseña();
            frm.ConexionSql = ConexionSql;
            frm.Show();
            this.Hide();
        } // Llama frmCambiarContraseña
        private void lblcrearcuenta_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.ConexionSql = ConexionSql;
            frm.Show();
            this.Hide();
        } // Llama a frmCrearCuenta
        private void btninicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailLogin.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario",
                              "Campo vacíos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtContraseñaLogin.Text))
            {
                MessageBox.Show("Por favor, ingrese contraseña",
                              "Campo vacíos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ValidarLista(txtMailLogin.Text, txtContraseñaLogin.Text);
            }
        } // Llamado a los menues
        public void ValidarLista(string mail, string contraseña)
        {
            string consulta = "SELECT TipoUsuario FROM Usuario WHERE Mail = @Mail AND Contraseña = @Contraseña";
            string consulta2 = "SELECT Nombre FROM Usuario WHERE Mail = @Mail AND Contraseña = @Contraseña";
            string consulta3 = "SELECT ID FROM Usuario WHERE Mail = @Mail AND Contraseña = @Contraseña";
            string NombreUsuario = string.Empty;
            int ID = 0;
            using (SqlCommand sqlcomando3 = new SqlCommand(consulta3, ConexionSql))
            {
                sqlcomando3.Parameters.AddWithValue("@Mail", txtMailLogin.Text);
                sqlcomando3.Parameters.AddWithValue("@Contraseña", txtContraseñaLogin.Text);
                ConexionSql.Open();
                object IDUsuario = sqlcomando3.ExecuteScalar();
                ConexionSql.Close();
                if (IDUsuario != null)
                {
                    ID = Convert.ToInt32(IDUsuario);
                }
            } // busca y devuelve el ID del usuario
            using (SqlCommand sqlcomando2 = new SqlCommand(consulta2, ConexionSql)) 
            {
                sqlcomando2.Parameters.AddWithValue("@Mail", txtMailLogin.Text);
                sqlcomando2.Parameters.AddWithValue("@Contraseña", txtContraseñaLogin.Text);
                ConexionSql.Open();
                object Nombre = sqlcomando2.ExecuteScalar();
                ConexionSql.Close();
                if (Nombre != null)
                {
                    NombreUsuario = Nombre.ToString();
                }
            } // busca y devuelve el nombre de usuario
            using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
            {
                sqlcomando.Parameters.AddWithValue("@Mail", txtMailLogin.Text);
                sqlcomando.Parameters.AddWithValue("@Contraseña", txtContraseñaLogin.Text);

                ConexionSql.Open();
                object resultado = sqlcomando.ExecuteScalar(); 
                
                ConexionSql.Close();

                if (resultado != null)
                {
                    string tipoUsuario = resultado.ToString();
                    if (tipoUsuario == "Cliente")
                    {
                        frmMenuCliente frm = new frmMenuCliente();
                        frm.NombreUsuario = NombreUsuario;
                        frm.IDUsuario = ID;
                        frm.ConexionSql = ConexionSql;
                        frm.Show();
                        this.Hide();
                    }
                    else if (tipoUsuario == "Propietario")
                    {
                        frmMenuVendedor frm = new frmMenuVendedor();
                        frm.IDUsuario = ID;

                        frm.NombreUsuario = NombreUsuario;
                        frm.ConexionSql = ConexionSql;
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            }
        } // Valida la lista de usuarios

    }
}