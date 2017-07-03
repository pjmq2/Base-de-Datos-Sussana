namespace BD_Grupo3_VS
{
    partial class EliminarMateriales
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
            this.lnk_agregarMaterial = new System.Windows.Forms.LinkLabel();
            this.lnk_menuPrincipal = new System.Windows.Forms.LinkLabel();
            this.lbl_borradoDeMateriales = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgv_materiales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_agregarMaterial
            // 
            this.lnk_agregarMaterial.AutoSize = true;
            this.lnk_agregarMaterial.Location = new System.Drawing.Point(589, 31);
            this.lnk_agregarMaterial.Name = "lnk_agregarMaterial";
            this.lnk_agregarMaterial.Size = new System.Drawing.Size(83, 13);
            this.lnk_agregarMaterial.TabIndex = 16;
            this.lnk_agregarMaterial.TabStop = true;
            this.lnk_agregarMaterial.Text = "Agregar material";
            // 
            // lnk_menuPrincipal
            // 
            this.lnk_menuPrincipal.AutoSize = true;
            this.lnk_menuPrincipal.Location = new System.Drawing.Point(553, 10);
            this.lnk_menuPrincipal.Name = "lnk_menuPrincipal";
            this.lnk_menuPrincipal.Size = new System.Drawing.Size(119, 13);
            this.lnk_menuPrincipal.TabIndex = 15;
            this.lnk_menuPrincipal.TabStop = true;
            this.lnk_menuPrincipal.Text = "Volver al menú principal";
            // 
            // lbl_borradoDeMateriales
            // 
            this.lbl_borradoDeMateriales.AutoSize = true;
            this.lbl_borradoDeMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_borradoDeMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borradoDeMateriales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_borradoDeMateriales.Location = new System.Drawing.Point(12, 13);
            this.lbl_borradoDeMateriales.Name = "lbl_borradoDeMateriales";
            this.lbl_borradoDeMateriales.Size = new System.Drawing.Size(279, 31);
            this.lbl_borradoDeMateriales.TabIndex = 14;
            this.lbl_borradoDeMateriales.Text = "Borrado de materiales";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(597, 57);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
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
            // dgv_materiales
            // 
            this.dgv_materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiales.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_materiales.Location = new System.Drawing.Point(12, 86);
            this.dgv_materiales.Name = "dgv_materiales";
            this.dgv_materiales.Size = new System.Drawing.Size(660, 364);
            this.dgv_materiales.TabIndex = 9;
            // 
            // EliminarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lnk_agregarMaterial);
            this.Controls.Add(this.lnk_menuPrincipal);
            this.Controls.Add(this.lbl_borradoDeMateriales);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_materiales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EliminarMateriales";
            this.Text = "Eliminar materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_agregarMaterial;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.Label lbl_borradoDeMateriales;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_materiales;
    }
}