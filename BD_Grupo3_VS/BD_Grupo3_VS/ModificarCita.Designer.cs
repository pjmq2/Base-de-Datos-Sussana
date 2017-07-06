namespace BD_Grupo3_VS
{
    partial class ModificarCita
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
            this.GB_Modificar = new System.Windows.Forms.GroupBox();
            this.DTP_FechaAnt = new System.Windows.Forms.DateTimePicker();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.TXT_Estado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Lugar = new System.Windows.Forms.ComboBox();
            this.LBL_Lugar = new System.Windows.Forms.Label();
            this.TXT_Duracion = new System.Windows.Forms.TextBox();
            this.LBL_Duracion = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.LBL_Descripcion = new System.Windows.Forms.Label();
            this.TXT_Precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_CeduModificar = new System.Windows.Forms.TextBox();
            this.LBL_CedulaEliminar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_Modificar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(480, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Cita";
            // 
            // GB_Modificar
            // 
            this.GB_Modificar.Controls.Add(this.DTP_FechaAnt);
            this.GB_Modificar.Controls.Add(this.BTN_Modificar);
            this.GB_Modificar.Controls.Add(this.TXT_Estado);
            this.GB_Modificar.Controls.Add(this.label7);
            this.GB_Modificar.Controls.Add(this.CB_Lugar);
            this.GB_Modificar.Controls.Add(this.LBL_Lugar);
            this.GB_Modificar.Controls.Add(this.TXT_Duracion);
            this.GB_Modificar.Controls.Add(this.LBL_Duracion);
            this.GB_Modificar.Controls.Add(this.TXT_Descripcion);
            this.GB_Modificar.Controls.Add(this.LBL_Descripcion);
            this.GB_Modificar.Controls.Add(this.TXT_Precio);
            this.GB_Modificar.Controls.Add(this.label6);
            this.GB_Modificar.Controls.Add(this.dtp_Fecha);
            this.GB_Modificar.Controls.Add(this.LBL_Fecha);
            this.GB_Modificar.Controls.Add(this.TXT_Padecimiento);
            this.GB_Modificar.Controls.Add(this.LBL_Padecimiento);
            this.GB_Modificar.Controls.Add(this.TXT_Cedula);
            this.GB_Modificar.Controls.Add(this.label5);
            this.GB_Modificar.Controls.Add(this.label4);
            this.GB_Modificar.Controls.Add(this.label3);
            this.GB_Modificar.Controls.Add(this.TXT_CeduModificar);
            this.GB_Modificar.Controls.Add(this.LBL_CedulaEliminar);
            this.GB_Modificar.Controls.Add(this.label2);
            this.GB_Modificar.Controls.Add(this.splitter1);
            this.GB_Modificar.Location = new System.Drawing.Point(32, 111);
            this.GB_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Modificar.Name = "GB_Modificar";
            this.GB_Modificar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Modificar.Size = new System.Drawing.Size(1181, 468);
            this.GB_Modificar.TabIndex = 1;
            this.GB_Modificar.TabStop = false;
            this.GB_Modificar.Text = "Modificar Cita";
            // 
            // DTP_FechaAnt
            // 
            this.DTP_FechaAnt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_FechaAnt.Location = new System.Drawing.Point(27, 284);
            this.DTP_FechaAnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_FechaAnt.Name = "DTP_FechaAnt";
            this.DTP_FechaAnt.Size = new System.Drawing.Size(215, 22);
            this.DTP_FechaAnt.TabIndex = 24;
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(1015, 406);
            this.BTN_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(151, 44);
            this.BTN_Modificar.TabIndex = 23;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // TXT_Estado
            // 
            this.TXT_Estado.Location = new System.Drawing.Point(881, 242);
            this.TXT_Estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Estado.Name = "TXT_Estado";
            this.TXT_Estado.Size = new System.Drawing.Size(197, 22);
            this.TXT_Estado.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado Paciente:";
            // 
            // CB_Lugar
            // 
            this.CB_Lugar.FormattingEnabled = true;
            this.CB_Lugar.Items.AddRange(new object[] {
            "Consultorio",
            "Domicilio"});
            this.CB_Lugar.Location = new System.Drawing.Point(845, 166);
            this.CB_Lugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Lugar.Name = "CB_Lugar";
            this.CB_Lugar.Size = new System.Drawing.Size(188, 24);
            this.CB_Lugar.TabIndex = 20;
            // 
            // LBL_Lugar
            // 
            this.LBL_Lugar.AutoSize = true;
            this.LBL_Lugar.Location = new System.Drawing.Point(741, 169);
            this.LBL_Lugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Lugar.Name = "LBL_Lugar";
            this.LBL_Lugar.Size = new System.Drawing.Size(49, 17);
            this.LBL_Lugar.TabIndex = 19;
            this.LBL_Lugar.Text = "Lugar:";
            // 
            // TXT_Duracion
            // 
            this.TXT_Duracion.Location = new System.Drawing.Point(833, 91);
            this.TXT_Duracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Duracion.Name = "TXT_Duracion";
            this.TXT_Duracion.Size = new System.Drawing.Size(201, 22);
            this.TXT_Duracion.TabIndex = 18;
            // 
            // LBL_Duracion
            // 
            this.LBL_Duracion.AutoSize = true;
            this.LBL_Duracion.Location = new System.Drawing.Point(741, 95);
            this.LBL_Duracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Duracion.Name = "LBL_Duracion";
            this.LBL_Duracion.Size = new System.Drawing.Size(69, 17);
            this.LBL_Duracion.TabIndex = 17;
            this.LBL_Duracion.Text = "Duración:";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(437, 373);
            this.TXT_Descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(175, 22);
            this.TXT_Descripcion.TabIndex = 16;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(327, 377);
            this.LBL_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(86, 17);
            this.LBL_Descripcion.TabIndex = 15;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Precio
            // 
            this.TXT_Precio.Location = new System.Drawing.Point(401, 305);
            this.TXT_Precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Precio.Name = "TXT_Precio";
            this.TXT_Precio.Size = new System.Drawing.Size(211, 22);
            this.TXT_Precio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Fecha.Location = new System.Drawing.Point(416, 236);
            this.dtp_Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(196, 22);
            this.dtp_Fecha.TabIndex = 12;
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Location = new System.Drawing.Point(327, 240);
            this.LBL_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(51, 17);
            this.LBL_Fecha.TabIndex = 11;
            this.LBL_Fecha.Text = "Fecha:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(455, 165);
            this.TXT_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(183, 22);
            this.TXT_Padecimiento.TabIndex = 10;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(327, 172);
            this.LBL_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(97, 17);
            this.LBL_Padecimiento.TabIndex = 9;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(419, 101);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(195, 22);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite los nuevos datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // TXT_CeduModificar
            // 
            this.TXT_CeduModificar.Location = new System.Drawing.Point(27, 169);
            this.TXT_CeduModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CeduModificar.Name = "TXT_CeduModificar";
            this.TXT_CeduModificar.Size = new System.Drawing.Size(215, 22);
            this.TXT_CeduModificar.TabIndex = 3;
            // 
            // LBL_CedulaEliminar
            // 
            this.LBL_CedulaEliminar.AutoSize = true;
            this.LBL_CedulaEliminar.Location = new System.Drawing.Point(23, 134);
            this.LBL_CedulaEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CedulaEliminar.Name = "LBL_CedulaEliminar";
            this.LBL_CedulaEliminar.Size = new System.Drawing.Size(56, 17);
            this.LBL_CedulaEliminar.TabIndex = 2;
            this.LBL_CedulaEliminar.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite la cédula del paciente y la fecha de\r\nla cita que desea modificar";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(4, 19);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(297, 445);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 48;
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
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 613);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_Modificar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarCita";
            this.Text = "ModificarCita";
            this.Load += new System.EventHandler(this.ModificarCita_Load);
            this.GB_Modificar.ResumeLayout(false);
            this.GB_Modificar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CeduModificar;
        private System.Windows.Forms.Label LBL_CedulaEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LBL_Lugar;
        private System.Windows.Forms.TextBox TXT_Duracion;
        private System.Windows.Forms.Label LBL_Duracion;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.Label LBL_Descripcion;
        private System.Windows.Forms.TextBox TXT_Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.TextBox TXT_Estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Lugar;
        private System.Windows.Forms.DateTimePicker DTP_FechaAnt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}