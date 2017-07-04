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
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_consultaDeMateriales = new System.Windows.Forms.Label();
            this.lnk_menuPrincipal = new System.Windows.Forms.LinkLabel();
            this.lnk_eliminarMaterial = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_materiales
            // 
            this.dgv_materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiales.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_materiales.Location = new System.Drawing.Point(12, 85);
            this.dgv_materiales.Name = "dgv_materiales";
            this.dgv_materiales.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(65, 58);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(250, 20);
            this.txt_filtro.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(321, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.lnk_menuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_menuPrincipal_LinkClicked);
            // 
            // lnk_eliminarMaterial
            // 
            this.lnk_eliminarMaterial.AutoSize = true;
            this.lnk_eliminarMaterial.Location = new System.Drawing.Point(589, 30);
            this.lnk_eliminarMaterial.Name = "lnk_eliminarMaterial";
            this.lnk_eliminarMaterial.Size = new System.Drawing.Size(82, 13);
            this.lnk_eliminarMaterial.TabIndex = 8;
            this.lnk_eliminarMaterial.TabStop = true;
            this.lnk_eliminarMaterial.Text = "Eliminar material";
            this.lnk_eliminarMaterial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_eliminarMaterial_LinkClicked);
            // 
            // ConsultarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lnk_eliminarMaterial);
            this.Controls.Add(this.lnk_menuPrincipal);
            this.Controls.Add(this.lbl_consultaDeMateriales);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_materiales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarMateriales";
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.ConsultarMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_materiales;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_consultaDeMateriales;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.LinkLabel lnk_eliminarMaterial;
    }
}