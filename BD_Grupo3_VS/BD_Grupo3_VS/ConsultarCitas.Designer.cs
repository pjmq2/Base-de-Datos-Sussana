namespace BD_Grupo3_VS
{
    partial class ConsultarCitas
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
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LINK_Agregar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LINK_Modificar = new System.Windows.Forms.LinkLabel();
            this.LINK_Eliminar = new System.Windows.Forms.LinkLabel();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.TXT_Fecha = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(309, 23);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(215, 33);
            this.LBL_Titulo.TabIndex = 0;
            this.LBL_Titulo.Text = "Consultar Citas";
            // 
            // LINK_Agregar
            // 
            this.LINK_Agregar.AutoSize = true;
            this.LINK_Agregar.Location = new System.Drawing.Point(21, 23);
            this.LINK_Agregar.Name = "LINK_Agregar";
            this.LINK_Agregar.Size = new System.Drawing.Size(65, 13);
            this.LINK_Agregar.TabIndex = 1;
            this.LINK_Agregar.TabStop = true;
            this.LINK_Agregar.Text = "Agregar Cita";
            this.LINK_Agregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_Agregar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puede realizar la consulta por cédula o por día, o por la combinación de ambas";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(57, 122);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 3;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LINK_Modificar
            // 
            this.LINK_Modificar.AutoSize = true;
            this.LINK_Modificar.Location = new System.Drawing.Point(117, 23);
            this.LINK_Modificar.Name = "LINK_Modificar";
            this.LINK_Modificar.Size = new System.Drawing.Size(71, 13);
            this.LINK_Modificar.TabIndex = 4;
            this.LINK_Modificar.TabStop = true;
            this.LINK_Modificar.Text = "Modificar Cita";
            // 
            // LINK_Eliminar
            // 
            this.LINK_Eliminar.AutoSize = true;
            this.LINK_Eliminar.Location = new System.Drawing.Point(653, 23);
            this.LINK_Eliminar.Name = "LINK_Eliminar";
            this.LINK_Eliminar.Size = new System.Drawing.Size(64, 13);
            this.LINK_Eliminar.TabIndex = 5;
            this.LINK_Eliminar.TabStop = true;
            this.LINK_Eliminar.Text = "Eliminar Cita";
            this.LINK_Eliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_Eliminar_LinkClicked);
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(745, 23);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(89, 13);
            this.LINK_Menu.TabIndex = 6;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Al Menú Principal";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(122, 120);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite la cédula del paciente a buscar");
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Location = new System.Drawing.Point(340, 122);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(128, 13);
            this.LBL_Fecha.TabIndex = 8;
            this.LBL_Fecha.Text = "Fecha (Día, Mes u Hora):";
            // 
            // TXT_Fecha
            // 
            this.TXT_Fecha.Location = new System.Drawing.Point(485, 119);
            this.TXT_Fecha.Name = "TXT_Fecha";
            this.TXT_Fecha.Size = new System.Drawing.Size(154, 20);
            this.TXT_Fecha.TabIndex = 9;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(60, 155);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(735, 293);
            this.dgv1.TabIndex = 10;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(677, 109);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(118, 31);
            this.BTN_Buscar.TabIndex = 11;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // ConsultarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 460);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.TXT_Fecha);
            this.Controls.Add(this.LBL_Fecha);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.LINK_Eliminar);
            this.Controls.Add(this.LINK_Modificar);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LINK_Agregar);
            this.Controls.Add(this.LBL_Titulo);
            this.Name = "ConsultarCitas";
            this.Text = "ConsultarCitas";
            this.Load += new System.EventHandler(this.ConsultarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.LinkLabel LINK_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.LinkLabel LINK_Modificar;
        private System.Windows.Forms.LinkLabel LINK_Eliminar;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.TextBox TXT_Fecha;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button BTN_Buscar;
    }
}