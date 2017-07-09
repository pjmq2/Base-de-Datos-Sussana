namespace BD_Grupo3_VS
{
    partial class AgregarPlanTratamiento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GB_PlanTrata = new System.Windows.Forms.GroupBox();
            this.BTN_VerPlanes = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Observaciones = new System.Windows.Forms.TextBox();
            this.LBL_Observaciones = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GB_PlanTrata.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_PlanTrata
            // 
            this.GB_PlanTrata.Controls.Add(this.BTN_VerPlanes);
            this.GB_PlanTrata.Controls.Add(this.BTN_Agregar);
            this.GB_PlanTrata.Controls.Add(this.TXT_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.LBL_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.TXT_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.LBL_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.TXT_Cedula);
            this.GB_PlanTrata.Controls.Add(this.LBL_Cedula);
            this.GB_PlanTrata.Location = new System.Drawing.Point(47, 89);
            this.GB_PlanTrata.Name = "GB_PlanTrata";
            this.GB_PlanTrata.Size = new System.Drawing.Size(609, 317);
            this.GB_PlanTrata.TabIndex = 0;
            this.GB_PlanTrata.TabStop = false;
            this.GB_PlanTrata.Text = "Agregar Plan de Tratamiento";
            // 
            // BTN_VerPlanes
            // 
            this.BTN_VerPlanes.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_de_Tratamiento_Buscar;
            this.BTN_VerPlanes.Location = new System.Drawing.Point(489, 217);
            this.BTN_VerPlanes.Name = "BTN_VerPlanes";
            this.BTN_VerPlanes.Size = new System.Drawing.Size(100, 82);
            this.BTN_VerPlanes.TabIndex = 7;
            this.BTN_VerPlanes.Text = "Ver Planes";
            this.BTN_VerPlanes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_VerPlanes.UseVisualStyleBackColor = true;
            this.BTN_VerPlanes.Click += new System.EventHandler(this.BTN_VerPlanes_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_de_Tratamiento_Nuevo;
            this.BTN_Agregar.Location = new System.Drawing.Point(383, 217);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(100, 82);
            this.BTN_Agregar.TabIndex = 6;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Observaciones
            // 
            this.TXT_Observaciones.Location = new System.Drawing.Point(109, 213);
            this.TXT_Observaciones.Name = "TXT_Observaciones";
            this.TXT_Observaciones.Size = new System.Drawing.Size(154, 20);
            this.TXT_Observaciones.TabIndex = 5;
            this.toolTip1.SetToolTip(this.TXT_Observaciones, "Digite las observaciones asociadas al plan de tratamiento");
            // 
            // LBL_Observaciones
            // 
            this.LBL_Observaciones.AutoSize = true;
            this.LBL_Observaciones.Location = new System.Drawing.Point(12, 217);
            this.LBL_Observaciones.Name = "LBL_Observaciones";
            this.LBL_Observaciones.Size = new System.Drawing.Size(81, 13);
            this.LBL_Observaciones.TabIndex = 4;
            this.LBL_Observaciones.Text = "Observaciones:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(109, 142);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(154, 20);
            this.TXT_Padecimiento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento actual del paciente");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(12, 145);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 2;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(109, 62);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula del paciente");
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(12, 65);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 0;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(202, 40);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(277, 33);
            this.LBL_Titulo.TabIndex = 3;
            this.LBL_Titulo.Text = "Plan de Tratamiento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioToolStripMenuItem,
            this.buscarPacienteToolStripMenuItem,
            this.crearPacienteToolStripMenuItem,
            this.avanzadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.InicioToolStripMenuItem.Text = "Inicio";
            this.InicioToolStripMenuItem.Click += new System.EventHandler(this.InicioToolStripMenuItem_Click_1);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click_1);
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            this.crearPacienteToolStripMenuItem.Click += new System.EventHandler(this.crearPacienteToolStripMenuItem_Click_1);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            this.avanzadoToolStripMenuItem.Click += new System.EventHandler(this.avanzadoToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AgregarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 433);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.GB_PlanTrata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarPlanTratamiento";
            this.Text = "AgregarPlanTratamiento";
            this.Load += new System.EventHandler(this.AgregarPlanTratamiento_Load);
            this.GB_PlanTrata.ResumeLayout(false);
            this.GB_PlanTrata.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_PlanTrata;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Observaciones;
        private System.Windows.Forms.Label LBL_Observaciones;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BTN_VerPlanes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

