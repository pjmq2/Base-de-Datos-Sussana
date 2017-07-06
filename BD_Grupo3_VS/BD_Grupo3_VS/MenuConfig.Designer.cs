namespace BD_Grupo3_VS
{
    partial class MenuConfig
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
            this.BTN_CrearTecnica = new System.Windows.Forms.Button();
            this.BTN_CrearMaterial = new System.Windows.Forms.Button();
            this.BTN_CrearAntecediente = new System.Windows.Forms.Button();
            this.BTN_CrearEjercicio = new System.Windows.Forms.Button();
            this.BTN_BuscarEjercicio = new System.Windows.Forms.Button();
            this.BTN_BuscarAntecediente = new System.Windows.Forms.Button();
            this.BTN_BuscarMaterial = new System.Windows.Forms.Button();
            this.BTN_BuscarTecnica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CrearTecnica
            // 
            this.BTN_CrearTecnica.Location = new System.Drawing.Point(34, 60);
            this.BTN_CrearTecnica.Name = "BTN_CrearTecnica";
            this.BTN_CrearTecnica.Size = new System.Drawing.Size(147, 91);
            this.BTN_CrearTecnica.TabIndex = 0;
            this.BTN_CrearTecnica.Text = "Crear Técnica";
            this.BTN_CrearTecnica.UseVisualStyleBackColor = true;
            // 
            // BTN_CrearMaterial
            // 
            this.BTN_CrearMaterial.Location = new System.Drawing.Point(34, 157);
            this.BTN_CrearMaterial.Name = "BTN_CrearMaterial";
            this.BTN_CrearMaterial.Size = new System.Drawing.Size(147, 91);
            this.BTN_CrearMaterial.TabIndex = 1;
            this.BTN_CrearMaterial.Text = "Crear Material";
            this.BTN_CrearMaterial.UseVisualStyleBackColor = true;
            // 
            // BTN_CrearAntecediente
            // 
            this.BTN_CrearAntecediente.Location = new System.Drawing.Point(34, 254);
            this.BTN_CrearAntecediente.Name = "BTN_CrearAntecediente";
            this.BTN_CrearAntecediente.Size = new System.Drawing.Size(147, 91);
            this.BTN_CrearAntecediente.TabIndex = 2;
            this.BTN_CrearAntecediente.Text = "Crear Antecediente";
            this.BTN_CrearAntecediente.UseVisualStyleBackColor = true;
            // 
            // BTN_CrearEjercicio
            // 
            this.BTN_CrearEjercicio.Location = new System.Drawing.Point(34, 351);
            this.BTN_CrearEjercicio.Name = "BTN_CrearEjercicio";
            this.BTN_CrearEjercicio.Size = new System.Drawing.Size(147, 91);
            this.BTN_CrearEjercicio.TabIndex = 3;
            this.BTN_CrearEjercicio.Text = "Crear Ejercicio";
            this.BTN_CrearEjercicio.UseVisualStyleBackColor = true;
            this.BTN_CrearEjercicio.Click += new System.EventHandler(this.BTN_CrearEjercicio_Click);
            // 
            // BTN_BuscarEjercicio
            // 
            this.BTN_BuscarEjercicio.Location = new System.Drawing.Point(246, 351);
            this.BTN_BuscarEjercicio.Name = "BTN_BuscarEjercicio";
            this.BTN_BuscarEjercicio.Size = new System.Drawing.Size(147, 91);
            this.BTN_BuscarEjercicio.TabIndex = 7;
            this.BTN_BuscarEjercicio.Text = "Buscar Ejercicio";
            this.BTN_BuscarEjercicio.UseVisualStyleBackColor = true;
            this.BTN_BuscarEjercicio.Click += new System.EventHandler(this.BTN_BuscarEjercicio_Click);
            // 
            // BTN_BuscarAntecediente
            // 
            this.BTN_BuscarAntecediente.Location = new System.Drawing.Point(246, 254);
            this.BTN_BuscarAntecediente.Name = "BTN_BuscarAntecediente";
            this.BTN_BuscarAntecediente.Size = new System.Drawing.Size(147, 91);
            this.BTN_BuscarAntecediente.TabIndex = 6;
            this.BTN_BuscarAntecediente.Text = "Buscar Antecediente";
            this.BTN_BuscarAntecediente.UseVisualStyleBackColor = true;
            // 
            // BTN_BuscarMaterial
            // 
            this.BTN_BuscarMaterial.Location = new System.Drawing.Point(246, 157);
            this.BTN_BuscarMaterial.Name = "BTN_BuscarMaterial";
            this.BTN_BuscarMaterial.Size = new System.Drawing.Size(147, 91);
            this.BTN_BuscarMaterial.TabIndex = 5;
            this.BTN_BuscarMaterial.Text = "Buscar Material";
            this.BTN_BuscarMaterial.UseVisualStyleBackColor = true;
            this.BTN_BuscarMaterial.Click += new System.EventHandler(this.BTN_BuscarMaterial_Click);
            // 
            // BTN_BuscarTecnica
            // 
            this.BTN_BuscarTecnica.Location = new System.Drawing.Point(246, 60);
            this.BTN_BuscarTecnica.Name = "BTN_BuscarTecnica";
            this.BTN_BuscarTecnica.Size = new System.Drawing.Size(147, 91);
            this.BTN_BuscarTecnica.TabIndex = 4;
            this.BTN_BuscarTecnica.Text = "Buscar Técnica";
            this.BTN_BuscarTecnica.UseVisualStyleBackColor = true;
            // 
            // MenuConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 477);
            this.Controls.Add(this.BTN_BuscarEjercicio);
            this.Controls.Add(this.BTN_BuscarAntecediente);
            this.Controls.Add(this.BTN_BuscarMaterial);
            this.Controls.Add(this.BTN_BuscarTecnica);
            this.Controls.Add(this.BTN_CrearEjercicio);
            this.Controls.Add(this.BTN_CrearAntecediente);
            this.Controls.Add(this.BTN_CrearMaterial);
            this.Controls.Add(this.BTN_CrearTecnica);
            this.Name = "MenuConfig";
            this.Text = "MenuConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CrearTecnica;
        private System.Windows.Forms.Button BTN_CrearMaterial;
        private System.Windows.Forms.Button BTN_CrearAntecediente;
        private System.Windows.Forms.Button BTN_CrearEjercicio;
        private System.Windows.Forms.Button BTN_BuscarEjercicio;
        private System.Windows.Forms.Button BTN_BuscarAntecediente;
        private System.Windows.Forms.Button BTN_BuscarMaterial;
        private System.Windows.Forms.Button BTN_BuscarTecnica;
    }
}