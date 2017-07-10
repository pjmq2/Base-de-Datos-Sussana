namespace BD_Grupo3_VS
{
    partial class BuscarPlanEjercicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_PlanEjercicio = new System.Windows.Forms.DataGridView();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LBL_ConsultaPlanEjercicios = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlanEjercicio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_PlanEjercicio
            // 
            this.DGV_PlanEjercicio.AllowUserToAddRows = false;
            this.DGV_PlanEjercicio.AllowUserToDeleteRows = false;
            this.DGV_PlanEjercicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_PlanEjercicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_PlanEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PlanEjercicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PlanEjercicio.Location = new System.Drawing.Point(12, 193);
            this.DGV_PlanEjercicio.MultiSelect = false;
            this.DGV_PlanEjercicio.Name = "DGV_PlanEjercicio";
            this.DGV_PlanEjercicio.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PlanEjercicio.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PlanEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PlanEjercicio.Size = new System.Drawing.Size(472, 122);
            this.DGV_PlanEjercicio.TabIndex = 44;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(22, 123);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(88, 13);
            this.LBL_Cedula.TabIndex = 39;
            this.LBL_Cedula.Text = "Cédula Paciente:";
            // 
            // LBL_ConsultaPlanEjercicios
            // 
            this.LBL_ConsultaPlanEjercicios.AutoSize = true;
            this.LBL_ConsultaPlanEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaPlanEjercicios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_ConsultaPlanEjercicios.Location = new System.Drawing.Point(53, 40);
            this.LBL_ConsultaPlanEjercicios.Name = "LBL_ConsultaPlanEjercicios";
            this.LBL_ConsultaPlanEjercicios.Size = new System.Drawing.Size(378, 33);
            this.LBL_ConsultaPlanEjercicios.TabIndex = 34;
            this.LBL_ConsultaPlanEjercicios.Text = "Buscar Planes de Ejercicios";
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
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 47;
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
            // BTN_Modificar
            // 
            this.BTN_Modificar.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_Ejercicio_Modificar;
            this.BTN_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Modificar.Location = new System.Drawing.Point(409, 89);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(80, 98);
            this.BTN_Modificar.TabIndex = 51;
            this.BTN_Modificar.Text = "Modificar Plan";
            this.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(116, 120);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.ReadOnly = true;
            this.TXT_Cedula.Size = new System.Drawing.Size(117, 20);
            this.TXT_Cedula.TabIndex = 54;
            // 
            // BuscarPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DGV_PlanEjercicio);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LBL_ConsultaPlanEjercicios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarPlanEjercicios";
            this.Text = "BuscarPlanEjercicios";
            this.Load += new System.EventHandler(this.BuscarPlanEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlanEjercicio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PlanEjercicio;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.Label LBL_ConsultaPlanEjercicios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.TextBox TXT_Cedula;
    }
}