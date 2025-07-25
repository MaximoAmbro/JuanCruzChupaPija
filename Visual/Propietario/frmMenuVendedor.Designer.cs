namespace Visual
{
    partial class frmMenuVendedor
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblvolver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarLocal = new System.Windows.Forms.Button();
            this.btnMisLocales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblNombre.Location = new System.Drawing.Point(255, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(214, 50);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "[USUARIO]";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvolver
            // 
            this.lblvolver.AutoSize = true;
            this.lblvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblvolver.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblvolver.Location = new System.Drawing.Point(171, 391);
            this.lblvolver.Name = "lblvolver";
            this.lblvolver.Size = new System.Drawing.Size(189, 28);
            this.lblvolver.TabIndex = 37;
            this.lblvolver.Text = "VOLVER AL INICIO ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 50);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bienvenido ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarLocal
            // 
            this.btnRegistrarLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegistrarLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarLocal.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarLocal.Location = new System.Drawing.Point(110, 267);
            this.btnRegistrarLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarLocal.Name = "btnRegistrarLocal";
            this.btnRegistrarLocal.Size = new System.Drawing.Size(309, 89);
            this.btnRegistrarLocal.TabIndex = 35;
            this.btnRegistrarLocal.Text = "Registrar local";
            this.btnRegistrarLocal.UseVisualStyleBackColor = false;
            this.btnRegistrarLocal.Click += new System.EventHandler(this.btnRegistrarLocal_Click);
            // 
            // btnMisLocales
            // 
            this.btnMisLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnMisLocales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisLocales.ForeColor = System.Drawing.Color.White;
            this.btnMisLocales.Location = new System.Drawing.Point(110, 145);
            this.btnMisLocales.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisLocales.Name = "btnMisLocales";
            this.btnMisLocales.Size = new System.Drawing.Size(309, 90);
            this.btnMisLocales.TabIndex = 34;
            this.btnMisLocales.Text = "Mis locales";
            this.btnMisLocales.UseVisualStyleBackColor = false;
            this.btnMisLocales.Click += new System.EventHandler(this.btnMisLocales_Click);
            // 
            // frmMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 469);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarLocal);
            this.Controls.Add(this.btnMisLocales);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblvolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarLocal;
        private System.Windows.Forms.Button btnMisLocales;
    }
}