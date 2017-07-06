namespace BD_Grupo3_VS
{
    partial class AgregarCirugias
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
            this.LBL_Cirugías = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.CMB_Nombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Cirugia = new System.Windows.Forms.TextBox();
            this.DGV_CedPaciente = new System.Windows.Forms.DataGridView();
            this.BTN_AgregarCirugia = new System.Windows.Forms.Button();
            this.LBL_FiltroGeneral = new System.Windows.Forms.Label();
            this.TXT_FiltroGeneral = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.GB_DatosCirugia = new System.Windows.Forms.GroupBox();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CedPaciente)).BeginInit();
            this.GB_DatosCirugia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Cirugías
            // 
            this.LBL_Cirugías.AutoSize = true;
            this.LBL_Cirugías.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Cirugías.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Cirugías.Location = new System.Drawing.Point(301, 51);
            this.LBL_Cirugías.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cirugías.Name = "LBL_Cirugías";
            this.LBL_Cirugías.Size = new System.Drawing.Size(155, 42);
            this.LBL_Cirugías.TabIndex = 5;
            this.LBL_Cirugías.Text = "Cirugías";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(28, 73);
            this.LBL_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(143, 17);
            this.LBL_Nombre.TabIndex = 29;
            this.LBL_Nombre.Text = "Nombre del paciente:";
            // 
            // CMB_Nombre
            // 
            this.CMB_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Nombre.FormattingEnabled = true;
            this.CMB_Nombre.Location = new System.Drawing.Point(211, 63);
            this.CMB_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CMB_Nombre.Name = "CMB_Nombre";
            this.CMB_Nombre.Size = new System.Drawing.Size(160, 24);
            this.CMB_Nombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cirugía:";
            // 
            // TXT_Cirugia
            // 
            this.TXT_Cirugia.Location = new System.Drawing.Point(617, 148);
            this.TXT_Cirugia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cirugia.Name = "TXT_Cirugia";
            this.TXT_Cirugia.Size = new System.Drawing.Size(160, 22);
            this.TXT_Cirugia.TabIndex = 32;
            // 
            // DGV_CedPaciente
            // 
            this.DGV_CedPaciente.AllowUserToAddRows = false;
            this.DGV_CedPaciente.AllowUserToDeleteRows = false;
            this.DGV_CedPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CedPaciente.Location = new System.Drawing.Point(81, 292);
            this.DGV_CedPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_CedPaciente.Name = "DGV_CedPaciente";
            this.DGV_CedPaciente.ReadOnly = true;
            this.DGV_CedPaciente.Size = new System.Drawing.Size(291, 44);
            this.DGV_CedPaciente.TabIndex = 33;
            // 
            // BTN_AgregarCirugia
            // 
            this.BTN_AgregarCirugia.Location = new System.Drawing.Point(645, 222);
            this.BTN_AgregarCirugia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_AgregarCirugia.Name = "BTN_AgregarCirugia";
            this.BTN_AgregarCirugia.Size = new System.Drawing.Size(133, 33);
            this.BTN_AgregarCirugia.TabIndex = 34;
            this.BTN_AgregarCirugia.Text = "Agregar cirugía";
            this.BTN_AgregarCirugia.UseVisualStyleBackColor = true;
            this.BTN_AgregarCirugia.Click += new System.EventHandler(this.BTN_AgregarCirugia_Click);
            // 
            // LBL_FiltroGeneral
            // 
            this.LBL_FiltroGeneral.AutoSize = true;
            this.LBL_FiltroGeneral.Location = new System.Drawing.Point(35, 148);
            this.LBL_FiltroGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FiltroGeneral.Name = "LBL_FiltroGeneral";
            this.LBL_FiltroGeneral.Size = new System.Drawing.Size(98, 17);
            this.LBL_FiltroGeneral.TabIndex = 35;
            this.LBL_FiltroGeneral.Text = "Filtro General:";
            // 
            // TXT_FiltroGeneral
            // 
            this.TXT_FiltroGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroGeneral.Location = new System.Drawing.Point(211, 148);
            this.TXT_FiltroGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_FiltroGeneral.Name = "TXT_FiltroGeneral";
            this.TXT_FiltroGeneral.Size = new System.Drawing.Size(160, 22);
            this.TXT_FiltroGeneral.TabIndex = 36;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(268, 210);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(104, 32);
            this.BTN_Buscar.TabIndex = 37;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // GB_DatosCirugia
            // 
            this.GB_DatosCirugia.Controls.Add(this.TXT_Cedula);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Cedula);
            this.GB_DatosCirugia.Controls.Add(this.DGV_CedPaciente);
            this.GB_DatosCirugia.Controls.Add(this.BTN_AgregarCirugia);
            this.GB_DatosCirugia.Controls.Add(this.LBL_FiltroGeneral);
            this.GB_DatosCirugia.Controls.Add(this.TXT_Cirugia);
            this.GB_DatosCirugia.Controls.Add(this.TXT_FiltroGeneral);
            this.GB_DatosCirugia.Controls.Add(this.label1);
            this.GB_DatosCirugia.Controls.Add(this.BTN_Buscar);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Nombre);
            this.GB_DatosCirugia.Controls.Add(this.CMB_Nombre);
            this.GB_DatosCirugia.Location = new System.Drawing.Point(40, 116);
            this.GB_DatosCirugia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_DatosCirugia.Name = "GB_DatosCirugia";
            this.GB_DatosCirugia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_DatosCirugia.Size = new System.Drawing.Size(801, 357);
            this.GB_DatosCirugia.TabIndex = 38;
            this.GB_DatosCirugia.TabStop = false;
            this.GB_DatosCirugia.Text = "Datos de la cirugía";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(617, 64);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(160, 22);
            this.TXT_Cedula.TabIndex = 39;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(479, 73);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 38;
            this.LBL_Cedula.Text = "Cédula:";
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
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 39;
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
            // AgregarCirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 500);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_DatosCirugia);
            this.Controls.Add(this.LBL_Cirugías);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarCirugias";
            this.Text = "AgregarCirugias";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CedPaciente)).EndInit();
            this.GB_DatosCirugia.ResumeLayout(false);
            this.GB_DatosCirugia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Cirugías;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.ComboBox CMB_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Cirugia;
        private System.Windows.Forms.DataGridView DGV_CedPaciente;
        private System.Windows.Forms.Button BTN_AgregarCirugia;
        private System.Windows.Forms.Label LBL_FiltroGeneral;
        private System.Windows.Forms.TextBox TXT_FiltroGeneral;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.GroupBox GB_DatosCirugia;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}