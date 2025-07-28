namespace Visual.Vendedor
{
    partial class frmModificarSectoresEventos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvSectores = new System.Windows.Forms.DataGridView();
            this.btnAgregarSector = new System.Windows.Forms.Button();
            this.btnEliminarSector = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.btnModificarSector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.btnVolver.Location = new System.Drawing.Point(15, 449);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(134, 34);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "EN DUDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "EN DUDA";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(12, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 32);
            this.txtNombre.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 60);
            this.label1.TabIndex = 38;
            this.label1.Text = "Agregar evento en ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblNombre.Location = new System.Drawing.Point(452, 18);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(413, 60);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "[Nombre del local]";
            // 
            // dgvSectores
            // 
            this.dgvSectores.BackgroundColor = System.Drawing.Color.White;
            this.dgvSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectores.GridColor = System.Drawing.Color.White;
            this.dgvSectores.Location = new System.Drawing.Point(348, 175);
            this.dgvSectores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSectores.Name = "dgvSectores";
            this.dgvSectores.RowHeadersWidth = 51;
            this.dgvSectores.Size = new System.Drawing.Size(588, 308);
            this.dgvSectores.TabIndex = 53;
            // 
            // btnAgregarSector
            // 
            this.btnAgregarSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAgregarSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSector.FlatAppearance.BorderSize = 0;
            this.btnAgregarSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSector.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSector.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSector.Location = new System.Drawing.Point(73, 277);
            this.btnAgregarSector.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnAgregarSector.Name = "btnAgregarSector";
            this.btnAgregarSector.Size = new System.Drawing.Size(194, 36);
            this.btnAgregarSector.TabIndex = 54;
            this.btnAgregarSector.Text = "Agregar sector";
            this.btnAgregarSector.UseVisualStyleBackColor = false;
            this.btnAgregarSector.Click += new System.EventHandler(this.btnAgregarSector_Click);
            // 
            // btnEliminarSector
            // 
            this.btnEliminarSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEliminarSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSector.FlatAppearance.BorderSize = 0;
            this.btnEliminarSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSector.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSector.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSector.Location = new System.Drawing.Point(73, 389);
            this.btnEliminarSector.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnEliminarSector.Name = "btnEliminarSector";
            this.btnEliminarSector.Size = new System.Drawing.Size(194, 36);
            this.btnEliminarSector.TabIndex = 55;
            this.btnEliminarSector.Text = "Eliminar sector";
            this.btnEliminarSector.UseVisualStyleBackColor = false;
            this.btnEliminarSector.Click += new System.EventHandler(this.btnEliminarSector_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(201, 449);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 34);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "EN DUDA ";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(12, 218);
            this.dtpFechaHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(283, 26);
            this.dtpFechaHora.TabIndex = 58;
            // 
            // btnModificarSector
            // 
            this.btnModificarSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnModificarSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarSector.FlatAppearance.BorderSize = 0;
            this.btnModificarSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSector.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSector.ForeColor = System.Drawing.Color.White;
            this.btnModificarSector.Location = new System.Drawing.Point(73, 333);
            this.btnModificarSector.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnModificarSector.Name = "btnModificarSector";
            this.btnModificarSector.Size = new System.Drawing.Size(194, 36);
            this.btnModificarSector.TabIndex = 59;
            this.btnModificarSector.Text = "Modificar sector";
            this.btnModificarSector.UseVisualStyleBackColor = false;
            this.btnModificarSector.Click += new System.EventHandler(this.btnModificarSector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(523, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 60);
            this.label2.TabIndex = 60;
            this.label2.Text = "Sectores";
            // 
            // frmModificarSectoresEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarSector);
            this.Controls.Add(this.dtpFechaHora);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminarSector);
            this.Controls.Add(this.btnAgregarSector);
            this.Controls.Add(this.dgvSectores);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmModificarSectoresEventos";
            this.Text = "frmVolver";
            this.Load += new System.EventHandler(this.frmAgregarEventoLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvSectores;
        private System.Windows.Forms.Button btnAgregarSector;
        private System.Windows.Forms.Button btnEliminarSector;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Button btnModificarSector;
        private System.Windows.Forms.Label label2;
    }
}