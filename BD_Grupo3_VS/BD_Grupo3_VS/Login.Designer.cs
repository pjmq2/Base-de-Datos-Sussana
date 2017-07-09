namespace BD_Grupo3_VS
{
    partial class Login
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
            this.GB_inicioDeSesion = new System.Windows.Forms.GroupBox();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_inicioDeSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_inicioDeSesion
            // 
            this.GB_inicioDeSesion.Controls.Add(this.BTN_Aceptar);
            this.GB_inicioDeSesion.Controls.Add(this.TXT_Usuario);
            this.GB_inicioDeSesion.Controls.Add(this.TXT_Password);
            this.GB_inicioDeSesion.Controls.Add(this.lContraseña);
            this.GB_inicioDeSesion.Controls.Add(this.lUsuario);
            this.GB_inicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_inicioDeSesion.Location = new System.Drawing.Point(40, 30);
            this.GB_inicioDeSesion.Name = "GB_inicioDeSesion";
            this.GB_inicioDeSesion.Size = new System.Drawing.Size(300, 200);
            this.GB_inicioDeSesion.TabIndex = 0;
            this.GB_inicioDeSesion.TabStop = false;
            this.GB_inicioDeSesion.Text = "Inicio de sesión";
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.Enabled = false;
            this.BTN_Aceptar.Location = new System.Drawing.Point(193, 143);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Aceptar.TabIndex = 3;
            this.BTN_Aceptar.Text = "Aceptar";
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            this.BTN_Aceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(101, 42);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(167, 22);
            this.TXT_Usuario.TabIndex = 1;
            this.TXT_Usuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // TXT_Password
            // 
            this.TXT_Password.Location = new System.Drawing.Point(101, 91);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.Size = new System.Drawing.Size(167, 22);
            this.TXT_Password.TabIndex = 2;
            this.TXT_Password.UseSystemPasswordChar = true;
            this.TXT_Password.TextChanged += new System.EventHandler(this.TXT_Password_TextChanged);
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(15, 92);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(80, 16);
            this.lContraseña.TabIndex = 2;
            this.lContraseña.Text = "Contraseña:";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(15, 43);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(58, 16);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Usuario:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.GB_inicioDeSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.GB_inicioDeSesion.ResumeLayout(false);
            this.GB_inicioDeSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_inicioDeSesion;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Button BTN_Aceptar;
    }
}