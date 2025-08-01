﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class frmMenuVendedor : Form
    {
        public int IDUsuario;
        public SqlConnection ConexionSql;
        public string NombreUsuario;

        public frmMenuVendedor()
        {
            InitializeComponent();
        }

        private void btnMisLocales_Click(object sender, EventArgs e)
        {
            frmMisLocales frm = new frmMisLocales();
            frm.ConexionSql = ConexionSql;
            frm.IDUsuario = IDUsuario;
            frm.Show(); this.Hide();
        }
        private void btnRegistrarLocal_Click(object sender, EventArgs e)
        {
            frmRegistrarLocal frm = new frmRegistrarLocal();
            frm.ConexionSql = ConexionSql;
            frm.IDUsuario = IDUsuario;
            frm.Show(); this.Hide();
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
