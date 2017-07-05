namespace BD_Grupo3_VS
{
    partial class ConsultarPaciente
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
            this.LBL_ConsultaDePacientes = new System.Windows.Forms.Label();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_AgregarPaciente = new System.Windows.Forms.LinkLabel();
            this.LBL_FiltroNombre = new System.Windows.Forms.Label();
            this.LBL_FiltroGeneral = new System.Windows.Forms.Label();
            this.TXT_FiltroGeneral = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_FiltroNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDePacientes
            // 
            this.LBL_ConsultaDePacientes.AutoSize = true;
            this.LBL_ConsultaDePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDePacientes.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_ConsultaDePacientes.Location = new System.Drawing.Point(21, 26);
            this.LBL_ConsultaDePacientes.Name = "LBL_ConsultaDePacientes";
            this.LBL_ConsultaDePacientes.Size = new System.Drawing.Size(306, 33);
            this.LBL_ConsultaDePacientes.TabIndex = 3;
            this.LBL_ConsultaDePacientes.Text = "Consulta de Pacientes";
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(631, 26);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(97, 13);
            this.LINK_Menu.TabIndex = 4;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Ir al Menú Principal";
            // 
            // LINK_AgregarPaciente
            // 
            this.LINK_AgregarPaciente.AutoSize = true;
            this.LINK_AgregarPaciente.Location = new System.Drawing.Point(631, 46);
            this.LINK_AgregarPaciente.Name = "LINK_AgregarPaciente";
            this.LINK_AgregarPaciente.Size = new System.Drawing.Size(89, 13);
            this.LINK_AgregarPaciente.TabIndex = 9;
            this.LINK_AgregarPaciente.TabStop = true;
            this.LINK_AgregarPaciente.Text = "Agregar Paciente";
            // 
            // LBL_FiltroNombre
            // 
            this.LBL_FiltroNombre.AutoSize = true;
            this.LBL_FiltroNombre.Location = new System.Drawing.Point(46, 121);
            this.LBL_FiltroNombre.Name = "LBL_FiltroNombre";
            this.LBL_FiltroNombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_FiltroNombre.TabIndex = 10;
            this.LBL_FiltroNombre.Text = "Nombre:";
            // 
            // LBL_FiltroGeneral
            // 
            this.LBL_FiltroGeneral.AutoSize = true;
            this.LBL_FiltroGeneral.Location = new System.Drawing.Point(308, 121);
            this.LBL_FiltroGeneral.Name = "LBL_FiltroGeneral";
            this.LBL_FiltroGeneral.Size = new System.Drawing.Size(72, 13);
            this.LBL_FiltroGeneral.TabIndex = 12;
            this.LBL_FiltroGeneral.Text = "Filtro General:";
            // 
            // TXT_FiltroGeneral
            // 
            this.TXT_FiltroGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroGeneral.Location = new System.Drawing.Point(406, 119);
            this.TXT_FiltroGeneral.Name = "TXT_FiltroGeneral";
            this.TXT_FiltroGeneral.Size = new System.Drawing.Size(146, 20);
            this.TXT_FiltroGeneral.TabIndex = 13;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(627, 113);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(93, 30);
            this.BTN_Buscar.TabIndex = 15;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(49, 182);
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.Size = new System.Drawing.Size(671, 321);
            this.DGV_Pacientes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "En el filtro general puede ingresar apellido o cédula";
            // 
            // TXT_FiltroNombre
            // 
            this.TXT_FiltroNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_FiltroNombre.Location = new System.Drawing.Point(112, 118);
            this.TXT_FiltroNombre.Name = "TXT_FiltroNombre";
            this.TXT_FiltroNombre.Size = new System.Drawing.Size(146, 20);
            this.TXT_FiltroNombre.TabIndex = 18;
            // 
            // ConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 515);
            this.Controls.Add(this.TXT_FiltroNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Pacientes);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_FiltroGeneral);
            this.Controls.Add(this.LBL_FiltroGeneral);
            this.Controls.Add(this.LBL_FiltroNombre);
            this.Controls.Add(this.LINK_AgregarPaciente);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.LBL_ConsultaDePacientes);
            this.Name = "ConsultarPaciente";
            this.Text = "ConsultarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ConsultaDePacientes;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.LinkLabel LINK_AgregarPaciente;
        private System.Windows.Forms.Label LBL_FiltroNombre;
        private System.Windows.Forms.Label LBL_FiltroGeneral;
        private System.Windows.Forms.TextBox TXT_FiltroGeneral;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.DataGridView DGV_Pacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_FiltroNombre;
    }
}