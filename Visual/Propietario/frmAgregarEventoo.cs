using Negocio;
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
using Visual.Vendedor;

namespace Visual.Propietario
{
    public partial class frmAgregarEventoo : Form
    {
        public int IDUsuario; public int IDlocal;
        public SqlConnection ConexionSql; public GestorEventos gestorEventos = new GestorEventos();
        public frmAgregarEventoo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gestorEventos.AgregarEvento(txtNombre.Text, dtEvento.Value, IDlocal, ConexionSql);
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            frmModificarSectoresEventos frm = new frmModificarSectoresEventos();
            frm.ConexionSql = ConexionSql;
            frm.IDlocal = IDlocal;
            frm.IDUsuario = IDUsuario;
            frm.Show(); this.Hide();
        }

        private void frmAgregarEventoo_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
