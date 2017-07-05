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
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_inicioDeSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_inicioDeSesion
            // 
            this.GB_inicioDeSesion.Controls.Add(this.bAceptar);
            this.GB_inicioDeSesion.Controls.Add(this.tbUsuario);
            this.GB_inicioDeSesion.Controls.Add(this.tbContraseña);
            this.GB_inicioDeSesion.Controls.Add(this.lContraseña);
            this.GB_inicioDeSesion.Controls.Add(this.lUsuario);
            this.GB_inicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_inicioDeSesion.Location = new System.Drawing.Point(53, 37);
            this.GB_inicioDeSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_inicioDeSesion.Name = "GB_inicioDeSesion";
            this.GB_inicioDeSesion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_inicioDeSesion.Size = new System.Drawing.Size(400, 246);
            this.GB_inicioDeSesion.TabIndex = 0;
            this.GB_inicioDeSesion.TabStop = false;
            this.GB_inicioDeSesion.Text = "Inicio de sesión";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(257, 176);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(100, 28);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(135, 52);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(221, 26);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(135, 112);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(221, 26);
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(20, 113);
            this.lContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(100, 20);
            this.lContraseña.TabIndex = 2;
            this.lContraseña.Text = "Contraseña:";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(20, 53);
            this.lUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(72, 20);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Usuario:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.GB_inicioDeSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.GB_inicioDeSesion.ResumeLayout(false);
            this.GB_inicioDeSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_inicioDeSesion;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button bAceptar;
    }
}