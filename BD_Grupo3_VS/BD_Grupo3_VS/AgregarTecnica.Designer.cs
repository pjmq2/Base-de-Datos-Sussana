namespace BD_Grupo3_VS
{
    partial class AgregarTecnica
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
            this.gb_informacionDeLaTecnica = new System.Windows.Forms.GroupBox();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_informacionDeLaTecnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_informacionDeLaTecnica
            // 
            this.gb_informacionDeLaTecnica.Controls.Add(this.nud_precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.btn_guardar);
            this.gb_informacionDeLaTecnica.Controls.Add(this.textBox3);
            this.gb_informacionDeLaTecnica.Controls.Add(this.textBox1);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_descripcion);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.label1);
            this.gb_informacionDeLaTecnica.Location = new System.Drawing.Point(38, 25);
            this.gb_informacionDeLaTecnica.Name = "gb_informacionDeLaTecnica";
            this.gb_informacionDeLaTecnica.Size = new System.Drawing.Size(300, 200);
            this.gb_informacionDeLaTecnica.TabIndex = 0;
            this.gb_informacionDeLaTecnica.TabStop = false;
            this.gb_informacionDeLaTecnica.Text = "Información de la técnica";
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(114, 56);
            this.nud_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(161, 20);
            this.nud_precio.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(200, 171);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 82);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 83);
            this.textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(22, 85);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(22, 58);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // AgregarTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.gb_informacionDeLaTecnica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarTecnica";
            this.Text = "Agregar técnica";
            this.gb_informacionDeLaTecnica.ResumeLayout(false);
            this.gb_informacionDeLaTecnica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDeLaTecnica;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_precio;
    }
}