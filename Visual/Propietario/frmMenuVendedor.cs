
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
    public partial class frmMenuVendedor : Form
    {
        public SqlConnection ConexionSql;
        public string NombreUsuario;

        public frmMenuVendedor()
        {
            InitializeComponent();
        }

        private void btnMisLocales_Click(object sender, EventArgs e)
        {
        }
        private void btnRegistrarLocal_Click(object sender, EventArgs e)
        {
        }
        private void frmMenuVendedor_Load(object sender, EventArgs e)
        {
            lblNombre.Text = NombreUsuario;
        }
        private void lblvolver_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.ConexionSql = ConexionSql;
            frmInicio.Show(); this.Hide();
        }
    }
}
