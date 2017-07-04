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
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_ConsultarCita = new System.Windows.Forms.LinkLabel();
            this.LINK_Modificar = new System.Windows.Forms.LinkLabel();
            this.LINK_Eliminar = new System.Windows.Forms.LinkLabel();
            this.GB_AgregarCita = new System.Windows.Forms.GroupBox();
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
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GB_AgregarCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(452, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita";
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.LinkColor = System.Drawing.Color.Blue;
            this.LINK_Menu.Location = new System.Drawing.Point(873, 32);
            this.LINK_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(128, 17);
            this.LINK_Menu.TabIndex = 1;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Ir al Menú Principal";
            // 
            // LINK_ConsultarCita
            // 
            this.LINK_ConsultarCita.AutoSize = true;
            this.LINK_ConsultarCita.Location = new System.Drawing.Point(33, 32);
            this.LINK_ConsultarCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_ConsultarCita.Name = "LINK_ConsultarCita";
            this.LINK_ConsultarCita.Size = new System.Drawing.Size(103, 17);
            this.LINK_ConsultarCita.TabIndex = 2;
            this.LINK_ConsultarCita.TabStop = true;
            this.LINK_ConsultarCita.Text = "Consultar Citas";
            this.LINK_ConsultarCita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_ConsultarCita_LinkClicked);
            // 
            // LINK_Modificar
            // 
            this.LINK_Modificar.AutoSize = true;
            this.LINK_Modificar.Location = new System.Drawing.Point(183, 32);
            this.LINK_Modificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Modificar.Name = "LINK_Modificar";
            this.LINK_Modificar.Size = new System.Drawing.Size(93, 17);
            this.LINK_Modificar.TabIndex = 3;
            this.LINK_Modificar.TabStop = true;
            this.LINK_Modificar.Text = "Modificar Cita";
            // 
            // LINK_Eliminar
            // 
            this.LINK_Eliminar.AutoSize = true;
            this.LINK_Eliminar.Location = new System.Drawing.Point(732, 32);
            this.LINK_Eliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Eliminar.Name = "LINK_Eliminar";
            this.LINK_Eliminar.Size = new System.Drawing.Size(86, 17);
            this.LINK_Eliminar.TabIndex = 4;
            this.LINK_Eliminar.TabStop = true;
            this.LINK_Eliminar.Text = "Eliminar Cita";
            this.LINK_Eliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_Eliminar_LinkClicked);
            // 
            // GB_AgregarCita
            // 
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
            this.GB_AgregarCita.Controls.Add(this.TXT_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.TXT_Cedula);
            this.GB_AgregarCita.Controls.Add(this.LBL_Padecimiento);
            this.GB_AgregarCita.Controls.Add(this.LBL_Cedula);
            this.GB_AgregarCita.Location = new System.Drawing.Point(35, 124);
            this.GB_AgregarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_AgregarCita.Name = "GB_AgregarCita";
            this.GB_AgregarCita.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_AgregarCita.Size = new System.Drawing.Size(953, 418);
            this.GB_AgregarCita.TabIndex = 5;
            this.GB_AgregarCita.TabStop = false;
            this.GB_AgregarCita.Text = "Agregar una Cita";
            // 
            // CB_Lugar
            // 
            this.CB_Lugar.FormattingEnabled = true;
            this.CB_Lugar.Items.AddRange(new object[] {
            "Consultorio",
            "Domicilio"});
            this.CB_Lugar.Location = new System.Drawing.Point(740, 212);
            this.CB_Lugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Lugar.Name = "CB_Lugar";
            this.CB_Lugar.Size = new System.Drawing.Size(188, 24);
            this.CB_Lugar.TabIndex = 17;
            this.CB_Lugar.SelectedIndexChanged += new System.EventHandler(this.CB_Lugar_SelectedIndexChanged);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(797, 351);
            this.BTN_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(132, 48);
            this.BTN_Agregar.TabIndex = 16;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Estado
            // 
            this.TXT_Estado.Location = new System.Drawing.Point(740, 134);
            this.TXT_Estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Estado.Name = "TXT_Estado";
            this.TXT_Estado.Size = new System.Drawing.Size(188, 22);
            this.TXT_Estado.TabIndex = 15;
            // 
            // LBL_Estado
            // 
            this.LBL_Estado.AutoSize = true;
            this.LBL_Estado.Location = new System.Drawing.Point(591, 134);
            this.LBL_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Estado.Name = "LBL_Estado";
            this.LBL_Estado.Size = new System.Drawing.Size(138, 17);
            this.LBL_Estado.TabIndex = 14;
            this.LBL_Estado.Text = "Estado del Paciente:";
            // 
            // LBL_Lugar
            // 
            this.LBL_Lugar.AutoSize = true;
            this.LBL_Lugar.Location = new System.Drawing.Point(591, 208);
            this.LBL_Lugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Lugar.Name = "LBL_Lugar";
            this.LBL_Lugar.Size = new System.Drawing.Size(49, 17);
            this.LBL_Lugar.TabIndex = 12;
            this.LBL_Lugar.Text = "Lugar:";
            // 
            // TXT_Duracion
            // 
            this.TXT_Duracion.Location = new System.Drawing.Point(740, 57);
            this.TXT_Duracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Duracion.Name = "TXT_Duracion";
            this.TXT_Duracion.Size = new System.Drawing.Size(188, 22);
            this.TXT_Duracion.TabIndex = 11;
            this.toolTip1.SetToolTip(this.TXT_Duracion, "Digite la duración de la cita en horas");
            // 
            // LBL_Duracion
            // 
            this.LBL_Duracion.AutoSize = true;
            this.LBL_Duracion.Location = new System.Drawing.Point(591, 59);
            this.LBL_Duracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Duracion.Name = "LBL_Duracion";
            this.LBL_Duracion.Size = new System.Drawing.Size(125, 17);
            this.LBL_Duracion.TabIndex = 10;
            this.LBL_Duracion.Text = "Duración (Horas): ";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(152, 363);
            this.TXT_Descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(188, 22);
            this.TXT_Descripcion.TabIndex = 9;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(13, 367);
            this.LBL_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(86, 17);
            this.LBL_Descripcion.TabIndex = 8;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Precio
            // 
            this.TXT_Precio.Location = new System.Drawing.Point(152, 284);
            this.TXT_Precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Precio.Name = "TXT_Precio";
            this.TXT_Precio.Size = new System.Drawing.Size(188, 22);
            this.TXT_Precio.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TXT_Precio, "Digite el precio a cobrar");
            // 
            // LBL_Precio
            // 
            this.LBL_Precio.AutoSize = true;
            this.LBL_Precio.Location = new System.Drawing.Point(16, 284);
            this.LBL_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Precio.Name = "LBL_Precio";
            this.LBL_Precio.Size = new System.Drawing.Size(52, 17);
            this.LBL_Precio.TabIndex = 6;
            this.LBL_Precio.Text = "Precio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 208);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // LBL_FechaHora
            // 
            this.LBL_FechaHora.AutoSize = true;
            this.LBL_FechaHora.Location = new System.Drawing.Point(16, 208);
            this.LBL_FechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FechaHora.Name = "LBL_FechaHora";
            this.LBL_FechaHora.Size = new System.Drawing.Size(97, 17);
            this.LBL_FechaHora.TabIndex = 4;
            this.LBL_FechaHora.Text = "Fecha y Hora:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(152, 134);
            this.TXT_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(188, 22);
            this.TXT_Padecimiento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento actual del paciente");
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(152, 59);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(188, 22);
            this.TXT_Cedula.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula del paciente");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(16, 134);
            this.LBL_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(97, 17);
            this.LBL_Padecimiento.TabIndex = 1;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(16, 59);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 0;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 581);
            this.Controls.Add(this.GB_AgregarCita);
            this.Controls.Add(this.LINK_Eliminar);
            this.Controls.Add(this.LINK_Modificar);
            this.Controls.Add(this.LINK_ConsultarCita);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarCita";
            this.Text = "AgregarCita";
            this.Load += new System.EventHandler(this.AgregarCita_Load);
            this.GB_AgregarCita.ResumeLayout(false);
            this.GB_AgregarCita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.LinkLabel LINK_ConsultarCita;
        private System.Windows.Forms.LinkLabel LINK_Modificar;
        private System.Windows.Forms.LinkLabel LINK_Eliminar;
        private System.Windows.Forms.GroupBox GB_AgregarCita;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LBL_FechaHora;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
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
    }
}