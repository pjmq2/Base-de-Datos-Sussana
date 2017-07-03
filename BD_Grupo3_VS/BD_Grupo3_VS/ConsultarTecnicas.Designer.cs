namespace BD_Grupo3_VS
{
    partial class ConsultarTecnicas
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
            this.lbl_consultaDeTecnicas = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
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
            this.lnk_agregarTecnica.TabIndex = 16;
            this.lnk_agregarTecnica.TabStop = true;
            this.lnk_agregarTecnica.Text = "Agregar técnica";
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
            // lbl_consultaDeTecnicas
            // 
            this.lbl_consultaDeTecnicas.AutoSize = true;
            this.lbl_consultaDeTecnicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_consultaDeTecnicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultaDeTecnicas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_consultaDeTecnicas.Location = new System.Drawing.Point(12, 13);
            this.lbl_consultaDeTecnicas.Name = "lbl_consultaDeTecnicas";
            this.lbl_consultaDeTecnicas.Size = new System.Drawing.Size(267, 31);
            this.lbl_consultaDeTecnicas.TabIndex = 14;
            this.lbl_consultaDeTecnicas.Text = "Consulta de técnicas";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(597, 57);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
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
            // dgv_tecnicas
            // 
            this.dgv_tecnicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tecnicas.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_tecnicas.Location = new System.Drawing.Point(12, 86);
            this.dgv_tecnicas.Name = "dgv_tecnicas";
            this.dgv_tecnicas.Size = new System.Drawing.Size(660, 364);
            this.dgv_tecnicas.TabIndex = 9;
            // 
            // ConsultarTecnicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lnk_agregarTecnica);
            this.Controls.Add(this.lnk_menuPrincipal);
            this.Controls.Add(this.lbl_consultaDeTecnicas);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_tecnicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarTecnicas";
            this.Text = "Técnicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tecnicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_agregarTecnica;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.Label lbl_consultaDeTecnicas;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_tecnicas;
    }
}