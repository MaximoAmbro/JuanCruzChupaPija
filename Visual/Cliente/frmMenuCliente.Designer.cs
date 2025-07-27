namespace Visual
{
    partial class frmMenuCliente
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
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvolver = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Location = new System.Drawing.Point(80, 298);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(309, 94);
            this.btnEventos.TabIndex = 5;
            this.btnEventos.Text = "Eventos disponibles";
            this.btnEventos.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(80, 451);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(309, 92);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "Mis eventos";
            this.btnHistorial.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(99, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 60);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bienvenido ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvolver
            // 
            this.lblvolver.AutoSize = true;
            this.lblvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblvolver.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblvolver.Location = new System.Drawing.Point(152, 609);
            this.lblvolver.Name = "lblvolver";
            this.lblvolver.Size = new System.Drawing.Size(153, 28);
            this.lblvolver.TabIndex = 32;
            this.lblvolver.Text = "Volver al inicio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblNombre.Location = new System.Drawing.Point(99, 144);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(252, 60);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "[USUARIO]";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 714);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEventos);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvolver;
        private System.Windows.Forms.Label lblNombre;
    }
}