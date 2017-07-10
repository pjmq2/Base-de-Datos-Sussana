namespace BD_Grupo3_VS
{
    partial class AgregarUsuario
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
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.TXT_Contraseña = new System.Windows.Forms.TextBox();
            this.GB_inicioDeSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_inicioDeSesion
            // 
            this.GB_inicioDeSesion.Controls.Add(this.TXT_Contraseña);
            this.GB_inicioDeSesion.Controls.Add(this.BTN_Agregar);
            this.GB_inicioDeSesion.Controls.Add(this.TXT_Usuario);
            this.GB_inicioDeSesion.Controls.Add(this.lContraseña);
            this.GB_inicioDeSesion.Controls.Add(this.lUsuario);
            this.GB_inicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_inicioDeSesion.Location = new System.Drawing.Point(37, 55);
            this.GB_inicioDeSesion.Name = "GB_inicioDeSesion";
            this.GB_inicioDeSesion.Size = new System.Drawing.Size(300, 200);
            this.GB_inicioDeSesion.TabIndex = 1;
            this.GB_inicioDeSesion.TabStop = false;
            this.GB_inicioDeSesion.Text = "Agregar un usuario y contraseña nueva";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(193, 143);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(75, 29);
            this.BTN_Agregar.TabIndex = 3;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(101, 42);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(167, 22);
            this.TXT_Usuario.TabIndex = 1;
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
            // TXT_Contraseña
            // 
            this.TXT_Contraseña.Location = new System.Drawing.Point(101, 92);
            this.TXT_Contraseña.Name = "TXT_Contraseña";
            this.TXT_Contraseña.Size = new System.Drawing.Size(167, 22);
            this.TXT_Contraseña.TabIndex = 4;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 310);
            this.Controls.Add(this.GB_inicioDeSesion);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.GB_inicioDeSesion.ResumeLayout(false);
            this.GB_inicioDeSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_inicioDeSesion;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.TextBox TXT_Contraseña;
    }
}