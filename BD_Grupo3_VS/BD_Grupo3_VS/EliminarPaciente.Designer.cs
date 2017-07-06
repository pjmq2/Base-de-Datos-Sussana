namespace BD_Grupo3_VS
{
    partial class EliminarPaciente
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
            this.LBL__EliminarPaciente = new System.Windows.Forms.Label();
            this.LNK_Menu = new System.Windows.Forms.LinkLabel();
            this.LNK_AgregarPaciente = new System.Windows.Forms.LinkLabel();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL__EliminarPaciente
            // 
            this.LBL__EliminarPaciente.AutoSize = true;
            this.LBL__EliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL__EliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL__EliminarPaciente.ForeColor = System.Drawing.Color.Maroon;
            this.LBL__EliminarPaciente.Location = new System.Drawing.Point(26, 22);
            this.LBL__EliminarPaciente.Name = "LBL__EliminarPaciente";
            this.LBL__EliminarPaciente.Size = new System.Drawing.Size(271, 31);
            this.LBL__EliminarPaciente.TabIndex = 15;
            this.LBL__EliminarPaciente.Text = "Borrado de pacientes";
            // 
            // LNK_Menu
            // 
            this.LNK_Menu.AutoSize = true;
            this.LNK_Menu.Location = new System.Drawing.Point(546, 22);
            this.LNK_Menu.Name = "LNK_Menu";
            this.LNK_Menu.Size = new System.Drawing.Size(119, 13);
            this.LNK_Menu.TabIndex = 24;
            this.LNK_Menu.TabStop = true;
            this.LNK_Menu.Text = "Volver al menú principal";
            // 
            // LNK_AgregarPaciente
            // 
            this.LNK_AgregarPaciente.AutoSize = true;
            this.LNK_AgregarPaciente.Location = new System.Drawing.Point(546, 40);
            this.LNK_AgregarPaciente.Name = "LNK_AgregarPaciente";
            this.LNK_AgregarPaciente.Size = new System.Drawing.Size(88, 13);
            this.LNK_AgregarPaciente.TabIndex = 25;
            this.LNK_AgregarPaciente.TabStop = true;
            this.LNK_AgregarPaciente.Text = "Agregar paciente";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(29, 79);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 26;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Pacientes.Location = new System.Drawing.Point(32, 110);
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.Size = new System.Drawing.Size(633, 325);
            this.DGV_Pacientes.TabIndex = 27;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(549, 74);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(85, 26);
            this.BTN_Eliminar.TabIndex = 28;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(97, 76);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 29;
            // 
            // EliminarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 447);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.DGV_Pacientes);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LNK_AgregarPaciente);
            this.Controls.Add(this.LNK_Menu);
            this.Controls.Add(this.LBL__EliminarPaciente);
            this.Name = "EliminarPaciente";
            this.Text = "EliminarPaciente";
            this.Load += new System.EventHandler(this.EliminarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL__EliminarPaciente;
        private System.Windows.Forms.LinkLabel LNK_Menu;
        private System.Windows.Forms.LinkLabel LNK_AgregarPaciente;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.DataGridView DGV_Pacientes;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.TextBox TXT_Cedula;
    }
}