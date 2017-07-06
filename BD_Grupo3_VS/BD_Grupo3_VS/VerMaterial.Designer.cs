namespace BD_Grupo3_VS
{
    partial class VerMaterial
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
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.BTN_EliminarMaterial = new System.Windows.Forms.Button();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_informacionDelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_informacionDelMaterial
            // 
            this.gb_informacionDelMaterial.Controls.Add(this.TXT_Nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.BTN_EliminarMaterial);
            this.gb_informacionDelMaterial.Controls.Add(this.nud_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.BTN_Guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(38, 25);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(300, 149);
            this.gb_informacionDelMaterial.TabIndex = 1;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del material";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(121, 35);
            this.TXT_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(141, 20);
            this.TXT_Nombre.TabIndex = 9;
            this.TXT_Nombre.TextChanged += new System.EventHandler(this.TXT_Nombre_TextChanged);
            // 
            // BTN_EliminarMaterial
            // 
            this.BTN_EliminarMaterial.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarMaterial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_EliminarMaterial.Location = new System.Drawing.Point(165, 104);
            this.BTN_EliminarMaterial.Name = "BTN_EliminarMaterial";
            this.BTN_EliminarMaterial.Size = new System.Drawing.Size(97, 23);
            this.BTN_EliminarMaterial.TabIndex = 8;
            this.BTN_EliminarMaterial.Text = "Eliminar material";
            this.BTN_EliminarMaterial.UseVisualStyleBackColor = false;
            this.BTN_EliminarMaterial.Click += new System.EventHandler(this.BTN_EliminarMaterial_Click);
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(121, 62);
            this.nud_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(141, 20);
            this.nud_precio.TabIndex = 6;
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(46, 104);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(78, 23);
            this.BTN_Guardar.TabIndex = 5;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(43, 64);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(43, 35);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // VerMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerMaterial";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.ModificarMaterial_Load);
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button BTN_EliminarMaterial;
        private System.Windows.Forms.TextBox TXT_Nombre;
    }
}