namespace BD_Grupo3_VS
{
    partial class EliminarCita
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
            this.LBL_Agregar = new System.Windows.Forms.LinkLabel();
            this.LBL_Consultar = new System.Windows.Forms.LinkLabel();
            this.LBL_Modificar = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Agregar
            // 
            this.LBL_Agregar.AutoSize = true;
            this.LBL_Agregar.Location = new System.Drawing.Point(25, 26);
            this.LBL_Agregar.Name = "LBL_Agregar";
            this.LBL_Agregar.Size = new System.Drawing.Size(65, 13);
            this.LBL_Agregar.TabIndex = 0;
            this.LBL_Agregar.TabStop = true;
            this.LBL_Agregar.Text = "Agregar Cita";
            this.LBL_Agregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_Agregar_LinkClicked);
            // 
            // LBL_Consultar
            // 
            this.LBL_Consultar.AutoSize = true;
            this.LBL_Consultar.Location = new System.Drawing.Point(120, 26);
            this.LBL_Consultar.Name = "LBL_Consultar";
            this.LBL_Consultar.Size = new System.Drawing.Size(77, 13);
            this.LBL_Consultar.TabIndex = 1;
            this.LBL_Consultar.TabStop = true;
            this.LBL_Consultar.Text = "Consultar Citas";
            this.LBL_Consultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_Consultar_LinkClicked);
            // 
            // LBL_Modificar
            // 
            this.LBL_Modificar.AutoSize = true;
            this.LBL_Modificar.Location = new System.Drawing.Point(622, 26);
            this.LBL_Modificar.Name = "LBL_Modificar";
            this.LBL_Modificar.Size = new System.Drawing.Size(71, 13);
            this.LBL_Modificar.TabIndex = 2;
            this.LBL_Modificar.TabStop = true;
            this.LBL_Modificar.Text = "Modificar Cita";
         
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(708, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ir al Menu Principal";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(305, 26);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(182, 33);
            this.LBL_Titulo.TabIndex = 4;
            this.LBL_Titulo.Text = "Eliminar Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(195, 95);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(156, 20);
            this.TXT_Cedula.TabIndex = 7;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(644, 86);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(115, 37);
            this.BTN_Eliminar.TabIndex = 9;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(52, 143);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.Size = new System.Drawing.Size(706, 302);
            this.dgvEliminar.TabIndex = 10;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Fecha.Location = new System.Drawing.Point(449, 95);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(156, 20);
            this.DTP_Fecha.TabIndex = 11;
            // 
            // EliminarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 474);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.dgvEliminar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LBL_Modificar);
            this.Controls.Add(this.LBL_Consultar);
            this.Controls.Add(this.LBL_Agregar);
            this.Name = "EliminarCita";
            this.Text = "EliminarCita";
            this.Load += new System.EventHandler(this.EliminarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LBL_Agregar;
        private System.Windows.Forms.LinkLabel LBL_Consultar;
        private System.Windows.Forms.LinkLabel LBL_Modificar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}