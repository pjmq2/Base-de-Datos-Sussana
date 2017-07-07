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
            this.label1.Location = new System.Drawing.Point(360, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Cita";
            // 
            // GB_Modificar
            // 
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
            this.GB_Modificar.Location = new System.Drawing.Point(24, 90);
            this.GB_Modificar.Name = "GB_Modificar";
            this.GB_Modificar.Size = new System.Drawing.Size(886, 380);
            this.GB_Modificar.TabIndex = 1;
            this.GB_Modificar.TabStop = false;
            this.GB_Modificar.Text = "Digite los nuevos datos";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(761, 330);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(113, 36);
            this.BTN_Modificar.TabIndex = 23;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // TXT_Estado
            // 
            this.TXT_Estado.Location = new System.Drawing.Point(539, 170);
            this.TXT_Estado.Name = "TXT_Estado";
            this.TXT_Estado.Size = new System.Drawing.Size(152, 20);
            this.TXT_Estado.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado Paciente:";
            // 
            // CB_Lugar
            // 
            this.CB_Lugar.FormattingEnabled = true;
            this.CB_Lugar.Items.AddRange(new object[] {
            "Consultorio",
            "Domicilio"});
            this.CB_Lugar.Location = new System.Drawing.Point(539, 107);
            this.CB_Lugar.Name = "CB_Lugar";
            this.CB_Lugar.Size = new System.Drawing.Size(152, 21);
            this.CB_Lugar.TabIndex = 20;
            // 
            // LBL_Lugar
            // 
            this.LBL_Lugar.AutoSize = true;
            this.LBL_Lugar.Location = new System.Drawing.Point(442, 111);
            this.LBL_Lugar.Name = "LBL_Lugar";
            this.LBL_Lugar.Size = new System.Drawing.Size(37, 13);
            this.LBL_Lugar.TabIndex = 19;
            this.LBL_Lugar.Text = "Lugar:";
            // 
            // TXT_Duracion
            // 
            this.TXT_Duracion.Location = new System.Drawing.Point(539, 45);
            this.TXT_Duracion.Name = "TXT_Duracion";
            this.TXT_Duracion.Size = new System.Drawing.Size(152, 20);
            this.TXT_Duracion.TabIndex = 18;
            // 
            // LBL_Duracion
            // 
            this.LBL_Duracion.AutoSize = true;
            this.LBL_Duracion.Location = new System.Drawing.Point(442, 48);
            this.LBL_Duracion.Name = "LBL_Duracion";
            this.LBL_Duracion.Size = new System.Drawing.Size(53, 13);
            this.LBL_Duracion.TabIndex = 17;
            this.LBL_Duracion.Text = "Duración:";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(116, 307);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(147, 20);
            this.TXT_Descripcion.TabIndex = 16;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(34, 310);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.LBL_Descripcion.TabIndex = 15;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Precio
            // 
            this.TXT_Precio.Location = new System.Drawing.Point(116, 248);
            this.TXT_Precio.Name = "TXT_Precio";
            this.TXT_Precio.Size = new System.Drawing.Size(147, 20);
            this.TXT_Precio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Fecha.Location = new System.Drawing.Point(116, 173);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(147, 20);
            this.dtp_Fecha.TabIndex = 12;
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Location = new System.Drawing.Point(34, 173);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(40, 13);
            this.LBL_Fecha.TabIndex = 11;
            this.LBL_Fecha.Text = "Fecha:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(116, 104);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(147, 20);
            this.TXT_Padecimiento.TabIndex = 10;
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(34, 107);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 9;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(116, 45);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(147, 20);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cédula:";
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
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.InicioToolStripMenuItem.Text = "Inicio";
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 498);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_Modificar);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}