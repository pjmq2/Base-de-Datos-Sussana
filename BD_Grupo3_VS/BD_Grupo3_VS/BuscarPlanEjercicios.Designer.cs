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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LBL_ConsultaPlanEjercicios = new System.Windows.Forms.Label();
            this.LBL_Nivel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Padecimiento = new System.Windows.Forms.ComboBox();
            this.CB_Nivel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 273);
            this.dataGridView1.TabIndex = 44;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_Ejercicio_Buscar;
            this.BTN_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Buscar.Location = new System.Drawing.Point(416, 99);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(92, 121);
            this.BTN_Buscar.TabIndex = 43;
            this.BTN_Buscar.Text = "Buscar Plan";
            this.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(26, 164);
            this.LBL_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(97, 17);
            this.LBL_Padecimiento.TabIndex = 40;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(26, 102);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(115, 17);
            this.LBL_Cedula.TabIndex = 39;
            this.LBL_Cedula.Text = "Cédula Paciente:";
            // 
            // LBL_ConsultaPlanEjercicios
            // 
            this.LBL_ConsultaPlanEjercicios.AutoSize = true;
            this.LBL_ConsultaPlanEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaPlanEjercicios.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_ConsultaPlanEjercicios.Location = new System.Drawing.Point(68, 37);
            this.LBL_ConsultaPlanEjercicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ConsultaPlanEjercicios.Name = "LBL_ConsultaPlanEjercicios";
            this.LBL_ConsultaPlanEjercicios.Size = new System.Drawing.Size(525, 42);
            this.LBL_ConsultaPlanEjercicios.TabIndex = 34;
            this.LBL_ConsultaPlanEjercicios.Text = "Consultar Planes de Ejercicios";
            // 
            // LBL_Nivel
            // 
            this.LBL_Nivel.AutoSize = true;
            this.LBL_Nivel.Location = new System.Drawing.Point(26, 200);
            this.LBL_Nivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Nivel.Name = "LBL_Nivel";
            this.LBL_Nivel.Size = new System.Drawing.Size(43, 17);
            this.LBL_Nivel.TabIndex = 45;
            this.LBL_Nivel.Text = "Nivel:";
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
            this.menuStrip1.Size = new System.Drawing.Size(668, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.InicioToolStripMenuItem.Text = "Inicio";
            this.InicioToolStripMenuItem.Click += new System.EventHandler(this.InicioToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            this.crearPacienteToolStripMenuItem.Click += new System.EventHandler(this.crearPacienteToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            this.avanzadoToolStripMenuItem.Click += new System.EventHandler(this.avanzadoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // CB_Padecimiento
            // 
            this.CB_Padecimiento.FormattingEnabled = true;
            this.CB_Padecimiento.Location = new System.Drawing.Point(127, 157);
            this.CB_Padecimiento.Name = "CB_Padecimiento";
            this.CB_Padecimiento.Size = new System.Drawing.Size(269, 24);
            this.CB_Padecimiento.TabIndex = 49;
            // 
            // CB_Nivel
            // 
            this.CB_Nivel.FormattingEnabled = true;
            this.CB_Nivel.Location = new System.Drawing.Point(127, 193);
            this.CB_Nivel.Name = "CB_Nivel";
            this.CB_Nivel.Size = new System.Drawing.Size(269, 24);
            this.CB_Nivel.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Image = global::BD_Grupo3_VS.Properties.Resources.Plan_Ejercicio_Modificar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(516, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 121);
            this.button1.TabIndex = 51;
            this.button1.Text = "Modificar Plan";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_Nivel);
            this.Controls.Add(this.CB_Padecimiento);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Nivel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.LBL_Padecimiento);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LBL_ConsultaPlanEjercicios);
            this.Name = "BuscarPlanEjercicios";
            this.Text = "ConsultarPlanEjercicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.Label LBL_ConsultaPlanEjercicios;
        private System.Windows.Forms.Label LBL_Nivel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox CB_Padecimiento;
        private System.Windows.Forms.ComboBox CB_Nivel;
        private System.Windows.Forms.Button button1;
    }
}