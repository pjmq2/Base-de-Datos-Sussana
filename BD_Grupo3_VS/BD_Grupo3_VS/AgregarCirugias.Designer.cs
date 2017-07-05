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
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_ListaPacientes = new System.Windows.Forms.LinkLabel();
            this.LNK_AgregarDatosClinicos = new System.Windows.Forms.LinkLabel();
            this.LINK_AgregarPaciente = new System.Windows.Forms.LinkLabel();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.CMB_Nombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Cirugia = new System.Windows.Forms.TextBox();
            this.DGV_CedPaciente = new System.Windows.Forms.DataGridView();
            this.BTN_AgregarCirugia = new System.Windows.Forms.Button();
            this.LBL_FiltroGeneral = new System.Windows.Forms.Label();
            this.TXT_FiltroGeneral = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CedPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Cirugías
            // 
            this.LBL_Cirugías.AutoSize = true;
            this.LBL_Cirugías.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Cirugías.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Cirugías.Location = new System.Drawing.Point(211, 22);
            this.LBL_Cirugías.Name = "LBL_Cirugías";
            this.LBL_Cirugías.Size = new System.Drawing.Size(123, 33);
            this.LBL_Cirugías.TabIndex = 5;
            this.LBL_Cirugías.Text = "Cirugías";
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.LinkColor = System.Drawing.Color.Blue;
            this.LINK_Menu.Location = new System.Drawing.Point(474, 22);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(97, 13);
            this.LINK_Menu.TabIndex = 8;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Ir al Menú Principal";
            // 
            // LINK_ListaPacientes
            // 
            this.LINK_ListaPacientes.AutoSize = true;
            this.LINK_ListaPacientes.Location = new System.Drawing.Point(474, 42);
            this.LINK_ListaPacientes.Name = "LINK_ListaPacientes";
            this.LINK_ListaPacientes.Size = new System.Drawing.Size(112, 13);
            this.LINK_ListaPacientes.TabIndex = 9;
            this.LINK_ListaPacientes.TabStop = true;
            this.LINK_ListaPacientes.Text = "Ir a Lista de Pacientes";
            // 
            // LNK_AgregarDatosClinicos
            // 
            this.LNK_AgregarDatosClinicos.AutoSize = true;
            this.LNK_AgregarDatosClinicos.Location = new System.Drawing.Point(12, 22);
            this.LNK_AgregarDatosClinicos.Name = "LNK_AgregarDatosClinicos";
            this.LNK_AgregarDatosClinicos.Size = new System.Drawing.Size(116, 13);
            this.LNK_AgregarDatosClinicos.TabIndex = 27;
            this.LNK_AgregarDatosClinicos.TabStop = true;
            this.LNK_AgregarDatosClinicos.Text = "Agregar Datos Clínicos";
            // 
            // LINK_AgregarPaciente
            // 
            this.LINK_AgregarPaciente.AutoSize = true;
            this.LINK_AgregarPaciente.Location = new System.Drawing.Point(12, 42);
            this.LINK_AgregarPaciente.Name = "LINK_AgregarPaciente";
            this.LINK_AgregarPaciente.Size = new System.Drawing.Size(89, 13);
            this.LINK_AgregarPaciente.TabIndex = 28;
            this.LINK_AgregarPaciente.TabStop = true;
            this.LINK_AgregarPaciente.Text = "Agregar Paciente";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(20, 112);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(108, 13);
            this.LBL_Nombre.TabIndex = 29;
            this.LBL_Nombre.Text = "Nombre del paciente:";
            // 
            // CMB_Nombre
            // 
            this.CMB_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Nombre.FormattingEnabled = true;
            this.CMB_Nombre.Location = new System.Drawing.Point(151, 109);
            this.CMB_Nombre.Name = "CMB_Nombre";
            this.CMB_Nombre.Size = new System.Drawing.Size(121, 21);
            this.CMB_Nombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cirugía:";
            // 
            // TXT_Cirugia
            // 
            this.TXT_Cirugia.Location = new System.Drawing.Point(428, 159);
            this.TXT_Cirugia.Name = "TXT_Cirugia";
            this.TXT_Cirugia.Size = new System.Drawing.Size(121, 20);
            this.TXT_Cirugia.TabIndex = 32;
            // 
            // DGV_CedPaciente
            // 
            this.DGV_CedPaciente.AllowUserToAddRows = false;
            this.DGV_CedPaciente.AllowUserToDeleteRows = false;
            this.DGV_CedPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CedPaciente.Location = new System.Drawing.Point(23, 253);
            this.DGV_CedPaciente.Name = "DGV_CedPaciente";
            this.DGV_CedPaciente.ReadOnly = true;
            this.DGV_CedPaciente.Size = new System.Drawing.Size(218, 36);
            this.DGV_CedPaciente.TabIndex = 33;
            // 
            // BTN_AgregarCirugia
            // 
            this.BTN_AgregarCirugia.Location = new System.Drawing.Point(449, 210);
            this.BTN_AgregarCirugia.Name = "BTN_AgregarCirugia";
            this.BTN_AgregarCirugia.Size = new System.Drawing.Size(100, 27);
            this.BTN_AgregarCirugia.TabIndex = 34;
            this.BTN_AgregarCirugia.Text = "Agregar cirugía";
            this.BTN_AgregarCirugia.UseVisualStyleBackColor = true;
            // 
            // LBL_FiltroGeneral
            // 
            this.LBL_FiltroGeneral.AutoSize = true;
            this.LBL_FiltroGeneral.Location = new System.Drawing.Point(20, 149);
            this.LBL_FiltroGeneral.Name = "LBL_FiltroGeneral";
            this.LBL_FiltroGeneral.Size = new System.Drawing.Size(72, 13);
            this.LBL_FiltroGeneral.TabIndex = 35;
            this.LBL_FiltroGeneral.Text = "Filtro General:";
            // 
            // TXT_FiltroGeneral
            // 
            this.TXT_FiltroGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroGeneral.Location = new System.Drawing.Point(151, 146);
            this.TXT_FiltroGeneral.Name = "TXT_FiltroGeneral";
            this.TXT_FiltroGeneral.Size = new System.Drawing.Size(121, 20);
            this.TXT_FiltroGeneral.TabIndex = 36;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(23, 187);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(78, 26);
            this.BTN_Buscar.TabIndex = 37;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // AgregarCirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 396);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_FiltroGeneral);
            this.Controls.Add(this.LBL_FiltroGeneral);
            this.Controls.Add(this.BTN_AgregarCirugia);
            this.Controls.Add(this.DGV_CedPaciente);
            this.Controls.Add(this.TXT_Cirugia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMB_Nombre);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.LINK_AgregarPaciente);
            this.Controls.Add(this.LNK_AgregarDatosClinicos);
            this.Controls.Add(this.LINK_ListaPacientes);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.LBL_Cirugías);
            this.Name = "AgregarCirugias";
            this.Text = "AgregarCirugias";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CedPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Cirugías;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.LinkLabel LINK_ListaPacientes;
        private System.Windows.Forms.LinkLabel LNK_AgregarDatosClinicos;
        private System.Windows.Forms.LinkLabel LINK_AgregarPaciente;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.ComboBox CMB_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Cirugia;
        private System.Windows.Forms.DataGridView DGV_CedPaciente;
        private System.Windows.Forms.Button BTN_AgregarCirugia;
        private System.Windows.Forms.Label LBL_FiltroGeneral;
        private System.Windows.Forms.TextBox TXT_FiltroGeneral;
        private System.Windows.Forms.Button BTN_Buscar;
    }
}