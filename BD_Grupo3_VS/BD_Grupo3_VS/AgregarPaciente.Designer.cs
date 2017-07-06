namespace BD_Grupo3_VS
{
    partial class AgregarPaciente
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
            this.GB_InfoPaciente = new System.Windows.Forms.GroupBox();
            this.DTP_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Valoracion = new System.Windows.Forms.TextBox();
            this.TXT_Comentarios = new System.Windows.Forms.TextBox();
            this.LBL_Valoracion = new System.Windows.Forms.Label();
            this.LBL_Comentarios = new System.Windows.Forms.Label();
            this.TXT_Telefono = new System.Windows.Forms.TextBox();
            this.LBL_Telefono = new System.Windows.Forms.Label();
            this.RB_Masculino = new System.Windows.Forms.RadioButton();
            this.RB_Femenino = new System.Windows.Forms.RadioButton();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Sexo = new System.Windows.Forms.Label();
            this.LBL_FechaNac = new System.Windows.Forms.Label();
            this.TXT_Apellido2 = new System.Windows.Forms.TextBox();
            this.TXT_Apellido1 = new System.Windows.Forms.TextBox();
            this.LBL_Apellido2 = new System.Windows.Forms.Label();
            this.LBL_Apellido1 = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_InfoPaciente.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_InfoPaciente
            // 
            this.GB_InfoPaciente.Controls.Add(this.DTP_FechaNac);
            this.GB_InfoPaciente.Controls.Add(this.BTN_Agregar);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Valoracion);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Comentarios);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Valoracion);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Comentarios);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Telefono);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Telefono);
            this.GB_InfoPaciente.Controls.Add(this.RB_Masculino);
            this.GB_InfoPaciente.Controls.Add(this.RB_Femenino);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Email);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Email);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Sexo);
            this.GB_InfoPaciente.Controls.Add(this.LBL_FechaNac);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Apellido2);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Apellido1);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Apellido2);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Apellido1);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Nombre);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Nombre);
            this.GB_InfoPaciente.Controls.Add(this.TXT_Cedula);
            this.GB_InfoPaciente.Controls.Add(this.LBL_Cedula);
            this.GB_InfoPaciente.Location = new System.Drawing.Point(33, 89);
            this.GB_InfoPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_InfoPaciente.Name = "GB_InfoPaciente";
            this.GB_InfoPaciente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_InfoPaciente.Size = new System.Drawing.Size(1061, 464);
            this.GB_InfoPaciente.TabIndex = 0;
            this.GB_InfoPaciente.TabStop = false;
            this.GB_InfoPaciente.Text = "Información del Paciente";
            // 
            // DTP_FechaNac
            // 
            this.DTP_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaNac.Location = new System.Drawing.Point(243, 265);
            this.DTP_FechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_FechaNac.Name = "DTP_FechaNac";
            this.DTP_FechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTP_FechaNac.Size = new System.Drawing.Size(116, 22);
            this.DTP_FechaNac.TabIndex = 23;
            this.DTP_FechaNac.Value = new System.DateTime(2017, 7, 5, 0, 0, 0, 0);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(859, 390);
            this.BTN_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(151, 49);
            this.BTN_Agregar.TabIndex = 22;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Valoracion
            // 
            this.TXT_Valoracion.Location = new System.Drawing.Point(604, 110);
            this.TXT_Valoracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Valoracion.Name = "TXT_Valoracion";
            this.TXT_Valoracion.Size = new System.Drawing.Size(204, 22);
            this.TXT_Valoracion.TabIndex = 21;
            // 
            // TXT_Comentarios
            // 
            this.TXT_Comentarios.Location = new System.Drawing.Point(604, 213);
            this.TXT_Comentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Comentarios.Name = "TXT_Comentarios";
            this.TXT_Comentarios.Size = new System.Drawing.Size(204, 22);
            this.TXT_Comentarios.TabIndex = 20;
            // 
            // LBL_Valoracion
            // 
            this.LBL_Valoracion.AutoSize = true;
            this.LBL_Valoracion.Location = new System.Drawing.Point(491, 113);
            this.LBL_Valoracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Valoracion.Name = "LBL_Valoracion";
            this.LBL_Valoracion.Size = new System.Drawing.Size(79, 17);
            this.LBL_Valoracion.TabIndex = 19;
            this.LBL_Valoracion.Text = "Valoración:";
            // 
            // LBL_Comentarios
            // 
            this.LBL_Comentarios.AutoSize = true;
            this.LBL_Comentarios.Location = new System.Drawing.Point(491, 213);
            this.LBL_Comentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Comentarios.Name = "LBL_Comentarios";
            this.LBL_Comentarios.Size = new System.Drawing.Size(91, 17);
            this.LBL_Comentarios.TabIndex = 18;
            this.LBL_Comentarios.Text = "Comentarios:";
            // 
            // TXT_Telefono
            // 
            this.TXT_Telefono.Location = new System.Drawing.Point(604, 60);
            this.TXT_Telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Telefono.Name = "TXT_Telefono";
            this.TXT_Telefono.Size = new System.Drawing.Size(204, 22);
            this.TXT_Telefono.TabIndex = 17;
            // 
            // LBL_Telefono
            // 
            this.LBL_Telefono.AutoSize = true;
            this.LBL_Telefono.Location = new System.Drawing.Point(491, 64);
            this.LBL_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Telefono.Name = "LBL_Telefono";
            this.LBL_Telefono.Size = new System.Drawing.Size(68, 17);
            this.LBL_Telefono.TabIndex = 16;
            this.LBL_Telefono.Text = "Teléfono:";
            // 
            // RB_Masculino
            // 
            this.RB_Masculino.AutoSize = true;
            this.RB_Masculino.Checked = true;
            this.RB_Masculino.Location = new System.Drawing.Point(155, 297);
            this.RB_Masculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Masculino.Name = "RB_Masculino";
            this.RB_Masculino.Size = new System.Drawing.Size(92, 21);
            this.RB_Masculino.TabIndex = 14;
            this.RB_Masculino.TabStop = true;
            this.RB_Masculino.Text = "Masculino";
            this.RB_Masculino.UseVisualStyleBackColor = true;
            // 
            // RB_Femenino
            // 
            this.RB_Femenino.AutoSize = true;
            this.RB_Femenino.Location = new System.Drawing.Point(157, 325);
            this.RB_Femenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Femenino.Name = "RB_Femenino";
            this.RB_Femenino.Size = new System.Drawing.Size(91, 21);
            this.RB_Femenino.TabIndex = 13;
            this.RB_Femenino.Text = "Femenino";
            this.RB_Femenino.UseVisualStyleBackColor = true;
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(155, 390);
            this.TXT_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(204, 22);
            this.TXT_Email.TabIndex = 12;
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(33, 390);
            this.LBL_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(46, 17);
            this.LBL_Email.TabIndex = 11;
            this.LBL_Email.Text = "Email:";
            // 
            // LBL_Sexo
            // 
            this.LBL_Sexo.AutoSize = true;
            this.LBL_Sexo.Location = new System.Drawing.Point(33, 308);
            this.LBL_Sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Sexo.Name = "LBL_Sexo";
            this.LBL_Sexo.Size = new System.Drawing.Size(43, 17);
            this.LBL_Sexo.TabIndex = 10;
            this.LBL_Sexo.Text = "Sexo:";
            // 
            // LBL_FechaNac
            // 
            this.LBL_FechaNac.AutoSize = true;
            this.LBL_FechaNac.Location = new System.Drawing.Point(32, 265);
            this.LBL_FechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FechaNac.Name = "LBL_FechaNac";
            this.LBL_FechaNac.Size = new System.Drawing.Size(145, 17);
            this.LBL_FechaNac.TabIndex = 9;
            this.LBL_FechaNac.Text = "Fecha de Nacimiento:";
            // 
            // TXT_Apellido2
            // 
            this.TXT_Apellido2.Location = new System.Drawing.Point(155, 209);
            this.TXT_Apellido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Apellido2.Name = "TXT_Apellido2";
            this.TXT_Apellido2.Size = new System.Drawing.Size(204, 22);
            this.TXT_Apellido2.TabIndex = 8;
            // 
            // TXT_Apellido1
            // 
            this.TXT_Apellido1.Location = new System.Drawing.Point(155, 166);
            this.TXT_Apellido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Apellido1.Name = "TXT_Apellido1";
            this.TXT_Apellido1.Size = new System.Drawing.Size(204, 22);
            this.TXT_Apellido1.TabIndex = 7;
            // 
            // LBL_Apellido2
            // 
            this.LBL_Apellido2.AutoSize = true;
            this.LBL_Apellido2.Location = new System.Drawing.Point(32, 213);
            this.LBL_Apellido2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Apellido2.Name = "LBL_Apellido2";
            this.LBL_Apellido2.Size = new System.Drawing.Size(90, 17);
            this.LBL_Apellido2.TabIndex = 6;
            this.LBL_Apellido2.Text = "2do Apellido:";
            // 
            // LBL_Apellido1
            // 
            this.LBL_Apellido1.AutoSize = true;
            this.LBL_Apellido1.Location = new System.Drawing.Point(32, 170);
            this.LBL_Apellido1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Apellido1.Name = "LBL_Apellido1";
            this.LBL_Apellido1.Size = new System.Drawing.Size(87, 17);
            this.LBL_Apellido1.TabIndex = 5;
            this.LBL_Apellido1.Text = "1er Apellido:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(155, 113);
            this.TXT_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(204, 22);
            this.TXT_Nombre.TabIndex = 4;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(32, 113);
            this.LBL_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(62, 17);
            this.LBL_Nombre.TabIndex = 3;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(155, 64);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(204, 22);
            this.TXT_Cedula.TabIndex = 2;
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(32, 64);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 1;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(439, 34);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(164, 42);
            this.LBL_Titulo.TabIndex = 4;
            this.LBL_Titulo.Text = "Paciente";
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
            this.menuStrip1.Size = new System.Drawing.Size(1147, 28);
            this.menuStrip1.TabIndex = 21;
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
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 567);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.GB_InfoPaciente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarPaciente";
            this.Text = "AgregarPaciente";
            this.GB_InfoPaciente.ResumeLayout(false);
            this.GB_InfoPaciente.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_InfoPaciente;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Apellido2;
        private System.Windows.Forms.Label LBL_Apellido1;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Sexo;
        private System.Windows.Forms.Label LBL_FechaNac;
        private System.Windows.Forms.TextBox TXT_Apellido2;
        private System.Windows.Forms.TextBox TXT_Apellido1;
        private System.Windows.Forms.RadioButton RB_Masculino;
        private System.Windows.Forms.RadioButton RB_Femenino;
        private System.Windows.Forms.TextBox TXT_Valoracion;
        private System.Windows.Forms.TextBox TXT_Comentarios;
        private System.Windows.Forms.Label LBL_Valoracion;
        private System.Windows.Forms.Label LBL_Comentarios;
        private System.Windows.Forms.TextBox TXT_Telefono;
        private System.Windows.Forms.Label LBL_Telefono;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.DateTimePicker DTP_FechaNac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}