namespace BD_Grupo3_VS
{
    partial class AgregarPlanEjercicios
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
            this.GB_AgregarCita = new System.Windows.Forms.GroupBox();
            this.TXT_Objetivos = new System.Windows.Forms.TextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LBL_Objetivos = new System.Windows.Forms.Label();
            this.TXT_Nivel = new System.Windows.Forms.TextBox();
            this.LBL_Nivel = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LBL_PlanEjercicios = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_AgregarCita.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_AgregarCita
            // 
            this.GB_AgregarCita.Controls.Add(this.TXT_Objetivos);
            this.GB_AgregarCita.Controls.Add(this.BTN_Agregar);
            this.GB_AgregarCita.Controls.Add(this.LBL_Objetivos);
            this.GB_AgregarCita.Controls.Add(this.TXT_Nivel);
            this.GB_AgregarCita.Controls.Add(this.LBL_Nivel);
            this.GB_AgregarCita.Controls.Add(this.TXT_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.TXT_Cedula);
            this.GB_AgregarCita.Controls.Add(this.LBL_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.LBL_Cedula);
            this.GB_AgregarCita.Location = new System.Drawing.Point(10, 93);
            this.GB_AgregarCita.Name = "GB_AgregarCita";
            this.GB_AgregarCita.Size = new System.Drawing.Size(422, 281);
            this.GB_AgregarCita.TabIndex = 11;
            this.GB_AgregarCita.TabStop = false;
            this.GB_AgregarCita.Text = "Información del Plan de Ejercicios";
            // 
            // TXT_Objetivos
            // 
            this.TXT_Objetivos.Location = new System.Drawing.Point(91, 132);
            this.TXT_Objetivos.Multiline = true;
            this.TXT_Objetivos.Name = "TXT_Objetivos";
            this.TXT_Objetivos.Size = new System.Drawing.Size(267, 95);
            this.TXT_Objetivos.TabIndex = 17;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(274, 233);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(84, 42);
            this.BTN_Agregar.TabIndex = 16;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // LBL_Objetivos
            // 
            this.LBL_Objetivos.AutoSize = true;
            this.LBL_Objetivos.Location = new System.Drawing.Point(12, 124);
            this.LBL_Objetivos.Name = "LBL_Objetivos";
            this.LBL_Objetivos.Size = new System.Drawing.Size(54, 13);
            this.LBL_Objetivos.TabIndex = 8;
            this.LBL_Objetivos.Text = "Objetivos:";
            // 
            // TXT_Nivel
            // 
            this.TXT_Nivel.Location = new System.Drawing.Point(91, 99);
            this.TXT_Nivel.Name = "TXT_Nivel";
            this.TXT_Nivel.Size = new System.Drawing.Size(267, 20);
            this.TXT_Nivel.TabIndex = 7;
            // 
            // LBL_Nivel
            // 
            this.LBL_Nivel.AutoSize = true;
            this.LBL_Nivel.Location = new System.Drawing.Point(12, 99);
            this.LBL_Nivel.Name = "LBL_Nivel";
            this.LBL_Nivel.Size = new System.Drawing.Size(31, 13);
            this.LBL_Nivel.TabIndex = 6;
            this.LBL_Nivel.Text = "Nivel";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(91, 64);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(267, 20);
            this.TXT_Padecimiento.TabIndex = 3;
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(91, 30);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(267, 20);
            this.TXT_Cedula.TabIndex = 2;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(12, 64);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 1;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(12, 30);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 0;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LBL_PlanEjercicios
            // 
            this.LBL_PlanEjercicios.AutoSize = true;
            this.LBL_PlanEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PlanEjercicios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_PlanEjercicios.Location = new System.Drawing.Point(95, 38);
            this.LBL_PlanEjercicios.Name = "LBL_PlanEjercicios";
            this.LBL_PlanEjercicios.Size = new System.Drawing.Size(248, 33);
            this.LBL_PlanEjercicios.TabIndex = 18;
            this.LBL_PlanEjercicios.Text = "Plan de Ejercicios";
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
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.InicioToolStripMenuItem.Text = "Inicio";
            this.InicioToolStripMenuItem.Click += new System.EventHandler(this.InicioToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            this.crearPacienteToolStripMenuItem.Click += new System.EventHandler(this.crearPacienteToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            this.avanzadoToolStripMenuItem.Click += new System.EventHandler(this.avanzadoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AgregarPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 384);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_PlanEjercicios);
            this.Controls.Add(this.GB_AgregarCita);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarPlanEjercicios";
            this.Text = "AgregarPlanEjercicios";
            this.Load += new System.EventHandler(this.AgregarPlanEjercicios_Load);
            this.GB_AgregarCita.ResumeLayout(false);
            this.GB_AgregarCita.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_AgregarCita;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label LBL_Objetivos;
        private System.Windows.Forms.TextBox TXT_Nivel;
        private System.Windows.Forms.Label LBL_Nivel;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.Label LBL_PlanEjercicios;
        private System.Windows.Forms.TextBox TXT_Objetivos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}