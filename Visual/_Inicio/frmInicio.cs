﻿using System;
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

        public SqlConnection ConexionSql;
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
            txtMailLogin.Text = "";
            txtContraseñaLogin.Text = "";
            txtContraseñaLogin.PasswordChar = '*';
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
            }
            catch (Exception ex)
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
            frm.ConexionSql = ConexionSql; // Pasar la conexión a la nueva instancia
            frm.Show();
            this.Hide();
        }
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

        }

        public void ValidarLista(string mail, string contraseña)
        {
            string consulta = "SELECT TipoUsuario FROM Usuario WHERE Mail = @Mail AND Contraseña = @Contraseña";

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
                        frm.ConexionSql = ConexionSql;
                        frm.Show();
                        this.Hide();
                    }
                    else if (tipoUsuario == "Propietario")
                    {
                        MessageBox.Show("Bienvenido propietario.");
                    }
                    else
                    {
                        MessageBox.Show($"Bienvenido usuario tipo: {tipoUsuario}");
                    }
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            }
        }
    }
}