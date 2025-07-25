namespace Visual.Propietario
{
    partial class frmAgregarEventoo
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.Label();
            this.dtEvento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(441, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(469, 274);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 29);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "button1";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(321, 278);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(51, 20);
            this.lblVolver.TabIndex = 5;
            this.lblVolver.Text = "label3";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            // 
            // dtEvento
            // 
            this.dtEvento.Location = new System.Drawing.Point(403, 176);
            this.dtEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEvento.Name = "dtEvento";
            this.dtEvento.Size = new System.Drawing.Size(224, 26);
            this.dtEvento.TabIndex = 6;
            // 
            // frmAgregarEventoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 562);
            this.Controls.Add(this.dtEvento);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAgregarEventoo";
            this.Text = "frmAgregarEventoo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.DateTimePicker dtEvento;
    }
}