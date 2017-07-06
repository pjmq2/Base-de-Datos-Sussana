namespace BD_Grupo3_VS
{
    partial class BuscarMateriales
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
            this.DGV_Materiales = new System.Windows.Forms.DataGridView();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Filtro = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LBL_ConsultaDeMateriales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Materiales)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Materiales
            // 
            this.DGV_Materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Materiales.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Materiales.Location = new System.Drawing.Point(12, 85);
            this.DGV_Materiales.Name = "DGV_Materiales";
            this.DGV_Materiales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_Materiales.Size = new System.Drawing.Size(660, 364);
            this.DGV_Materiales.TabIndex = 0;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(12, 61);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 1;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Filtro
            // 
            this.TXT_Filtro.Location = new System.Drawing.Point(65, 58);
            this.TXT_Filtro.Name = "TXT_Filtro";
            this.TXT_Filtro.Size = new System.Drawing.Size(250, 20);
            this.TXT_Filtro.TabIndex = 2;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(321, 56);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Buscar.TabIndex = 3;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // LBL_ConsultaDeMateriales
            // 
            this.LBL_ConsultaDeMateriales.AutoSize = true;
            this.LBL_ConsultaDeMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ConsultaDeMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDeMateriales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_ConsultaDeMateriales.Location = new System.Drawing.Point(12, 12);
            this.LBL_ConsultaDeMateriales.Name = "LBL_ConsultaDeMateriales";
            this.LBL_ConsultaDeMateriales.Size = new System.Drawing.Size(231, 31);
            this.LBL_ConsultaDeMateriales.TabIndex = 6;
            this.LBL_ConsultaDeMateriales.Text = "Buscar materiales";
            // 
            // BuscarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.LBL_ConsultaDeMateriales);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_Filtro);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.DGV_Materiales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarMateriales";
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.ConsultarMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Materiales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Materiales;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Filtro;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label LBL_ConsultaDeMateriales;
    }
}