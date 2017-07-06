namespace BD_Grupo3_VS
{
    partial class MenuPrincipal
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
            this.GB_Paciente = new System.Windows.Forms.GroupBox();
            this.BTN_PacienteBuscar = new System.Windows.Forms.Button();
            this.BTN_NuevoPaciente = new System.Windows.Forms.Button();
            this.BTN_Config = new System.Windows.Forms.Button();
            this.GB_Paciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Paciente
            // 
            this.GB_Paciente.Controls.Add(this.BTN_PacienteBuscar);
            this.GB_Paciente.Controls.Add(this.BTN_NuevoPaciente);
            this.GB_Paciente.Location = new System.Drawing.Point(38, 50);
            this.GB_Paciente.Name = "GB_Paciente";
            this.GB_Paciente.Size = new System.Drawing.Size(282, 238);
            this.GB_Paciente.TabIndex = 0;
            this.GB_Paciente.TabStop = false;
            this.GB_Paciente.Text = "Paciente";
            // 
            // BTN_PacienteBuscar
            // 
            this.BTN_PacienteBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_PacienteBuscar.Image = global::BD_Grupo3_VS.Properties.Resources.Paciente_Modificar;
            this.BTN_PacienteBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_PacienteBuscar.Location = new System.Drawing.Point(155, 44);
            this.BTN_PacienteBuscar.Name = "BTN_PacienteBuscar";
            this.BTN_PacienteBuscar.Size = new System.Drawing.Size(121, 159);
            this.BTN_PacienteBuscar.TabIndex = 1;
            this.BTN_PacienteBuscar.Text = "Buscar Paciente";
            this.BTN_PacienteBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_PacienteBuscar.UseVisualStyleBackColor = true;
            this.BTN_PacienteBuscar.Click += new System.EventHandler(this.BTN_PacienteBuscar_Click);
            // 
            // BTN_NuevoPaciente
            // 
            this.BTN_NuevoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_NuevoPaciente.Image = global::BD_Grupo3_VS.Properties.Resources.Paciente_Nuevo;
            this.BTN_NuevoPaciente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_NuevoPaciente.Location = new System.Drawing.Point(6, 44);
            this.BTN_NuevoPaciente.Name = "BTN_NuevoPaciente";
            this.BTN_NuevoPaciente.Size = new System.Drawing.Size(121, 159);
            this.BTN_NuevoPaciente.TabIndex = 0;
            this.BTN_NuevoPaciente.Text = "Nuevo Paciente";
            this.BTN_NuevoPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_NuevoPaciente.UseVisualStyleBackColor = true;
            this.BTN_NuevoPaciente.Click += new System.EventHandler(this.BTN_NuevoPaciente_Click);
            // 
            // BTN_Config
            // 
            this.BTN_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Config.Location = new System.Drawing.Point(38, 294);
            this.BTN_Config.Name = "BTN_Config";
            this.BTN_Config.Size = new System.Drawing.Size(282, 59);
            this.BTN_Config.TabIndex = 1;
            this.BTN_Config.Text = "Avanzado";
            this.BTN_Config.UseVisualStyleBackColor = true;
            this.BTN_Config.Click += new System.EventHandler(this.BTN_Config_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 398);
            this.Controls.Add(this.BTN_Config);
            this.Controls.Add(this.GB_Paciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "Menú principal";
            this.GB_Paciente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Paciente;
        private System.Windows.Forms.Button BTN_NuevoPaciente;
        private System.Windows.Forms.Button BTN_PacienteBuscar;
        private System.Windows.Forms.Button BTN_Config;
    }
}