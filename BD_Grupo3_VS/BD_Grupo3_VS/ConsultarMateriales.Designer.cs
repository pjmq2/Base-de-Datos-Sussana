namespace BD_Grupo3_VS
{
    partial class ConsultarMateriales
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
            this.dgv_materiales = new System.Windows.Forms.DataGridView();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_consultaDeMateriales = new System.Windows.Forms.Label();
            this.lnk_menuPrincipal = new System.Windows.Forms.LinkLabel();
            this.lnk_agregarMaterial = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_materiales
            // 
            this.dgv_materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiales.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_materiales.Location = new System.Drawing.Point(12, 85);
            this.dgv_materiales.Name = "dgv_materiales";
            this.dgv_materiales.Size = new System.Drawing.Size(660, 364);
            this.dgv_materiales.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 61);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(65, 58);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(321, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(597, 56);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // lbl_consultaDeMateriales
            // 
            this.lbl_consultaDeMateriales.AutoSize = true;
            this.lbl_consultaDeMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_consultaDeMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultaDeMateriales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_consultaDeMateriales.Location = new System.Drawing.Point(12, 12);
            this.lbl_consultaDeMateriales.Name = "lbl_consultaDeMateriales";
            this.lbl_consultaDeMateriales.Size = new System.Drawing.Size(291, 31);
            this.lbl_consultaDeMateriales.TabIndex = 6;
            this.lbl_consultaDeMateriales.Text = "Consulta de materiales";
            // 
            // lnk_menuPrincipal
            // 
            this.lnk_menuPrincipal.AutoSize = true;
            this.lnk_menuPrincipal.Location = new System.Drawing.Point(553, 9);
            this.lnk_menuPrincipal.Name = "lnk_menuPrincipal";
            this.lnk_menuPrincipal.Size = new System.Drawing.Size(119, 13);
            this.lnk_menuPrincipal.TabIndex = 7;
            this.lnk_menuPrincipal.TabStop = true;
            this.lnk_menuPrincipal.Text = "Volver al menú principal";
            // 
            // lnk_agregarMaterial
            // 
            this.lnk_agregarMaterial.AutoSize = true;
            this.lnk_agregarMaterial.Location = new System.Drawing.Point(589, 30);
            this.lnk_agregarMaterial.Name = "lnk_agregarMaterial";
            this.lnk_agregarMaterial.Size = new System.Drawing.Size(83, 13);
            this.lnk_agregarMaterial.TabIndex = 8;
            this.lnk_agregarMaterial.TabStop = true;
            this.lnk_agregarMaterial.Text = "Agregar material";
            // 
            // ConsultarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lnk_agregarMaterial);
            this.Controls.Add(this.lnk_menuPrincipal);
            this.Controls.Add(this.lbl_consultaDeMateriales);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_materiales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarMateriales";
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_materiales;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_consultaDeMateriales;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.LinkLabel lnk_agregarMaterial;
    }
}