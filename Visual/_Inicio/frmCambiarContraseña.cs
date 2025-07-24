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
    public partial class frmCambiarContraseña : Form
    {
        public SqlConnection ConexionSql;
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
        } // te devuelve al main
        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            txtMail.Text = "A";
            TxtPassword.Text = "B";
            TxtConfirmpassword.Text = "B";
            TxtPassword.PasswordChar = '*';
            TxtConfirmpassword.PasswordChar = '*';
        } // el load 
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConfirmpassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtConfirmpassword.PasswordChar = '*';
            }
        } // le pone asterisco a la contraseña
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (ControlarTxt() == true)
            {
                CambiarContraseña();
                MessageBox.Show("Contraseña cambiada");
            } // se carga a la bdd
            else
            {
                MessageBox.Show("Dale, son 3 cositos nomas cargalos viejo");
            }
        } // el boton confirmar
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.ConexionSql = ConexionSql;
            frm.Show();
            this.Hide();
        } // Boton volver


        public bool ControlarTxt()
        {
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese contraseña: ");
                return false;
            }
            if (string.IsNullOrEmpty(TxtConfirmpassword.Text))
            {
                MessageBox.Show("Ingrese confirmacion de contraseña: ");
                return false;
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Ingrese Mail: ");
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
        } // Controla que se llenen todos los campos
        private void CambiarContraseña()
        {
            string consulta = "UPDATE Usuario SET Contraseña = @Contraseña WHERE Mail = @Mail";
            using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
            {
                sqlcomando.Parameters.AddWithValue("@Mail", txtMail.Text);
                sqlcomando.Parameters.AddWithValue("@Contraseña", TxtPassword.Text); 

                ConexionSql.Open();
                int filasAfectadas = sqlcomando.ExecuteNonQuery();
                ConexionSql.Close();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Contraseña actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con ese correo.");
                }
            }
        } // Cambia la contraseña para la bdd

    }
}
