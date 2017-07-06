namespace BD_Grupo3_VS
{
    partial class BuscarTecnicas
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
            this.LBL_ConsultaDeTecnicas = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.DGV_Tecnicas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tecnicas)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDeTecnicas
            // 
            this.LBL_ConsultaDeTecnicas.AutoSize = true;
            this.LBL_ConsultaDeTecnicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ConsultaDeTecnicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDeTecnicas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_ConsultaDeTecnicas.Location = new System.Drawing.Point(12, 13);
            this.LBL_ConsultaDeTecnicas.Name = "LBL_ConsultaDeTecnicas";
            this.LBL_ConsultaDeTecnicas.Size = new System.Drawing.Size(207, 31);
            this.LBL_ConsultaDeTecnicas.TabIndex = 14;
            this.LBL_ConsultaDeTecnicas.Text = "Buscar técnicas";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(321, 57);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(65, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 20);
            this.txt_nombre.TabIndex = 11;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 62);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // DGV_Tecnicas
            // 
            this.DGV_Tecnicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tecnicas.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Tecnicas.Location = new System.Drawing.Point(12, 86);
            this.DGV_Tecnicas.Name = "DGV_Tecnicas";
            this.DGV_Tecnicas.Size = new System.Drawing.Size(660, 364);
            this.DGV_Tecnicas.TabIndex = 9;
            // 
            // BuscarTecnicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.LBL_ConsultaDeTecnicas);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.DGV_Tecnicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarTecnicas";
            this.Text = "Técnicas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tecnicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_ConsultaDeTecnicas;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView DGV_Tecnicas;
    }
}