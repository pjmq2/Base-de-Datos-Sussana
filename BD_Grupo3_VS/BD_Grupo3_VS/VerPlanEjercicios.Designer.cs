namespace BD_Grupo3_VS
{
    partial class VerPlanEjercicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_InfoPlanEjercicio = new System.Windows.Forms.GroupBox();
            this.LBL_EjerciciosPlan = new System.Windows.Forms.Label();
            this.LBL_Tareas = new System.Windows.Forms.Label();
            this.DGV_Tareas = new System.Windows.Forms.DataGridView();
            this.TXT_Nivel = new System.Windows.Forms.TextBox();
            this.LBL_Nivel = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.GB_TareasPlanEjercicio = new System.Windows.Forms.GroupBox();
            this.LBL_AgregarTarea = new System.Windows.Forms.Label();
            this.BTN_AgregarTarea = new System.Windows.Forms.Button();
            this.TXT_Tarea = new System.Windows.Forms.TextBox();
            this.LBL_Plan = new System.Windows.Forms.Label();
            this.GB_ListaEjercicios = new System.Windows.Forms.GroupBox();
            this.BTN_AgregarEjercicio = new System.Windows.Forms.Button();
            this.DGV_ListaEjerciciosPlan = new System.Windows.Forms.DataGridView();
            this.BTN_EliminarPlan = new System.Windows.Forms.Button();
            this.CB_NombreEjercicio = new System.Windows.Forms.ComboBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Tiempo = new System.Windows.Forms.Label();
            this.LBL_Repeticiones = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_Repeticiones = new System.Windows.Forms.NumericUpDown();
            this.NUD_Tiempo = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.GB_InfoPlanEjercicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tareas)).BeginInit();
            this.GB_TareasPlanEjercicio.SuspendLayout();
            this.GB_ListaEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaEjerciciosPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tiempo)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 48;
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
            // GB_InfoPlanEjercicio
            // 
            this.GB_InfoPlanEjercicio.Controls.Add(this.DGV_ListaEjerciciosPlan);
            this.GB_InfoPlanEjercicio.Controls.Add(this.LBL_EjerciciosPlan);
            this.GB_InfoPlanEjercicio.Controls.Add(this.LBL_Tareas);
            this.GB_InfoPlanEjercicio.Controls.Add(this.DGV_Tareas);
            this.GB_InfoPlanEjercicio.Controls.Add(this.TXT_Nivel);
            this.GB_InfoPlanEjercicio.Controls.Add(this.LBL_Nivel);
            this.GB_InfoPlanEjercicio.Controls.Add(this.TXT_Padecimiento);
            this.GB_InfoPlanEjercicio.Controls.Add(this.LBL_Padecimiento);
            this.GB_InfoPlanEjercicio.Controls.Add(this.TXT_Cedula);
            this.GB_InfoPlanEjercicio.Controls.Add(this.LBL_Cedula);
            this.GB_InfoPlanEjercicio.Location = new System.Drawing.Point(12, 86);
            this.GB_InfoPlanEjercicio.Name = "GB_InfoPlanEjercicio";
            this.GB_InfoPlanEjercicio.Size = new System.Drawing.Size(406, 470);
            this.GB_InfoPlanEjercicio.TabIndex = 49;
            this.GB_InfoPlanEjercicio.TabStop = false;
            this.GB_InfoPlanEjercicio.Text = "Información del Plan de Ejercicio";
            // 
            // LBL_EjerciciosPlan
            // 
            this.LBL_EjerciciosPlan.AutoSize = true;
            this.LBL_EjerciciosPlan.Location = new System.Drawing.Point(18, 267);
            this.LBL_EjerciciosPlan.Name = "LBL_EjerciciosPlan";
            this.LBL_EjerciciosPlan.Size = new System.Drawing.Size(96, 13);
            this.LBL_EjerciciosPlan.TabIndex = 61;
            this.LBL_EjerciciosPlan.Text = "Ejercicios del Plan:";
            // 
            // LBL_Tareas
            // 
            this.LBL_Tareas.AutoSize = true;
            this.LBL_Tareas.Location = new System.Drawing.Point(18, 134);
            this.LBL_Tareas.Name = "LBL_Tareas";
            this.LBL_Tareas.Size = new System.Drawing.Size(43, 13);
            this.LBL_Tareas.TabIndex = 60;
            this.LBL_Tareas.Text = "Tareas:";
            // 
            // DGV_Tareas
            // 
            this.DGV_Tareas.AllowUserToAddRows = false;
            this.DGV_Tareas.AllowUserToDeleteRows = false;
            this.DGV_Tareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DGV_Tareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_Tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tareas.Location = new System.Drawing.Point(21, 150);
            this.DGV_Tareas.MultiSelect = false;
            this.DGV_Tareas.Name = "DGV_Tareas";
            this.DGV_Tareas.ReadOnly = true;
            this.DGV_Tareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tareas.Size = new System.Drawing.Size(215, 86);
            this.DGV_Tareas.TabIndex = 52;
            // 
            // TXT_Nivel
            // 
            this.TXT_Nivel.Location = new System.Drawing.Point(125, 103);
            this.TXT_Nivel.Name = "TXT_Nivel";
            this.TXT_Nivel.ReadOnly = true;
            this.TXT_Nivel.Size = new System.Drawing.Size(117, 20);
            this.TXT_Nivel.TabIndex = 59;
            // 
            // LBL_Nivel
            // 
            this.LBL_Nivel.AutoSize = true;
            this.LBL_Nivel.Location = new System.Drawing.Point(18, 103);
            this.LBL_Nivel.Name = "LBL_Nivel";
            this.LBL_Nivel.Size = new System.Drawing.Size(34, 13);
            this.LBL_Nivel.TabIndex = 58;
            this.LBL_Nivel.Text = "Nivel:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(125, 66);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.ReadOnly = true;
            this.TXT_Padecimiento.Size = new System.Drawing.Size(117, 20);
            this.TXT_Padecimiento.TabIndex = 57;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(18, 69);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 56;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(125, 31);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.ReadOnly = true;
            this.TXT_Cedula.Size = new System.Drawing.Size(117, 20);
            this.TXT_Cedula.TabIndex = 55;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(18, 34);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(88, 13);
            this.LBL_Cedula.TabIndex = 40;
            this.LBL_Cedula.Text = "Cédula Paciente:";
            // 
            // GB_TareasPlanEjercicio
            // 
            this.GB_TareasPlanEjercicio.Controls.Add(this.LBL_AgregarTarea);
            this.GB_TareasPlanEjercicio.Controls.Add(this.BTN_AgregarTarea);
            this.GB_TareasPlanEjercicio.Controls.Add(this.TXT_Tarea);
            this.GB_TareasPlanEjercicio.Location = new System.Drawing.Point(424, 98);
            this.GB_TareasPlanEjercicio.Name = "GB_TareasPlanEjercicio";
            this.GB_TareasPlanEjercicio.Size = new System.Drawing.Size(250, 153);
            this.GB_TareasPlanEjercicio.TabIndex = 50;
            this.GB_TareasPlanEjercicio.TabStop = false;
            this.GB_TareasPlanEjercicio.Text = "Agregar Tareas al Plan de Ejercicio";
            // 
            // LBL_AgregarTarea
            // 
            this.LBL_AgregarTarea.AutoSize = true;
            this.LBL_AgregarTarea.Location = new System.Drawing.Point(17, 31);
            this.LBL_AgregarTarea.Name = "LBL_AgregarTarea";
            this.LBL_AgregarTarea.Size = new System.Drawing.Size(180, 13);
            this.LBL_AgregarTarea.TabIndex = 2;
            this.LBL_AgregarTarea.Text = "Por favor agregue una tarea a la vez";
            // 
            // BTN_AgregarTarea
            // 
            this.BTN_AgregarTarea.Location = new System.Drawing.Point(146, 111);
            this.BTN_AgregarTarea.Name = "BTN_AgregarTarea";
            this.BTN_AgregarTarea.Size = new System.Drawing.Size(83, 36);
            this.BTN_AgregarTarea.TabIndex = 1;
            this.BTN_AgregarTarea.Text = "Agregar";
            this.BTN_AgregarTarea.UseVisualStyleBackColor = true;
            this.BTN_AgregarTarea.Click += new System.EventHandler(this.BTN_AgregarTarea_Click);
            // 
            // TXT_Tarea
            // 
            this.TXT_Tarea.Location = new System.Drawing.Point(47, 60);
            this.TXT_Tarea.Multiline = true;
            this.TXT_Tarea.Name = "TXT_Tarea";
            this.TXT_Tarea.Size = new System.Drawing.Size(182, 45);
            this.TXT_Tarea.TabIndex = 0;
            // 
            // LBL_Plan
            // 
            this.LBL_Plan.AutoSize = true;
            this.LBL_Plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Plan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Plan.Location = new System.Drawing.Point(182, 38);
            this.LBL_Plan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Plan.Name = "LBL_Plan";
            this.LBL_Plan.Size = new System.Drawing.Size(215, 31);
            this.LBL_Plan.TabIndex = 51;
            this.LBL_Plan.Text = "Plan de Ejercicio";
            // 
            // GB_ListaEjercicios
            // 
            this.GB_ListaEjercicios.Controls.Add(this.NUD_Tiempo);
            this.GB_ListaEjercicios.Controls.Add(this.NUD_Repeticiones);
            this.GB_ListaEjercicios.Controls.Add(this.label6);
            this.GB_ListaEjercicios.Controls.Add(this.LBL_Repeticiones);
            this.GB_ListaEjercicios.Controls.Add(this.LBL_Tiempo);
            this.GB_ListaEjercicios.Controls.Add(this.LBL_Nombre);
            this.GB_ListaEjercicios.Controls.Add(this.CB_NombreEjercicio);
            this.GB_ListaEjercicios.Controls.Add(this.BTN_AgregarEjercicio);
            this.GB_ListaEjercicios.Location = new System.Drawing.Point(424, 257);
            this.GB_ListaEjercicios.Name = "GB_ListaEjercicios";
            this.GB_ListaEjercicios.Size = new System.Drawing.Size(298, 251);
            this.GB_ListaEjercicios.TabIndex = 52;
            this.GB_ListaEjercicios.TabStop = false;
            this.GB_ListaEjercicios.Text = "Lista de Ejercicios";
            // 
            // BTN_AgregarEjercicio
            // 
            this.BTN_AgregarEjercicio.Location = new System.Drawing.Point(183, 199);
            this.BTN_AgregarEjercicio.Name = "BTN_AgregarEjercicio";
            this.BTN_AgregarEjercicio.Size = new System.Drawing.Size(109, 46);
            this.BTN_AgregarEjercicio.TabIndex = 1;
            this.BTN_AgregarEjercicio.Text = "Agregar Ejercicio al Plan";
            this.BTN_AgregarEjercicio.UseVisualStyleBackColor = true;
            this.BTN_AgregarEjercicio.Click += new System.EventHandler(this.BTN_AgregarEjercicio_Click);
            // 
            // DGV_ListaEjerciciosPlan
            // 
            this.DGV_ListaEjerciciosPlan.AllowUserToAddRows = false;
            this.DGV_ListaEjerciciosPlan.AllowUserToDeleteRows = false;
            this.DGV_ListaEjerciciosPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_ListaEjerciciosPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_ListaEjerciciosPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ListaEjerciciosPlan.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ListaEjerciciosPlan.Location = new System.Drawing.Point(21, 294);
            this.DGV_ListaEjerciciosPlan.MultiSelect = false;
            this.DGV_ListaEjerciciosPlan.Name = "DGV_ListaEjerciciosPlan";
            this.DGV_ListaEjerciciosPlan.ReadOnly = true;
            this.DGV_ListaEjerciciosPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListaEjerciciosPlan.Size = new System.Drawing.Size(215, 134);
            this.DGV_ListaEjerciciosPlan.TabIndex = 63;
            // 
            // BTN_EliminarPlan
            // 
            this.BTN_EliminarPlan.Location = new System.Drawing.Point(620, 514);
            this.BTN_EliminarPlan.Name = "BTN_EliminarPlan";
            this.BTN_EliminarPlan.Size = new System.Drawing.Size(102, 44);
            this.BTN_EliminarPlan.TabIndex = 53;
            this.BTN_EliminarPlan.Text = "Eliminar Plan de Ejericio";
            this.BTN_EliminarPlan.UseVisualStyleBackColor = true;
            this.BTN_EliminarPlan.Click += new System.EventHandler(this.BTN_EliminarPlan_Click);
            // 
            // CB_NombreEjercicio
            // 
            this.CB_NombreEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NombreEjercicio.FormattingEnabled = true;
            this.CB_NombreEjercicio.Location = new System.Drawing.Point(110, 31);
            this.CB_NombreEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.CB_NombreEjercicio.Name = "CB_NombreEjercicio";
            this.CB_NombreEjercicio.Size = new System.Drawing.Size(130, 21);
            this.CB_NombreEjercicio.TabIndex = 35;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(28, 34);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 36;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // LBL_Tiempo
            // 
            this.LBL_Tiempo.AutoSize = true;
            this.LBL_Tiempo.Location = new System.Drawing.Point(28, 109);
            this.LBL_Tiempo.Name = "LBL_Tiempo";
            this.LBL_Tiempo.Size = new System.Drawing.Size(45, 13);
            this.LBL_Tiempo.TabIndex = 37;
            this.LBL_Tiempo.Text = "Tiempo:";
            // 
            // LBL_Repeticiones
            // 
            this.LBL_Repeticiones.AutoSize = true;
            this.LBL_Repeticiones.Location = new System.Drawing.Point(28, 145);
            this.LBL_Repeticiones.Name = "LBL_Repeticiones";
            this.LBL_Repeticiones.Size = new System.Drawing.Size(72, 13);
            this.LBL_Repeticiones.TabIndex = 38;
            this.LBL_Repeticiones.Text = "Repeticiones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Escriba las repticiones y tiempos para este ejercicio:";
            // 
            // NUD_Repeticiones
            // 
            this.NUD_Repeticiones.Location = new System.Drawing.Point(110, 143);
            this.NUD_Repeticiones.Name = "NUD_Repeticiones";
            this.NUD_Repeticiones.Size = new System.Drawing.Size(120, 20);
            this.NUD_Repeticiones.TabIndex = 40;
            // 
            // NUD_Tiempo
            // 
            this.NUD_Tiempo.Location = new System.Drawing.Point(110, 107);
            this.NUD_Tiempo.Name = "NUD_Tiempo";
            this.NUD_Tiempo.Size = new System.Drawing.Size(120, 20);
            this.NUD_Tiempo.TabIndex = 41;
            // 
            // VerPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 570);
            this.Controls.Add(this.BTN_EliminarPlan);
            this.Controls.Add(this.GB_ListaEjercicios);
            this.Controls.Add(this.LBL_Plan);
            this.Controls.Add(this.GB_TareasPlanEjercicio);
            this.Controls.Add(this.GB_InfoPlanEjercicio);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VerPlanEjercicios";
            this.Text = " ";
            this.Load += new System.EventHandler(this.VerPlanEjercicios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_InfoPlanEjercicio.ResumeLayout(false);
            this.GB_InfoPlanEjercicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tareas)).EndInit();
            this.GB_TareasPlanEjercicio.ResumeLayout(false);
            this.GB_TareasPlanEjercicio.PerformLayout();
            this.GB_ListaEjercicios.ResumeLayout(false);
            this.GB_ListaEjercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaEjerciciosPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox GB_InfoPlanEjercicio;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Nivel;
        private System.Windows.Forms.Label LBL_Nivel;
        private System.Windows.Forms.GroupBox GB_TareasPlanEjercicio;
        private System.Windows.Forms.Label LBL_AgregarTarea;
        private System.Windows.Forms.Button BTN_AgregarTarea;
        private System.Windows.Forms.TextBox TXT_Tarea;
        private System.Windows.Forms.Label LBL_Plan;
        private System.Windows.Forms.Label LBL_Tareas;
        private System.Windows.Forms.DataGridView DGV_Tareas;
        private System.Windows.Forms.Label LBL_EjerciciosPlan;
        private System.Windows.Forms.GroupBox GB_ListaEjercicios;
        private System.Windows.Forms.Button BTN_AgregarEjercicio;
        private System.Windows.Forms.DataGridView DGV_ListaEjerciciosPlan;
        private System.Windows.Forms.Button BTN_EliminarPlan;
        private System.Windows.Forms.ComboBox CB_NombreEjercicio;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Repeticiones;
        private System.Windows.Forms.Label LBL_Tiempo;
        private System.Windows.Forms.NumericUpDown NUD_Tiempo;
        private System.Windows.Forms.NumericUpDown NUD_Repeticiones;
    }
}