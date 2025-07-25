
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
using Visual.Vendedor;

namespace Visual
{
    public partial class frmMisLocales : Form
    {
        public int IDUsuario;
        public SqlConnection ConexionSql;
        public frmMisLocales()
        {
            InitializeComponent();
        }
        private void btnEventosLocal_Click(object sender, EventArgs e)
        {
            if (dgvLocales.SelectedCells.Count > 0)
            {
                string nombreLocal = dgvLocales.SelectedCells[0].Value.ToString();
                frmEventosLocal frm = new frmEventosLocal();
                frm.NombreLocal = nombreLocal;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un local", "Hola Pedro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuVendedor frm = new frmMenuVendedor();
            frm.ConexionSql = ConexionSql;
            frm.IDUsuario = IDUsuario;
            frm.Show(); this.Hide();
        }
        private void frmMisLocales_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT Nombre, Direccion, Capacidad FROM Locales " +
                              "WHERE PropietarioID = @IDUsuario";
            using (SqlCommand cmd = new SqlCommand(consulta, ConexionSql))
            {
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvLocales.DataSource = tabla;
            }

        }

    }
}
