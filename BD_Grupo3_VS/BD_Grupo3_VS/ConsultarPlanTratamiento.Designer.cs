namespace BD_Grupo3_VS
{
    partial class ConsultarPlanTratamiento
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
            this.components = new System.ComponentModel.Container();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_AsignaCita = new System.Windows.Forms.Button();
            this.BTN_AsignaPlanEjercicios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(143, 40);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(471, 33);
            this.LBL_Titulo.TabIndex = 2;
            this.LBL_Titulo.Text = "Consulta de Planes de Tratamiento";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(25, 123);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 3;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_Cedula.Location = new System.Drawing.Point(74, 120);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(133, 20);
            this.TXT_Cedula.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula a consultar");
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(303, 120);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(133, 20);
            this.TXT_Padecimiento.TabIndex = 6;
            this.toolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento a consultar");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(223, 123);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 5;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 280);
            this.dataGridView1.TabIndex = 7;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_de_Tratamiento_Buscar;
            this.BTN_Buscar.Location = new System.Drawing.Point(459, 81);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(82, 74);
            this.BTN_Buscar.TabIndex = 8;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 48;
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
            // BTN_AsignaCita
            // 
            this.BTN_AsignaCita.Image = global::BD_Grupo3_VS.Properties.Resources.Cita_Nueva;
            this.BTN_AsignaCita.Location = new System.Drawing.Point(559, 81);
            this.BTN_AsignaCita.Name = "BTN_AsignaCita";
            this.BTN_AsignaCita.Size = new System.Drawing.Size(82, 74);
            this.BTN_AsignaCita.TabIndex = 49;
            this.BTN_AsignaCita.Text = "Asignar Cita";
            this.BTN_AsignaCita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_AsignaCita.UseVisualStyleBackColor = true;
            this.BTN_AsignaCita.Click += new System.EventHandler(this.BTN_AsignaCita_Click);
            // 
            // BTN_AsignaPlanEjercicios
            // 
            this.BTN_AsignaPlanEjercicios.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_Ejercicio_Nuevo;
            this.BTN_AsignaPlanEjercicios.Location = new System.Drawing.Point(657, 81);
            this.BTN_AsignaPlanEjercicios.Name = "BTN_AsignaPlanEjercicios";
            this.BTN_AsignaPlanEjercicios.Size = new System.Drawing.Size(82, 74);
            this.BTN_AsignaPlanEjercicios.TabIndex = 50;
            this.BTN_AsignaPlanEjercicios.Text = "Plan Ejercicios";
            this.BTN_AsignaPlanEjercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_AsignaPlanEjercicios.UseVisualStyleBackColor = true;
            this.BTN_AsignaPlanEjercicios.Click += new System.EventHandler(this.BTN_AsignaPlanEjercicios_Click);
            // 
            // ConsultarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 470);
            this.Controls.Add(this.BTN_AsignaPlanEjercicios);
            this.Controls.Add(this.BTN_AsignaCita);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_Padecimiento);
            this.Controls.Add(this.LBL_Padecimiento);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LBL_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultarPlanTratamiento";
            this.Text = "ConsultarPlanTratamiento";
            this.Load += new System.EventHandler(this.ConsultarPlanTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BTN_AsignaCita;
        private System.Windows.Forms.Button BTN_AsignaPlanEjercicios;
    }
}