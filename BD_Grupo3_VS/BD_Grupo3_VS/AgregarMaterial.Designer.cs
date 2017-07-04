namespace BD_Grupo3_VS
{
    partial class AgregarMaterial
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
            this.gb_informacionDelMaterial = new System.Windows.Forms.GroupBox();
            this.lnk_ConsultarMateriales = new System.Windows.Forms.LinkLabel();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.lnk_menuPrincipal = new System.Windows.Forms.LinkLabel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gb_informacionDelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_informacionDelMaterial
            // 
            this.gb_informacionDelMaterial.Controls.Add(this.lnk_ConsultarMateriales);
            this.gb_informacionDelMaterial.Controls.Add(this.nud_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lnk_menuPrincipal);
            this.gb_informacionDelMaterial.Controls.Add(this.btn_guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.txt_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(42, 30);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(300, 200);
            this.gb_informacionDelMaterial.TabIndex = 1;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del material";
            // 
            // lnk_ConsultarMateriales
            // 
            this.lnk_ConsultarMateriales.AutoSize = true;
            this.lnk_ConsultarMateriales.Location = new System.Drawing.Point(190, 39);
            this.lnk_ConsultarMateriales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnk_ConsultarMateriales.Name = "lnk_ConsultarMateriales";
            this.lnk_ConsultarMateriales.Size = new System.Drawing.Size(101, 13);
            this.lnk_ConsultarMateriales.TabIndex = 18;
            this.lnk_ConsultarMateriales.TabStop = true;
            this.lnk_ConsultarMateriales.Text = "Consultar materiales";
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(84, 112);
            this.nud_precio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(207, 20);
            this.nud_precio.TabIndex = 6;
            // 
            // lnk_menuPrincipal
            // 
            this.lnk_menuPrincipal.AutoSize = true;
            this.lnk_menuPrincipal.Location = new System.Drawing.Point(176, 16);
            this.lnk_menuPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnk_menuPrincipal.Name = "lnk_menuPrincipal";
            this.lnk_menuPrincipal.Size = new System.Drawing.Size(119, 13);
            this.lnk_menuPrincipal.TabIndex = 17;
            this.lnk_menuPrincipal.TabStop = true;
            this.lnk_menuPrincipal.Text = "Volver al menú principal";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(216, 154);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(21, 114);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 76);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(84, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // AgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarMaterial";
            this.Text = "Agregar material";
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.LinkLabel lnk_ConsultarMateriales;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.LinkLabel lnk_menuPrincipal;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}