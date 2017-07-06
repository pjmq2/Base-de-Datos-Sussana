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
            this.BTN_EliminarMaterial = new System.Windows.Forms.Button();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_EliminarMateriales = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTN_EliminarRequisito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_informacionDeLaTecnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.GB_EliminarMateriales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.gb_informacionDeLaTecnica.Location = new System.Drawing.Point(16, 38);
            this.gb_informacionDeLaTecnica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDeLaTecnica.Name = "gb_informacionDeLaTecnica";
            this.gb_informacionDeLaTecnica.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDeLaTecnica.Size = new System.Drawing.Size(400, 246);
            this.gb_informacionDeLaTecnica.TabIndex = 1;
            this.gb_informacionDeLaTecnica.TabStop = false;
            this.gb_informacionDeLaTecnica.Text = "Información de la técnica";
            // 
            // BTN_EliminarMaterial
            // 
            this.BTN_EliminarMaterial.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarMaterial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_EliminarMaterial.Location = new System.Drawing.Point(237, 210);
            this.BTN_EliminarMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_EliminarMaterial.Name = "BTN_EliminarMaterial";
            this.BTN_EliminarMaterial.Size = new System.Drawing.Size(129, 28);
            this.BTN_EliminarMaterial.TabIndex = 9;
            this.BTN_EliminarMaterial.Text = "Eliminar material";
            this.BTN_EliminarMaterial.UseVisualStyleBackColor = false;
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(125, 69);
            this.nud_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(241, 22);
            this.nud_precio.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(33, 210);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 101);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 101);
            this.textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(29, 105);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(86, 17);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(29, 71);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(52, 17);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // GB_EliminarMateriales
            // 
            this.GB_EliminarMateriales.Controls.Add(this.comboBox2);
            this.GB_EliminarMateriales.Controls.Add(this.BTN_EliminarRequisito);
            this.GB_EliminarMateriales.Location = new System.Drawing.Point(424, 38);
            this.GB_EliminarMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_EliminarMateriales.Name = "GB_EliminarMateriales";
            this.GB_EliminarMateriales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_EliminarMateriales.Size = new System.Drawing.Size(339, 117);
            this.GB_EliminarMateriales.TabIndex = 2;
            this.GB_EliminarMateriales.TabStop = false;
            this.GB_EliminarMateriales.Text = "Materiales requeridos";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 36);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(321, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // BTN_EliminarRequisito
            // 
            this.BTN_EliminarRequisito.BackColor = System.Drawing.Color.Red;
            this.BTN_EliminarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarRequisito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_EliminarRequisito.Location = new System.Drawing.Point(8, 69);
            this.BTN_EliminarRequisito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_EliminarRequisito.Name = "BTN_EliminarRequisito";
            this.BTN_EliminarRequisito.Size = new System.Drawing.Size(131, 28);
            this.BTN_EliminarRequisito.TabIndex = 3;
            this.BTN_EliminarRequisito.Text = "Eliminar requisito";
            this.BTN_EliminarRequisito.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(424, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(339, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir material requerido";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(8, 70);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(131, 28);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Añadir requisito";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.menuAvanzadoToolStripMenuItem,
            this.tecnicaToolStripMenuItem,
            this.antecedenteToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.ejercicioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // menuAvanzadoToolStripMenuItem
            // 
            this.menuAvanzadoToolStripMenuItem.Name = "menuAvanzadoToolStripMenuItem";
            this.menuAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.menuAvanzadoToolStripMenuItem.Text = "Menu Avanzado";
            this.menuAvanzadoToolStripMenuItem.Click += new System.EventHandler(this.menuAvanzadoToolStripMenuItem_Click);
            // 
            // tecnicaToolStripMenuItem
            // 
            this.tecnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTecnicaToolStripMenuItem,
            this.buscarTecnicaToolStripMenuItem});
            this.tecnicaToolStripMenuItem.Name = "tecnicaToolStripMenuItem";
            this.tecnicaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.tecnicaToolStripMenuItem.Text = "Tecnica";
            // 
            // antecedenteToolStripMenuItem
            // 
            this.antecedenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAntecedenteToolStripMenuItem,
            this.buscarAntecedenteToolStripMenuItem});
            this.antecedenteToolStripMenuItem.Name = "antecedenteToolStripMenuItem";
            this.antecedenteToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.antecedenteToolStripMenuItem.Text = "Antecedente";
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMaterialToolStripMenuItem,
            this.buscarMaterialToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // ejercicioToolStripMenuItem
            // 
            this.ejercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEjercicioToolStripMenuItem,
            this.buscarEjercicioToolStripMenuItem});
            this.ejercicioToolStripMenuItem.Name = "ejercicioToolStripMenuItem";
            this.ejercicioToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ejercicioToolStripMenuItem.Text = "Ejercicio";
            // 
            // crearTecnicaToolStripMenuItem
            // 
            this.crearTecnicaToolStripMenuItem.Name = "crearTecnicaToolStripMenuItem";
            this.crearTecnicaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.crearTecnicaToolStripMenuItem.Text = "Crear Tecnica";
            this.crearTecnicaToolStripMenuItem.Click += new System.EventHandler(this.crearTecnicaToolStripMenuItem_Click);
            // 
            // buscarTecnicaToolStripMenuItem
            // 
            this.buscarTecnicaToolStripMenuItem.Name = "buscarTecnicaToolStripMenuItem";
            this.buscarTecnicaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.buscarTecnicaToolStripMenuItem.Text = "Buscar Tecnica";
            this.buscarTecnicaToolStripMenuItem.Click += new System.EventHandler(this.buscarTecnicaToolStripMenuItem_Click);
            // 
            // crearAntecedenteToolStripMenuItem
            // 
            this.crearAntecedenteToolStripMenuItem.Name = "crearAntecedenteToolStripMenuItem";
            this.crearAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.crearAntecedenteToolStripMenuItem.Text = "Crear Antecedente";
            this.crearAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.crearAntecedenteToolStripMenuItem_Click);
            // 
            // buscarAntecedenteToolStripMenuItem
            // 
            this.buscarAntecedenteToolStripMenuItem.Name = "buscarAntecedenteToolStripMenuItem";
            this.buscarAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.buscarAntecedenteToolStripMenuItem.Text = "Buscar Antecedente";
            this.buscarAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.buscarAntecedenteToolStripMenuItem_Click);
            // 
            // crearMaterialToolStripMenuItem
            // 
            this.crearMaterialToolStripMenuItem.Name = "crearMaterialToolStripMenuItem";
            this.crearMaterialToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.crearMaterialToolStripMenuItem.Text = "Crear Material ";
            this.crearMaterialToolStripMenuItem.Click += new System.EventHandler(this.crearMaterialToolStripMenuItem_Click);
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar Material";
            this.buscarMaterialToolStripMenuItem.Click += new System.EventHandler(this.buscarMaterialToolStripMenuItem_Click);
            // 
            // crearEjercicioToolStripMenuItem
            // 
            this.crearEjercicioToolStripMenuItem.Name = "crearEjercicioToolStripMenuItem";
            this.crearEjercicioToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.crearEjercicioToolStripMenuItem.Text = "Crear Ejercicio";
            this.crearEjercicioToolStripMenuItem.Click += new System.EventHandler(this.crearEjercicioToolStripMenuItem_Click);
            // 
            // buscarEjercicioToolStripMenuItem
            // 
            this.buscarEjercicioToolStripMenuItem.Name = "buscarEjercicioToolStripMenuItem";
            this.buscarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.buscarEjercicioToolStripMenuItem.Text = "Buscar Ejercicio";
            this.buscarEjercicioToolStripMenuItem.Click += new System.EventHandler(this.buscarEjercicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // VerTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_EliminarMateriales);
            this.Controls.Add(this.gb_informacionDeLaTecnica);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerTecnica";
            this.Text = "Modificar técnica";
            this.gb_informacionDeLaTecnica.ResumeLayout(false);
            this.gb_informacionDeLaTecnica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.GB_EliminarMateriales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAvanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAntecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAntecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}