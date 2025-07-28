using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Negocio;
using Repositorio;

namespace Visual.Vendedor
{
    public partial class AgregarSectorEvento: Form
    {
        public int IDUsuario; public int IDlocal; public int IDEvento;
        public SqlConnection ConexionSql;public  GestorEventos gestoreventos = new GestorEventos();
        public AgregarSectorEvento()
        {
            InitializeComponent();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (Comprobarcampos () == true)
            {
                if (VerificarCantiadadSectores() == true)
                {
                    gestoreventos.AgregarSector(txtNombre.Text, Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtPrecio.Text), IDEvento, ConexionSql);
                    MessageBox.Show("Sector agregado correctamente."); 
                }
            }
            else
            {
              MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
        public bool Comprobarcampos()
        {
             if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCapacidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        public bool VerificarCantiadadSectores()
        {
            string consulta = "SELECT COUNT(*) FROM Sectores WHERE EventoID = @ID_Evento";
            using (SqlCommand cmd = new SqlCommand(consulta, ConexionSql))
            {
                cmd.Parameters.AddWithValue("@ID_Evento", IDEvento);
                ConexionSql.Open();
                int cantidadSectores = (int)cmd.ExecuteScalar();
                ConexionSql.Close();

                if (cantidadSectores >= 3)
                {
                    MessageBox.Show("Ya se han registrado 3 sectores para este evento. No se pueden agregar más.");
                    return false;
                }
                return true;
            }
        }
        private void lblyatengocuen_Click(object sender, EventArgs e)
        {
            frmModificarSectoresEventos form = new frmModificarSectoresEventos();
            form.ConexionSql = ConexionSql;
            form.IDlocal = IDlocal;
            form.IDEvento = IDEvento;
            form.IDUsuario = IDUsuario;
            form.Show(); this.Hide();
        }
    }
}
