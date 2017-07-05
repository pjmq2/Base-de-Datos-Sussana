namespace BD_Grupo3_VS
{
    partial class EliminarTecnicas
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
            this.lnk_agregarTecnica = new System.Windows.Forms.LinkLabel();
            this.lnk_menuPrincipal = new System.Windows.Forms.LinkLabel();
            this.lbl_borradoDeTecnicas = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgv_tecnicas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tecnicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_agregarTecnica
            // 
            this.lnk_agregarTecnica.AutoSize = true;
            this.lnk_agregarTecnica.Location = new System.Drawing.Point(590, 31);
            this.lnk_agregarTecnica.Name = "lnk_agregarTecnica";
            this.lnk_agregarTecnica.Size = new System.Drawing.Size(82, 13);
            this.lnk_agregarTecnica.TabIndex = 24;
            this.lnk_agregarTecnica.TabStop = true;
            this.lnk_agregarTecnica.Text = "Agregar técnica";
            // 
            // lnk_menuPrincipal
            // 
            this.lnk_menuPrincipal.AutoSize = true;
            this.lnk_menuPrincipal.Location = new System.Drawing.Point(553, 10);
            this.lnk_menuPrincipal.Name = "lnk_menuPrincipal";
            this.lnk_menuPrincipal.Size = new System.Drawing.Size(119, 13);
            this.lnk_menuPrincipal.TabIndex = 23;
            this.lnk_menuPrincipal.TabStop = true;
            this.lnk_menuPrincipal.Text = "Volver al menú principal";
            this.lnk_menuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_menuPrincipal_LinkClicked);
            // 
            // lbl_borradoDeTecnicas
            // 
            this.lbl_borradoDeTecnicas.AutoSize = true;
            this.lbl_borradoDeTecnicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_borradoDeTecnicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borradoDeTecnicas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_borradoDeTecnicas.Location = new System.Drawing.Point(12, 13);
            this.lbl_borradoDeTecnicas.Name = "lbl_borradoDeTecnicas";
            this.lbl_borradoDeTecnicas.Size = new System.Drawing.Size(255, 31);
            this.lbl_borradoDeTecnicas.TabIndex = 22;
            this.lbl_borradoDeTecnicas.Text = "Borrado de técnicas";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(597, 57);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 21;
            this.btn_borrar.Text = "Eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(321, 57);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(65, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 20);
            this.txt_nombre.TabIndex = 19;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 62);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 18;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // dgv_tecnicas
            // 
            this.dgv_tecnicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tecnicas.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_tecnicas.Location = new System.Drawing.Point(12, 86);
            this.dgv_tecnicas.Name = "dgv_tecnicas";
            this.dgv_tecnicas.Size = new System.Drawing.Size(660, 364);
            this.dgv_tecnicas.TabIndex = 17;
            // 
            // EliminarTecnicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lnk_agregarTecnica);
            this.Controls.Add(this.lnk_menuPrincipal);
            this.Controls.Add(this.lbl_borradoDeTecnicas);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_tecnicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EliminarTecnicas";
            this.Text = "Eliminar técnicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tecnicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_agregarTecnica;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.Label lbl_borradoDeTecnicas;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_tecnicas;
    }
}