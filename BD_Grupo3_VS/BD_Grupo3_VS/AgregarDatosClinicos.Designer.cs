namespace BD_Grupo3_VS
{
    partial class AgregarDatosClinicos
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
            this.GB_InfoDatosClinicos = new System.Windows.Forms.GroupBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Dato = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.TXT_Dato = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Apellido1 = new System.Windows.Forms.Label();
            this.TXT_Apellido1 = new System.Windows.Forms.TextBox();
            this.LBL_Apellido2 = new System.Windows.Forms.Label();
            this.TXT_Apellido2 = new System.Windows.Forms.TextBox();
            this.GB_InfoDatosClinicos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_InfoDatosClinicos
            // 
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Apellido2);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Apellido2);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Apellido1);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Apellido1);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Nombre);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Nombre);
            this.GB_InfoDatosClinicos.Controls.Add(this.BTN_Agregar);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Dato);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Dato);
            this.GB_InfoDatosClinicos.Location = new System.Drawing.Point(27, 104);
            this.GB_InfoDatosClinicos.Name = "GB_InfoDatosClinicos";
            this.GB_InfoDatosClinicos.Size = new System.Drawing.Size(504, 228);
            this.GB_InfoDatosClinicos.TabIndex = 14;
            this.GB_InfoDatosClinicos.TabStop = false;
            this.GB_InfoDatosClinicos.Text = "Detellas de los datos clínicos";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(398, 177);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(90, 35);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(104, 51);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(121, 20);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // LBL_Dato
            // 
            this.LBL_Dato.AutoSize = true;
            this.LBL_Dato.Location = new System.Drawing.Point(247, 54);
            this.LBL_Dato.Name = "LBL_Dato";
            this.LBL_Dato.Size = new System.Drawing.Size(69, 13);
            this.LBL_Dato.TabIndex = 9;
            this.LBL_Dato.Text = "Dato Clínico:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(24, 54);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 6;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Dato
            // 
            this.TXT_Dato.Location = new System.Drawing.Point(334, 51);
            this.TXT_Dato.Multiline = true;
            this.TXT_Dato.Name = "TXT_Dato";
            this.TXT_Dato.Size = new System.Drawing.Size(154, 110);
            this.TXT_Dato.TabIndex = 10;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(174, 54);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(203, 33);
            this.LBL_Titulo.TabIndex = 15;
            this.LBL_Titulo.Text = "Datos Clínicos";
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
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 40;
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
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(24, 98);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 41;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(104, 91);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(121, 20);
            this.TXT_Nombre.TabIndex = 42;
            // 
            // LBL_Apellido1
            // 
            this.LBL_Apellido1.AutoSize = true;
            this.LBL_Apellido1.Location = new System.Drawing.Point(24, 148);
            this.LBL_Apellido1.Name = "LBL_Apellido1";
            this.LBL_Apellido1.Size = new System.Drawing.Size(65, 13);
            this.LBL_Apellido1.TabIndex = 43;
            this.LBL_Apellido1.Text = "1er Apellido:";
            // 
            // TXT_Apellido1
            // 
            this.TXT_Apellido1.Location = new System.Drawing.Point(104, 141);
            this.TXT_Apellido1.Name = "TXT_Apellido1";
            this.TXT_Apellido1.Size = new System.Drawing.Size(121, 20);
            this.TXT_Apellido1.TabIndex = 45;
            // 
            // LBL_Apellido2
            // 
            this.LBL_Apellido2.AutoSize = true;
            this.LBL_Apellido2.Location = new System.Drawing.Point(24, 188);
            this.LBL_Apellido2.Name = "LBL_Apellido2";
            this.LBL_Apellido2.Size = new System.Drawing.Size(68, 13);
            this.LBL_Apellido2.TabIndex = 46;
            this.LBL_Apellido2.Text = "2do Apellido:";
            // 
            // TXT_Apellido2
            // 
            this.TXT_Apellido2.Location = new System.Drawing.Point(104, 188);
            this.TXT_Apellido2.Name = "TXT_Apellido2";
            this.TXT_Apellido2.Size = new System.Drawing.Size(121, 20);
            this.TXT_Apellido2.TabIndex = 47;
            // 
            // AgregarDatosClinicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 356);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.GB_InfoDatosClinicos);
            this.Name = "AgregarDatosClinicos";
            this.Text = "AgregarDatosClinicos";
            this.GB_InfoDatosClinicos.ResumeLayout(false);
            this.GB_InfoDatosClinicos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_InfoDatosClinicos;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Dato;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.TextBox TXT_Dato;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Apellido1;
        private System.Windows.Forms.TextBox TXT_Apellido1;
        private System.Windows.Forms.Label LBL_Apellido2;
        private System.Windows.Forms.TextBox TXT_Apellido2;
    }
}