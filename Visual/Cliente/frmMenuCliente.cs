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
    public partial class frmMenuCliente : Form
    {
        public SqlConnection ConexionSql;
        public string NombreUsuario;
        public frmMenuCliente()
        {
            InitializeComponent();
        }
        private void frmMenuUsuario_Load(object sender, EventArgs e)
        {
            lblNombre.Text = NombreUsuario;
        }
        private void btnEventos_Click(object sender, EventArgs e)
        {
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
        }
        private void lblvolver_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }
    }
}
