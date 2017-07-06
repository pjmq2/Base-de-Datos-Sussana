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
            this.GB_PlanTrata = new System.Windows.Forms.GroupBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Observaciones = new System.Windows.Forms.TextBox();
            this.LBL_Observaciones = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_ListaTrata = new System.Windows.Forms.LinkLabel();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_PlanTrata.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_PlanTrata
            // 
            this.GB_PlanTrata.Controls.Add(this.BTN_Agregar);
            this.GB_PlanTrata.Controls.Add(this.TXT_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.LBL_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.TXT_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.LBL_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.TXT_Cedula);
            this.GB_PlanTrata.Controls.Add(this.LBL_Cedula);
            this.GB_PlanTrata.Location = new System.Drawing.Point(63, 110);
            this.GB_PlanTrata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_PlanTrata.Name = "GB_PlanTrata";
            this.GB_PlanTrata.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_PlanTrata.Size = new System.Drawing.Size(812, 390);
            this.GB_PlanTrata.TabIndex = 0;
            this.GB_PlanTrata.TabStop = false;
            this.GB_PlanTrata.Text = "Agregar Plan de Tratamiento";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(660, 321);
            this.BTN_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(131, 48);
            this.BTN_Agregar.TabIndex = 6;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Observaciones
            // 
            this.TXT_Observaciones.Location = new System.Drawing.Point(145, 262);
            this.TXT_Observaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Observaciones.Name = "TXT_Observaciones";
            this.TXT_Observaciones.Size = new System.Drawing.Size(204, 22);
            this.TXT_Observaciones.TabIndex = 5;
            // 
            // LBL_Observaciones
            // 
            this.LBL_Observaciones.AutoSize = true;
            this.LBL_Observaciones.Location = new System.Drawing.Point(16, 267);
            this.LBL_Observaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Observaciones.Name = "LBL_Observaciones";
            this.LBL_Observaciones.Size = new System.Drawing.Size(107, 17);
            this.LBL_Observaciones.TabIndex = 4;
            this.LBL_Observaciones.Text = "Observaciones:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(145, 175);
            this.TXT_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(204, 22);
            this.TXT_Padecimiento.TabIndex = 3;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(16, 178);
            this.LBL_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(97, 17);
            this.LBL_Padecimiento.TabIndex = 2;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(145, 76);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(204, 22);
            this.TXT_Cedula.TabIndex = 1;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(16, 80);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 0;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(819, 34);
            this.LINK_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(117, 17);
            this.LINK_Menu.TabIndex = 1;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Al Menú Principal";
            // 
            // LINK_ListaTrata
            // 
            this.LINK_ListaTrata.AutoSize = true;
            this.LINK_ListaTrata.Location = new System.Drawing.Point(733, 74);
            this.LINK_ListaTrata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_ListaTrata.Name = "LINK_ListaTrata";
            this.LINK_ListaTrata.Size = new System.Drawing.Size(205, 17);
            this.LINK_ListaTrata.TabIndex = 2;
            this.LINK_ListaTrata.TabStop = true;
            this.LINK_ListaTrata.Text = "Lista de Planes de Tratamiento";
            this.LINK_ListaTrata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_ListaTrata_LinkClicked);
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(270, 49);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(353, 42);
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
            this.menuStrip1.Size = new System.Drawing.Size(955, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.InicioToolStripMenuItem.Text = "Inicio";
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AgregarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 533);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.LINK_ListaTrata);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.GB_PlanTrata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.LinkLabel LINK_ListaTrata;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

