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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Cirugia = new System.Windows.Forms.TextBox();
            this.BTN_AgregarCirugia = new System.Windows.Forms.Button();
            this.GB_DatosCirugia = new System.Windows.Forms.GroupBox();
            this.TXT_Apellido2 = new System.Windows.Forms.TextBox();
            this.TXT_Apellido1 = new System.Windows.Forms.TextBox();
            this.LBL_Apellido2 = new System.Windows.Forms.Label();
            this.LBL_Apellido1 = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_DatosCirugia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Cirugías
            // 
            this.LBL_Cirugías.AutoSize = true;
            this.LBL_Cirugías.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Cirugías.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Cirugías.Location = new System.Drawing.Point(216, 43);
            this.LBL_Cirugías.Name = "LBL_Cirugías";
            this.LBL_Cirugías.Size = new System.Drawing.Size(123, 33);
            this.LBL_Cirugías.TabIndex = 5;
            this.LBL_Cirugías.Text = "Cirugías";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cirugía:";
            // 
            // TXT_Cirugia
            // 
            this.TXT_Cirugia.Location = new System.Drawing.Point(356, 49);
            this.TXT_Cirugia.Multiline = true;
            this.TXT_Cirugia.Name = "TXT_Cirugia";
            this.TXT_Cirugia.Size = new System.Drawing.Size(140, 102);
            this.TXT_Cirugia.TabIndex = 32;
            // 
            // BTN_AgregarCirugia
            // 
            this.BTN_AgregarCirugia.Location = new System.Drawing.Point(396, 164);
            this.BTN_AgregarCirugia.Name = "BTN_AgregarCirugia";
            this.BTN_AgregarCirugia.Size = new System.Drawing.Size(100, 27);
            this.BTN_AgregarCirugia.TabIndex = 34;
            this.BTN_AgregarCirugia.Text = "Agregar cirugía";
            this.BTN_AgregarCirugia.UseVisualStyleBackColor = true;
            this.BTN_AgregarCirugia.Click += new System.EventHandler(this.BTN_AgregarCirugia_Click);
            // 
            // GB_DatosCirugia
            // 
            this.GB_DatosCirugia.Controls.Add(this.TXT_Apellido2);
            this.GB_DatosCirugia.Controls.Add(this.TXT_Apellido1);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Apellido2);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Apellido1);
            this.GB_DatosCirugia.Controls.Add(this.TXT_Nombre);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Nombre);
            this.GB_DatosCirugia.Controls.Add(this.TXT_Cedula);
            this.GB_DatosCirugia.Controls.Add(this.LBL_Cedula);
            this.GB_DatosCirugia.Controls.Add(this.BTN_AgregarCirugia);
            this.GB_DatosCirugia.Controls.Add(this.TXT_Cirugia);
            this.GB_DatosCirugia.Controls.Add(this.label1);
            this.GB_DatosCirugia.Location = new System.Drawing.Point(30, 94);
            this.GB_DatosCirugia.Name = "GB_DatosCirugia";
            this.GB_DatosCirugia.Size = new System.Drawing.Size(517, 209);
            this.GB_DatosCirugia.TabIndex = 38;
            this.GB_DatosCirugia.TabStop = false;
            this.GB_DatosCirugia.Text = "Datos de la cirugía";
            // 
            // TXT_Apellido2
            // 
            this.TXT_Apellido2.Location = new System.Drawing.Point(95, 164);
            this.TXT_Apellido2.Name = "TXT_Apellido2";
            this.TXT_Apellido2.Size = new System.Drawing.Size(121, 20);
            this.TXT_Apellido2.TabIndex = 45;
            // 
            // TXT_Apellido1
            // 
            this.TXT_Apellido1.Location = new System.Drawing.Point(95, 131);
            this.TXT_Apellido1.Name = "TXT_Apellido1";
            this.TXT_Apellido1.Size = new System.Drawing.Size(121, 20);
            this.TXT_Apellido1.TabIndex = 44;
            // 
            // LBL_Apellido2
            // 
            this.LBL_Apellido2.AutoSize = true;
            this.LBL_Apellido2.Location = new System.Drawing.Point(21, 167);
            this.LBL_Apellido2.Name = "LBL_Apellido2";
            this.LBL_Apellido2.Size = new System.Drawing.Size(68, 13);
            this.LBL_Apellido2.TabIndex = 43;
            this.LBL_Apellido2.Text = "2do Apellido:";
            // 
            // LBL_Apellido1
            // 
            this.LBL_Apellido1.AutoSize = true;
            this.LBL_Apellido1.Location = new System.Drawing.Point(21, 134);
            this.LBL_Apellido1.Name = "LBL_Apellido1";
            this.LBL_Apellido1.Size = new System.Drawing.Size(65, 13);
            this.LBL_Apellido1.TabIndex = 42;
            this.LBL_Apellido1.Text = "1er Apellido:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(95, 94);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(121, 20);
            this.TXT_Nombre.TabIndex = 41;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(21, 97);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 40;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(95, 49);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(121, 20);
            this.TXT_Cedula.TabIndex = 39;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(21, 52);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 39;
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
            // AgregarCirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 315);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_DatosCirugia);
            this.Controls.Add(this.LBL_Cirugías);
            this.Name = "AgregarCirugias";
            this.Text = "AgregarCirugias";
            this.GB_DatosCirugia.ResumeLayout(false);
            this.GB_DatosCirugia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Cirugías;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Cirugia;
        private System.Windows.Forms.Button BTN_AgregarCirugia;
        private System.Windows.Forms.GroupBox GB_DatosCirugia;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Apellido2;
        private System.Windows.Forms.TextBox TXT_Apellido1;
        private System.Windows.Forms.Label LBL_Apellido2;
        private System.Windows.Forms.Label LBL_Apellido1;
    }
}