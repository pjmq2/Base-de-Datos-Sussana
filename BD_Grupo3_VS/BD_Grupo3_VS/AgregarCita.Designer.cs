namespace BD_Grupo3_VS
{
    partial class AgregarCita
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
            this.label1 = new System.Windows.Forms.Label();
            this.GB_AgregarCita = new System.Windows.Forms.GroupBox();
            this.BTN_Lista = new System.Windows.Forms.Button();
            this.CB_Lugar = new System.Windows.Forms.ComboBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Estado = new System.Windows.Forms.TextBox();
            this.LBL_Estado = new System.Windows.Forms.Label();
            this.LBL_Lugar = new System.Windows.Forms.Label();
            this.TXT_Duracion = new System.Windows.Forms.TextBox();
            this.LBL_Duracion = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.LBL_Descripcion = new System.Windows.Forms.Label();
            this.TXT_Precio = new System.Windows.Forms.TextBox();
            this.LBL_Precio = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LBL_FechaHora = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Padecimiento = new System.Windows.Forms.ComboBox();
            this.GB_AgregarCita.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(336, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita";
            // 
            // GB_AgregarCita
            // 
            this.GB_AgregarCita.Controls.Add(this.CB_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.BTN_Lista);
            this.GB_AgregarCita.Controls.Add(this.CB_Lugar);
            this.GB_AgregarCita.Controls.Add(this.BTN_Agregar);
            this.GB_AgregarCita.Controls.Add(this.TXT_Estado);
            this.GB_AgregarCita.Controls.Add(this.LBL_Estado);
            this.GB_AgregarCita.Controls.Add(this.LBL_Lugar);
            this.GB_AgregarCita.Controls.Add(this.TXT_Duracion);
            this.GB_AgregarCita.Controls.Add(this.LBL_Duracion);
            this.GB_AgregarCita.Controls.Add(this.TXT_Descripcion);
            this.GB_AgregarCita.Controls.Add(this.LBL_Descripcion);
            this.GB_AgregarCita.Controls.Add(this.TXT_Precio);
            this.GB_AgregarCita.Controls.Add(this.LBL_Precio);
            this.GB_AgregarCita.Controls.Add(this.dateTimePicker1);
            this.GB_AgregarCita.Controls.Add(this.LBL_FechaHora);
            this.GB_AgregarCita.Controls.Add(this.TXT_Cedula);
            this.GB_AgregarCita.Controls.Add(this.LBL_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.LBL_Cedula);
            this.GB_AgregarCita.Location = new System.Drawing.Point(26, 101);
            this.GB_AgregarCita.Name = "GB_AgregarCita";
            this.GB_AgregarCita.Size = new System.Drawing.Size(715, 340);
            this.GB_AgregarCita.TabIndex = 5;
            this.GB_AgregarCita.TabStop = false;
            this.GB_AgregarCita.Text = "Agregar una Cita";
            // 
            // BTN_Lista
            // 
            this.BTN_Lista.Image = global::BD_Grupo3_VS.Properties.Resources.Cita_Buscar;
            this.BTN_Lista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Lista.Location = new System.Drawing.Point(617, 223);
            this.BTN_Lista.Name = "BTN_Lista";
            this.BTN_Lista.Size = new System.Drawing.Size(80, 92);
            this.BTN_Lista.TabIndex = 18;
            this.BTN_Lista.Text = "Lista de Citas";
            this.BTN_Lista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Lista.UseVisualStyleBackColor = true;
            this.BTN_Lista.Click += new System.EventHandler(this.BTN_Lista_Click);
            // 
            // CB_Lugar
            // 
            this.CB_Lugar.FormattingEnabled = true;
            this.CB_Lugar.Items.AddRange(new object[] {
            "Consultorio",
            "Domicilio"});
            this.CB_Lugar.Location = new System.Drawing.Point(555, 172);
            this.CB_Lugar.Name = "CB_Lugar";
            this.CB_Lugar.Size = new System.Drawing.Size(142, 21);
            this.CB_Lugar.TabIndex = 17;
           
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Image = global::BD_Grupo3_VS.Properties.Resources.Cita_Nueva;
            this.BTN_Agregar.Location = new System.Drawing.Point(512, 223);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(80, 92);
            this.BTN_Agregar.TabIndex = 16;
            this.BTN_Agregar.Text = "Agregar Cita";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Estado
            // 
            this.TXT_Estado.Location = new System.Drawing.Point(555, 109);
            this.TXT_Estado.Name = "TXT_Estado";
            this.TXT_Estado.Size = new System.Drawing.Size(142, 20);
            this.TXT_Estado.TabIndex = 15;
            // 
            // LBL_Estado
            // 
            this.LBL_Estado.AutoSize = true;
            this.LBL_Estado.Location = new System.Drawing.Point(443, 109);
            this.LBL_Estado.Name = "LBL_Estado";
            this.LBL_Estado.Size = new System.Drawing.Size(105, 13);
            this.LBL_Estado.TabIndex = 14;
            this.LBL_Estado.Text = "Estado del Paciente:";
            // 
            // LBL_Lugar
            // 
            this.LBL_Lugar.AutoSize = true;
            this.LBL_Lugar.Location = new System.Drawing.Point(443, 169);
            this.LBL_Lugar.Name = "LBL_Lugar";
            this.LBL_Lugar.Size = new System.Drawing.Size(37, 13);
            this.LBL_Lugar.TabIndex = 12;
            this.LBL_Lugar.Text = "Lugar:";
            // 
            // TXT_Duracion
            // 
            this.TXT_Duracion.Location = new System.Drawing.Point(555, 46);
            this.TXT_Duracion.Name = "TXT_Duracion";
            this.TXT_Duracion.Size = new System.Drawing.Size(142, 20);
            this.TXT_Duracion.TabIndex = 11;
            this.toolTip1.SetToolTip(this.TXT_Duracion, "Digite la duración de la cita en horas");
            // 
            // LBL_Duracion
            // 
            this.LBL_Duracion.AutoSize = true;
            this.LBL_Duracion.Location = new System.Drawing.Point(443, 48);
            this.LBL_Duracion.Name = "LBL_Duracion";
            this.LBL_Duracion.Size = new System.Drawing.Size(93, 13);
            this.LBL_Duracion.TabIndex = 10;
            this.LBL_Duracion.Text = "Duración (Horas): ";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(114, 295);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(142, 20);
            this.TXT_Descripcion.TabIndex = 9;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(10, 298);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.LBL_Descripcion.TabIndex = 8;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Precio
            // 
            this.TXT_Precio.Location = new System.Drawing.Point(114, 231);
            this.TXT_Precio.Name = "TXT_Precio";
            this.TXT_Precio.Size = new System.Drawing.Size(142, 20);
            this.TXT_Precio.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TXT_Precio, "Digite el precio a cobrar");
            // 
            // LBL_Precio
            // 
            this.LBL_Precio.AutoSize = true;
            this.LBL_Precio.Location = new System.Drawing.Point(12, 231);
            this.LBL_Precio.Name = "LBL_Precio";
            this.LBL_Precio.Size = new System.Drawing.Size(40, 13);
            this.LBL_Precio.TabIndex = 6;
            this.LBL_Precio.Text = "Precio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // LBL_FechaHora
            // 
            this.LBL_FechaHora.AutoSize = true;
            this.LBL_FechaHora.Location = new System.Drawing.Point(12, 169);
            this.LBL_FechaHora.Name = "LBL_FechaHora";
            this.LBL_FechaHora.Size = new System.Drawing.Size(74, 13);
            this.LBL_FechaHora.TabIndex = 4;
            this.LBL_FechaHora.Text = "Fecha y Hora:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(114, 48);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(142, 20);
            this.TXT_Cedula.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula del paciente");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(12, 109);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 1;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(12, 48);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 23;
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
            // CB_Padecimiento
            // 
            this.CB_Padecimiento.FormattingEnabled = true;
            this.CB_Padecimiento.Location = new System.Drawing.Point(114, 106);
            this.CB_Padecimiento.Name = "CB_Padecimiento";
            this.CB_Padecimiento.Size = new System.Drawing.Size(142, 21);
            this.CB_Padecimiento.TabIndex = 19;
            
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 472);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_AgregarCita);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarCita";
            this.Text = "AgregarCita";
            this.Load += new System.EventHandler(this.AgregarCita_Load);
            this.GB_AgregarCita.ResumeLayout(false);
            this.GB_AgregarCita.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_AgregarCita;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LBL_FechaHora;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Duracion;
        private System.Windows.Forms.Label LBL_Duracion;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.Label LBL_Descripcion;
        private System.Windows.Forms.TextBox TXT_Precio;
        private System.Windows.Forms.Label LBL_Precio;
        private System.Windows.Forms.TextBox TXT_Estado;
        private System.Windows.Forms.Label LBL_Estado;
        private System.Windows.Forms.Label LBL_Lugar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.ComboBox CB_Lugar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Lista;
        private System.Windows.Forms.ComboBox CB_Padecimiento;
    }
}