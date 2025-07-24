namespace Visual
{
    partial class frmInicio
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
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbxShowPass = new System.Windows.Forms.CheckBox();
            this.lblolividarcontra = new System.Windows.Forms.Label();
            this.lblcrearcuenta = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(97, 259);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(227, 27);
            this.TxtUsername.TabIndex = 5;
            this.TxtUsername.TabStop = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(97, 367);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(227, 27);
            this.TxtPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // checkbxShowPass
            // 
            this.checkbxShowPass.AutoSize = true;
            this.checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPass.Location = new System.Drawing.Point(248, 405);
            this.checkbxShowPass.Name = "checkbxShowPass";
            this.checkbxShowPass.Size = new System.Drawing.Size(151, 27);
            this.checkbxShowPass.TabIndex = 10;
            this.checkbxShowPass.Text = "Show Password";
            this.checkbxShowPass.UseVisualStyleBackColor = true;
            // 
            // lblolividarcontra
            // 
            this.lblolividarcontra.AutoSize = true;
            this.lblolividarcontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblolividarcontra.Location = new System.Drawing.Point(112, 627);
            this.lblolividarcontra.Name = "lblolividarcontra";
            this.lblolividarcontra.Size = new System.Drawing.Size(212, 23);
            this.lblolividarcontra.TabIndex = 18;
            this.lblolividarcontra.Text = "¿Olvidaste tu contraseña?";
            // 
            // lblcrearcuenta
            // 
            this.lblcrearcuenta.AutoSize = true;
            this.lblcrearcuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcrearcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblcrearcuenta.Location = new System.Drawing.Point(155, 664);
            this.lblcrearcuenta.Name = "lblcrearcuenta";
            this.lblcrearcuenta.Size = new System.Drawing.Size(114, 23);
            this.lblcrearcuenta.TabIndex = 19;
            this.lblcrearcuenta.Text = "Crear Cuenta";
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.FlatAppearance.BorderSize = 0;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(97, 516);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(227, 49);
            this.btninicio.TabIndex = 20;
            this.btninicio.Text = "INICIAR SESION ";
            this.btninicio.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 50);
            this.label2.TabIndex = 22;
            this.label2.Text = "LOGIN";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 21;
            this.lstUsuarios.Location = new System.Drawing.Point(288, 53);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(120, 88);
            this.lstUsuarios.TabIndex = 23;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 734);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lblcrearcuenta);
            this.Controls.Add(this.lblolividarcontra);
            this.Controls.Add(this.checkbxShowPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsername);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkbxShowPass;
        private System.Windows.Forms.Label lblolividarcontra;
        private System.Windows.Forms.Label lblcrearcuenta;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstUsuarios;
    }
}