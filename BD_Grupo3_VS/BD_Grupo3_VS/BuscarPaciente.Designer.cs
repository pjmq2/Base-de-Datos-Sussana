namespace BD_Grupo3_VS
{
    partial class BuscarPaciente
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
            this.BTN_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDePacientes
            // 
            this.LBL_ConsultaDePacientes.AutoSize = true;
            this.LBL_ConsultaDePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDePacientes.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_ConsultaDePacientes.Location = new System.Drawing.Point(21, 33);
            this.LBL_ConsultaDePacientes.Name = "LBL_ConsultaDePacientes";
            this.LBL_ConsultaDePacientes.Size = new System.Drawing.Size(306, 33);
            this.LBL_ConsultaDePacientes.TabIndex = 3;
            this.LBL_ConsultaDePacientes.Text = "Consulta de Pacientes";
            // 
            // LBL_FiltroNombre
            // 
            this.LBL_FiltroNombre.AutoSize = true;
            this.LBL_FiltroNombre.Location = new System.Drawing.Point(46, 121);
            this.LBL_FiltroNombre.Name = "LBL_FiltroNombre";
            this.LBL_FiltroNombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_FiltroNombre.TabIndex = 10;
            this.LBL_FiltroNombre.Text = "Nombre:";
            // 
            // LBL_FiltroGeneral
            // 
            this.LBL_FiltroGeneral.AutoSize = true;
            this.LBL_FiltroGeneral.Location = new System.Drawing.Point(267, 119);
            this.LBL_FiltroGeneral.Name = "LBL_FiltroGeneral";
            this.LBL_FiltroGeneral.Size = new System.Drawing.Size(72, 13);
            this.LBL_FiltroGeneral.TabIndex = 12;
            this.LBL_FiltroGeneral.Text = "Filtro General:";
            // 
            // TXT_FiltroGeneral
            // 
            this.TXT_FiltroGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroGeneral.Location = new System.Drawing.Point(346, 119);
            this.TXT_FiltroGeneral.Name = "TXT_FiltroGeneral";
            this.TXT_FiltroGeneral.Size = new System.Drawing.Size(146, 20);
            this.TXT_FiltroGeneral.TabIndex = 13;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(518, 113);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(93, 30);
            this.BTN_Buscar.TabIndex = 15;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.AllowUserToAddRows = false;
            this.DGV_Pacientes.AllowUserToDeleteRows = false;
            this.DGV_Pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(49, 195);
            this.DGV_Pacientes.MultiSelect = false;
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.ReadOnly = true;
            this.DGV_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Pacientes.Size = new System.Drawing.Size(443, 299);
            this.DGV_Pacientes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "En el filtro general puede ingresar apellido o cédula";
            // 
            // CB_Nombre
            // 
            this.CB_Nombre.FormattingEnabled = true;
            this.CB_Nombre.Location = new System.Drawing.Point(106, 119);
            this.CB_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Nombre.Name = "CB_Nombre";
            this.CB_Nombre.Size = new System.Drawing.Size(147, 21);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 20;
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
            this.BTN_Modificar.Location = new System.Drawing.Point(518, 195);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(93, 30);
            this.BTN_Modificar.TabIndex = 21;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // ConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 515);
            this.Controls.Add(this.BTN_Modificar);
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
        private System.Windows.Forms.Button BTN_Modificar;
    }
}