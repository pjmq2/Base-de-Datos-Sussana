namespace BD_Grupo3_VS
{
    partial class VerTecnica
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
            this.BTN_EliminarMaterial = new System.Windows.Forms.Button();
            this.GB_EliminarMateriales = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTN_EliminarRequisito = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gb_informacionDeLaTecnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.GB_EliminarMateriales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_informacionDeLaTecnica
            // 
            this.gb_informacionDeLaTecnica.Controls.Add(this.BTN_EliminarMaterial);
            this.gb_informacionDeLaTecnica.Controls.Add(this.nud_precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.btn_guardar);
            this.gb_informacionDeLaTecnica.Controls.Add(this.textBox3);
            this.gb_informacionDeLaTecnica.Controls.Add(this.textBox1);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_descripcion);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.label1);
            this.gb_informacionDeLaTecnica.Location = new System.Drawing.Point(12, 31);
            this.gb_informacionDeLaTecnica.Name = "gb_informacionDeLaTecnica";
            this.gb_informacionDeLaTecnica.Size = new System.Drawing.Size(300, 200);
            this.gb_informacionDeLaTecnica.TabIndex = 1;
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
            this.nud_precio.Location = new System.Drawing.Point(94, 56);
            this.nud_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(181, 20);
            this.nud_precio.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(25, 171);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 82);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 83);
            this.textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
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
            // BTN_EliminarMaterial
            // 
            this.BTN_EliminarMaterial.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarMaterial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_EliminarMaterial.Location = new System.Drawing.Point(178, 171);
            this.BTN_EliminarMaterial.Name = "BTN_EliminarMaterial";
            this.BTN_EliminarMaterial.Size = new System.Drawing.Size(97, 23);
            this.BTN_EliminarMaterial.TabIndex = 9;
            this.BTN_EliminarMaterial.Text = "Eliminar material";
            this.BTN_EliminarMaterial.UseVisualStyleBackColor = false;
            // 
            // GB_EliminarMateriales
            // 
            this.GB_EliminarMateriales.Controls.Add(this.comboBox2);
            this.GB_EliminarMateriales.Controls.Add(this.BTN_EliminarRequisito);
            this.GB_EliminarMateriales.Location = new System.Drawing.Point(318, 31);
            this.GB_EliminarMateriales.Name = "GB_EliminarMateriales";
            this.GB_EliminarMateriales.Size = new System.Drawing.Size(254, 95);
            this.GB_EliminarMateriales.TabIndex = 2;
            this.GB_EliminarMateriales.TabStop = false;
            this.GB_EliminarMateriales.Text = "Materiales requeridos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(318, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir material requerido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // BTN_EliminarRequisito
            // 
            this.BTN_EliminarRequisito.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarRequisito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_EliminarRequisito.Location = new System.Drawing.Point(6, 56);
            this.BTN_EliminarRequisito.Name = "BTN_EliminarRequisito";
            this.BTN_EliminarRequisito.Size = new System.Drawing.Size(98, 23);
            this.BTN_EliminarRequisito.TabIndex = 3;
            this.BTN_EliminarRequisito.Text = "Eliminar requisito";
            this.BTN_EliminarRequisito.UseVisualStyleBackColor = false;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(6, 57);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(98, 23);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Añadir requisito";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // VerTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_EliminarMateriales);
            this.Controls.Add(this.gb_informacionDeLaTecnica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerTecnica";
            this.Text = "Modificar técnica";
            this.gb_informacionDeLaTecnica.ResumeLayout(false);
            this.gb_informacionDeLaTecnica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.GB_EliminarMateriales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDeLaTecnica;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_EliminarMaterial;
        private System.Windows.Forms.GroupBox GB_EliminarMateriales;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTN_EliminarRequisito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}