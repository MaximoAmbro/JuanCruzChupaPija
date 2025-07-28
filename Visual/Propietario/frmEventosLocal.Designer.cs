namespace Visual.Vendedor
{
    partial class frmEventosLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEliminarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEvento.FlatAppearance.BorderSize = 0;
            this.btnEliminarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEvento.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEvento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEvento.Location = new System.Drawing.Point(19, 367);
            this.btnEliminarEvento.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(242, 42);
            this.btnEliminarEvento.TabIndex = 45;
            this.btnEliminarEvento.Text = "Eliminar evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEventos.Location = new System.Drawing.Point(28, 85);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.Size = new System.Drawing.Size(986, 232);
            this.dgvEventos.TabIndex = 44;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(102, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 74);
            this.label2.TabIndex = 43;
            this.label2.Text = "Eventos";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.btnVolver.Location = new System.Drawing.Point(11, 450);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 33);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblNombre.Location = new System.Drawing.Point(351, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(427, 74);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "(Nombre local)";
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnModificarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEvento.FlatAppearance.BorderSize = 0;
            this.btnModificarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEvento.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEvento.ForeColor = System.Drawing.Color.White;
            this.btnModificarEvento.Location = new System.Drawing.Point(348, 367);
            this.btnModificarEvento.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(242, 42);
            this.btnModificarEvento.TabIndex = 47;
            this.btnModificarEvento.Text = "Administrar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = false;
            this.btnModificarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAgregarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEvento.FlatAppearance.BorderSize = 0;
            this.btnAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEvento.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEvento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEvento.Location = new System.Drawing.Point(663, 367);
            this.btnAgregarEvento.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(242, 42);
            this.btnAgregarEvento.TabIndex = 48;
            this.btnAgregarEvento.Text = "Agregar Evento";
            this.btnAgregarEvento.UseVisualStyleBackColor = false;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnModificarEvento_Click);
            // 
            // frmEventosLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 494);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.btnModificarEvento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEventosLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarEvento";
            this.Load += new System.EventHandler(this.frmEventosLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.Button btnAgregarEvento;
    }
}