namespace BD_Grupo3_VS
{
    partial class ConsultarAntecedentes
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
            this.LBL_ConsultaAntecedentes = new System.Windows.Forms.Label();
            this.LNK_Menu = new System.Windows.Forms.LinkLabel();
            this.LNK_AgregarAntecedente = new System.Windows.Forms.LinkLabel();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.DGV_Antecedentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Antecedentes)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ConsultaAntecedentes
            // 
            this.LBL_ConsultaAntecedentes.AutoSize = true;
            this.LBL_ConsultaAntecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaAntecedentes.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_ConsultaAntecedentes.Location = new System.Drawing.Point(22, 27);
            this.LBL_ConsultaAntecedentes.Name = "LBL_ConsultaAntecedentes";
            this.LBL_ConsultaAntecedentes.Size = new System.Drawing.Size(355, 33);
            this.LBL_ConsultaAntecedentes.TabIndex = 3;
            this.LBL_ConsultaAntecedentes.Text = "Consulta de Antecedentes";
            // 
            // LNK_Menu
            // 
            this.LNK_Menu.AutoSize = true;
            this.LNK_Menu.Location = new System.Drawing.Point(490, 27);
            this.LNK_Menu.Name = "LNK_Menu";
            this.LNK_Menu.Size = new System.Drawing.Size(119, 13);
            this.LNK_Menu.TabIndex = 16;
            this.LNK_Menu.TabStop = true;
            this.LNK_Menu.Text = "Volver al menú principal";
            // 
            // LNK_AgregarAntecedente
            // 
            this.LNK_AgregarAntecedente.AutoSize = true;
            this.LNK_AgregarAntecedente.Location = new System.Drawing.Point(490, 47);
            this.LNK_AgregarAntecedente.Name = "LNK_AgregarAntecedente";
            this.LNK_AgregarAntecedente.Size = new System.Drawing.Size(107, 13);
            this.LNK_AgregarAntecedente.TabIndex = 17;
            this.LNK_AgregarAntecedente.TabStop = true;
            this.LNK_AgregarAntecedente.Text = "Agregar antecedente";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(49, 99);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 18;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_Cedula.Location = new System.Drawing.Point(133, 96);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(146, 20);
            this.TXT_Cedula.TabIndex = 19;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(493, 85);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(106, 31);
            this.BTN_Buscar.TabIndex = 20;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // DGV_Antecedentes
            // 
            this.DGV_Antecedentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Antecedentes.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Antecedentes.Location = new System.Drawing.Point(52, 137);
            this.DGV_Antecedentes.Name = "DGV_Antecedentes";
            this.DGV_Antecedentes.Size = new System.Drawing.Size(545, 245);
            this.DGV_Antecedentes.TabIndex = 21;
            // 
            // ConsultarAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 394);
            this.Controls.Add(this.DGV_Antecedentes);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LNK_AgregarAntecedente);
            this.Controls.Add(this.LNK_Menu);
            this.Controls.Add(this.LBL_ConsultaAntecedentes);
            this.Name = "ConsultarAntecedentes";
            this.Text = "ConsultarAntecedentes";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Antecedentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ConsultaAntecedentes;
        private System.Windows.Forms.LinkLabel LNK_Menu;
        private System.Windows.Forms.LinkLabel LNK_AgregarAntecedente;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.DataGridView DGV_Antecedentes;
    }
}