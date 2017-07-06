namespace BD_Grupo3_VS
{
    partial class ConsultarPaciente
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
            this.LBL_ConsultaDePacientes = new System.Windows.Forms.Label();
            this.LBL_FiltroNombre = new System.Windows.Forms.Label();
            this.LBL_FiltroGeneral = new System.Windows.Forms.Label();
            this.TXT_FiltroGeneral = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Nombre = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDePacientes
            // 
            this.LBL_ConsultaDePacientes.AutoSize = true;
            this.LBL_ConsultaDePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDePacientes.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_ConsultaDePacientes.Location = new System.Drawing.Point(28, 41);
            this.LBL_ConsultaDePacientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ConsultaDePacientes.Name = "LBL_ConsultaDePacientes";
            this.LBL_ConsultaDePacientes.Size = new System.Drawing.Size(393, 42);
            this.LBL_ConsultaDePacientes.TabIndex = 3;
            this.LBL_ConsultaDePacientes.Text = "Consulta de Pacientes";
            // 
            // LBL_FiltroNombre
            // 
            this.LBL_FiltroNombre.AutoSize = true;
            this.LBL_FiltroNombre.Location = new System.Drawing.Point(61, 149);
            this.LBL_FiltroNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FiltroNombre.Name = "LBL_FiltroNombre";
            this.LBL_FiltroNombre.Size = new System.Drawing.Size(62, 17);
            this.LBL_FiltroNombre.TabIndex = 10;
            this.LBL_FiltroNombre.Text = "Nombre:";
            // 
            // LBL_FiltroGeneral
            // 
            this.LBL_FiltroGeneral.AutoSize = true;
            this.LBL_FiltroGeneral.Location = new System.Drawing.Point(376, 146);
            this.LBL_FiltroGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FiltroGeneral.Name = "LBL_FiltroGeneral";
            this.LBL_FiltroGeneral.Size = new System.Drawing.Size(98, 17);
            this.LBL_FiltroGeneral.TabIndex = 12;
            this.LBL_FiltroGeneral.Text = "Filtro General:";
            // 
            // TXT_FiltroGeneral
            // 
            this.TXT_FiltroGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroGeneral.Location = new System.Drawing.Point(503, 146);
            this.TXT_FiltroGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_FiltroGeneral.Name = "TXT_FiltroGeneral";
            this.TXT_FiltroGeneral.Size = new System.Drawing.Size(193, 22);
            this.TXT_FiltroGeneral.TabIndex = 13;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(721, 139);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(124, 37);
            this.BTN_Buscar.TabIndex = 15;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.AllowUserToAddRows = false;
            this.DGV_Pacientes.AllowUserToDeleteRows = false;
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(35, 184);
            this.DGV_Pacientes.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Pacientes.MultiSelect = false;
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.ReadOnly = true;
            this.DGV_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Pacientes.Size = new System.Drawing.Size(895, 395);
            this.DGV_Pacientes.TabIndex = 16;
            this.DGV_Pacientes.CurrentCellChanged += new System.EventHandler(this.DGV_Pacientes_CurrentCellChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "En el filtro general puede ingresar apellido o cédula";
            // 
            // CB_Nombre
            // 
            this.CB_Nombre.FormattingEnabled = true;
            this.CB_Nombre.Location = new System.Drawing.Point(142, 146);
            this.CB_Nombre.Name = "CB_Nombre";
            this.CB_Nombre.Size = new System.Drawing.Size(195, 24);
            this.CB_Nombre.TabIndex = 19;
            this.CB_Nombre.SelectedIndexChanged += new System.EventHandler(this.CB_Nombre_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 20;
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
            // ConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 634);
            this.Controls.Add(this.CB_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Pacientes);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_FiltroGeneral);
            this.Controls.Add(this.LBL_FiltroGeneral);
            this.Controls.Add(this.LBL_FiltroNombre);
            this.Controls.Add(this.LBL_ConsultaDePacientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarPaciente";
            this.Text = "ConsultarPaciente";
            this.Load += new System.EventHandler(this.ConsultarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ConsultaDePacientes;
        private System.Windows.Forms.Label LBL_FiltroNombre;
        private System.Windows.Forms.Label LBL_FiltroGeneral;
        private System.Windows.Forms.TextBox TXT_FiltroGeneral;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.DataGridView DGV_Pacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}