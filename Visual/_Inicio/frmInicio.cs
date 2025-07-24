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
/*using Entidades; 
using Negocio;
using Repositorio;
*/
namespace Visual
{
    public partial class frmInicio : Form
    {

        SqlConnection ConexionSql;
        public frmInicio()
        {
            InitializeComponent();
            string miConexion =
            ConfigurationManager.ConnectionStrings["Visual.Properties.Settings.BddEventAura"].ConnectionString;
            ConexionSql = new SqlConnection(miConexion);            
            /*  GestorClientes.Instance.CargarLista();
            GestorPropietario.Instance.CargarLista(); */
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
            MostradorUsuarios(); 
        }
        private void MostradorUsuarios()
        {
            try
            {        
            string consulta = "SELECT * FROM Usuario";
            SqlDataAdapter miAdaptador = new SqlDataAdapter(consulta, ConexionSql);

                using (miAdaptador)
                {
                    DataTable dataTable = new DataTable();
                    miAdaptador.Fill(dataTable);

                    DataColumn columnaNombreTipo = new DataColumn("NombreTipo", typeof(string));
                    dataTable.Columns.Add(columnaNombreTipo);

                    foreach (DataRow fila in dataTable.Rows)
                    {
                        fila["NombreTipo"] = fila["Nombre"].ToString() + " " + fila["TipoUsuario"].ToString();
                    }

                    lstUsuarios.DisplayMember = "NombreTipo";
                    lstUsuarios.ValueMember = "ID";
                    lstUsuarios.DataSource = dataTable.DefaultView;
                } 
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MostrarEntrada()
        {
            try
            {
                string consulta = "SELECT E.ID, Ev.Nombre AS NombreEntrada " +
                          "FROM Entradas E " +
                          "INNER JOIN Eventos Ev ON E.ID_Evento = Ev.ID " +
                          "WHERE E.ID_Usuario = @ID_Usuario";
                SqlCommand sqlComando = new SqlCommand(consulta, ConexionSql);
                sqlComando.Parameters.AddWithValue("@ID_Usuario", lstUsuarios.SelectedValue);

                SqlDataAdapter miAdaptador = new SqlDataAdapter(sqlComando);
                using (miAdaptador)
                {
                    DataTable dataTable = new DataTable();
                    miAdaptador.Fill(dataTable);
                    lstEntradas.DisplayMember = "NombreEntrada";
                    lstEntradas.ValueMember = "ID";
                    lstEntradas.DataSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
            }
        } //ya está
        private void lblolividarcontra_Click(object sender, EventArgs e)
        {
            /* frmCambiarContraseña frm = new frmCambiarContraseña();
             frm.Show();*/
            this.Hide();
        }
        private void lblcrearcuenta_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.ConexionSql = ConexionSql; // Pasar la conexión a la nueva instancia
            frm.Show(); 
            this.Hide();
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario",
                              "Campo vacíos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese contraseña",
                              "Campo vacíos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //ValidarLista(TxtUsername.Text, TxtPassword.Text);
            }
        }
        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex != -1)
            {
                MostrarEntrada();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM Entradas WHERE ID = @ID";
            SqlCommand sqlComando = new SqlCommand(consulta, ConexionSql);
            ConexionSql.Open();
            sqlComando.Parameters.AddWithValue("@ID", lstEntradas.SelectedValue);
            sqlComando.ExecuteNonQuery();
            ConexionSql.Close();
            MostrarEntrada();
        }
        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Usuario (Nombre, Apellido, Mail, Contraseña, TipoUsuario) " +
                "VALUES (@Nombre, @Apellido, @Mail, @Contraseña, @TipoUsuario)";
            SqlCommand sqlComando = new SqlCommand(consulta, ConexionSql);
            ConexionSql.Open();
            sqlComando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            sqlComando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            sqlComando.Parameters.AddWithValue("@Mail", txtMail.Text);
            sqlComando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
            sqlComando.Parameters.AddWithValue("@TipoUsuario", cbTipoDeUsuario.Text);
            sqlComando.ExecuteNonQuery();
            ConexionSql.Close();
            MostradorUsuarios();
        }
        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM Usuario WHERE ID = @ID";
            SqlCommand sqlComando = new SqlCommand(consulta, ConexionSql);
            ConexionSql.Open();
            sqlComando.Parameters.AddWithValue("@ID", lstUsuarios.SelectedValue);
            sqlComando.ExecuteNonQuery();
            ConexionSql.Close();
            MostradorUsuarios();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE Usuario SET " +
                      "Nombre = @Nombre, " +
                      "Apellido = @Apellido, " +
                      "Mail = @Mail, " +
                      "Contraseña = @Contraseña, " +
                      "TipoUsuario = @TipoUsuario " +
                      "WHERE ID = @ID";

            using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
            {
                sqlcomando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                sqlcomando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                sqlcomando.Parameters.AddWithValue("@Mail", txtMail.Text);
                sqlcomando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                sqlcomando.Parameters.AddWithValue("@TipoUsuario", cbTipoDeUsuario.Text);
                sqlcomando.Parameters.AddWithValue("@ID", lstUsuarios.SelectedValue); 

                ConexionSql.Open();
                sqlcomando.ExecuteNonQuery();
                ConexionSql.Close();
            }
            MostradorUsuarios();
        }
        /*public void ValidarLista(string mail, string contraseña)
{
if (GestorClientes.Instance.EncontrarMail(mail))
{
if (GestorClientes.Instance.EncontrarContraseña(contraseña, mail))
{
frmMenuCliente frm = new frmMenuCliente();
frm.Mail = mail;
frm.Show();
this.Hide();
}
else
{
MessageBox.Show("Contraseña incorrecta",
"Error",
MessageBoxButtons.OK,
MessageBoxIcon.Error);
}
}
else if (GestorPropietario.Instance.EncontrarMail(mail))
{
if (GestorPropietario.Instance.EncontrarContraseña(contraseña, mail))
{
frmMenuVendedor frm = new frmMenuVendedor();
frm.Mail = mail;
frm.Show();
this.Hide();
}
else
{
MessageBox.Show("Contraseña incorrecta",
"Error",
MessageBoxButtons.OK,
MessageBoxIcon.Error);
}
}
else
{
MessageBox.Show("Usuario no registrado",
"Error",
MessageBoxButtons.OK,
MessageBoxIcon.Error);
}
}*/
    }
}