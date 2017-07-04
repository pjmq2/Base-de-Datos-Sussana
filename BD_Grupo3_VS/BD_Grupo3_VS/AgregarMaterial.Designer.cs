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
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
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
            this.gb_informacionDelMaterial.Controls.Add(this.nud_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.btn_guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.txt_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(51, 31);
            this.gb_informacionDelMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(400, 246);
            this.gb_informacionDelMaterial.TabIndex = 0;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del material";
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(161, 114);
            this.nud_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_guardar.Location = new System.Drawing.Point(233, 176);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(57, 117);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(52, 17);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(57, 64);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(161, 60);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // AgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarMaterial";
            this.Text = "Agregar material";
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
        private System.Windows.Forms.TextBox txt_nombre;
    }
}