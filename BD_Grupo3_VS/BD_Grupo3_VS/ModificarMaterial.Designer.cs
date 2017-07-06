namespace BD_Grupo3_VS
{
    partial class ModificarMaterial
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
            this.btn_guardar = new System.Windows.Forms.Button();
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
            this.gb_informacionDelMaterial.Controls.Add(this.btn_guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(51, 31);
            this.gb_informacionDelMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(400, 183);
            this.gb_informacionDelMaterial.TabIndex = 1;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del material";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(161, 43);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(172, 22);
            this.TXT_Nombre.TabIndex = 9;
            this.TXT_Nombre.TextChanged += new System.EventHandler(this.TXT_Nombre_TextChanged);
            // 
            // BTN_EliminarMaterial
            // 
            this.BTN_EliminarMaterial.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_EliminarMaterial.Location = new System.Drawing.Point(220, 128);
            this.BTN_EliminarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EliminarMaterial.Name = "BTN_EliminarMaterial";
            this.BTN_EliminarMaterial.Size = new System.Drawing.Size(129, 28);
            this.BTN_EliminarMaterial.TabIndex = 8;
            this.BTN_EliminarMaterial.Text = "Eliminar Material";
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
            this.nud_precio.Location = new System.Drawing.Point(161, 76);
            this.nud_precio.Margin = new System.Windows.Forms.Padding(4);
            this.nud_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(172, 22);
            this.nud_precio.TabIndex = 6;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(60, 128);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(57, 79);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(52, 17);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(57, 43);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // ModificarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 235);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarMaterial";
            this.Text = "Modificar material";
            this.Load += new System.EventHandler(this.ModificarMaterial_Load);
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button BTN_EliminarMaterial;
        private System.Windows.Forms.TextBox TXT_Nombre;
    }
}