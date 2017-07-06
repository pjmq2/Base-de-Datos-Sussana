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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_informacionDelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_informacionDelMaterial
            // 
            this.gb_informacionDelMaterial.Controls.Add(this.nud_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.btn_guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_precio);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.txt_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(56, 37);
            this.gb_informacionDelMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(400, 246);
            this.gb_informacionDelMaterial.TabIndex = 1;
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
            this.nud_precio.Location = new System.Drawing.Point(101, 114);
            this.nud_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_precio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(276, 22);
            this.nud_precio.TabIndex = 6;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(277, 182);
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
            this.lbl_precio.Location = new System.Drawing.Point(17, 117);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(52, 17);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 70);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(101, 66);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(275, 22);
            this.txt_nombre.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(652, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // menuAvanzadoToolStripMenuItem
            // 
            this.menuAvanzadoToolStripMenuItem.Name = "menuAvanzadoToolStripMenuItem";
            this.menuAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.menuAvanzadoToolStripMenuItem.Text = "Menu Avanzado";
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
            // crearTecnicaToolStripMenuItem
            // 
            this.crearTecnicaToolStripMenuItem.Name = "crearTecnicaToolStripMenuItem";
            this.crearTecnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.crearTecnicaToolStripMenuItem.Text = "Crear Tecnica";
            // 
            // buscarTecnicaToolStripMenuItem
            // 
            this.buscarTecnicaToolStripMenuItem.Name = "buscarTecnicaToolStripMenuItem";
            this.buscarTecnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.buscarTecnicaToolStripMenuItem.Text = "Buscar Tecnica";
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
            // crearAntecedenteToolStripMenuItem
            // 
            this.crearAntecedenteToolStripMenuItem.Name = "crearAntecedenteToolStripMenuItem";
            this.crearAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.crearAntecedenteToolStripMenuItem.Text = "Crear Antecedente";
            // 
            // buscarAntecedenteToolStripMenuItem
            // 
            this.buscarAntecedenteToolStripMenuItem.Name = "buscarAntecedenteToolStripMenuItem";
            this.buscarAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.buscarAntecedenteToolStripMenuItem.Text = "Buscar Antecedente";
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
            // crearMaterialToolStripMenuItem
            // 
            this.crearMaterialToolStripMenuItem.Name = "crearMaterialToolStripMenuItem";
            this.crearMaterialToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.crearMaterialToolStripMenuItem.Text = "Crear Material ";
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar Material";
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
            // crearEjercicioToolStripMenuItem
            // 
            this.crearEjercicioToolStripMenuItem.Name = "crearEjercicioToolStripMenuItem";
            this.crearEjercicioToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.crearEjercicioToolStripMenuItem.Text = "Crear Ejercicio";
            // 
            // buscarEjercicioToolStripMenuItem
            // 
            this.buscarEjercicioToolStripMenuItem.Name = "buscarEjercicioToolStripMenuItem";
            this.buscarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.buscarEjercicioToolStripMenuItem.Text = "Buscar Ejercicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 321);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarMaterial";
            this.Text = "Agregar material";
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
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