using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.Vendedor
{
    public partial class frmAgregarEventoLocal : Form
    {

        public string NombreEvento { get; set; }
        public frmAgregarEventoLocal()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmEventosLocal form = new frmEventosLocal();
            form.Show(); this.Hide();
        }
        private void frmAgregarEventoLocal_Load(object sender, EventArgs e)
        {
            // falta logica bdd
            CargarDGV();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // falta logica bdd
            DateTime fechaHora = dtpFechaHora.Value;
            DateTime fecha = fechaHora.Date;
            TimeSpan hora = fechaHora.TimeOfDay;
            NombreEvento = txtNombre.Text;
            CargarDGV();
        }
        public void CargarDGV()
        {
            // Ver si Podemos hacer el dgv o usamos una listbox y chau
            dgvSectores.Refresh();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgvSectores.AutoGenerateColumns = true;
            dgvSectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
