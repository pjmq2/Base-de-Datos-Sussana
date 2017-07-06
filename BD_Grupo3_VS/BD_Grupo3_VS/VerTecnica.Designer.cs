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
            this.NUD_Precio = new System.Windows.Forms.NumericUpDown();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_EliminarMateriales = new System.Windows.Forms.GroupBox();
            this.CB_MaterialesRequeridos = new System.Windows.Forms.ComboBox();
            this.BTN_EliminarRequisito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_AñadirRequisito = new System.Windows.Forms.Button();
            this.CB_NuevoMaterialRequerido = new System.Windows.Forms.ComboBox();
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
            this.gb_informacionDeLaTecnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).BeginInit();
            this.GB_EliminarMateriales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_informacionDeLaTecnica
            // 
            this.gb_informacionDeLaTecnica.Controls.Add(this.BTN_EliminarMaterial);
            this.gb_informacionDeLaTecnica.Controls.Add(this.NUD_Precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.BTN_Guardar);
            this.gb_informacionDeLaTecnica.Controls.Add(this.TXT_Descripcion);
            this.gb_informacionDeLaTecnica.Controls.Add(this.TXT_Nombre);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_descripcion);
            this.gb_informacionDeLaTecnica.Controls.Add(this.lbl_precio);
            this.gb_informacionDeLaTecnica.Controls.Add(this.label1);
            this.gb_informacionDeLaTecnica.Location = new System.Drawing.Point(12, 27);
            this.gb_informacionDeLaTecnica.Name = "gb_informacionDeLaTecnica";
            this.gb_informacionDeLaTecnica.Size = new System.Drawing.Size(300, 200);
            this.gb_informacionDeLaTecnica.TabIndex = 1;
            this.gb_informacionDeLaTecnica.TabStop = false;
            this.gb_informacionDeLaTecnica.Text = "Información de la técnica";
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
            // NUD_Precio
            // 
            this.NUD_Precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_Precio.Location = new System.Drawing.Point(94, 56);
            this.NUD_Precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD_Precio.Name = "NUD_Precio";
            this.NUD_Precio.Size = new System.Drawing.Size(181, 20);
            this.NUD_Precio.TabIndex = 7;
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(25, 171);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 6;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(94, 82);
            this.TXT_Descripcion.Multiline = true;
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(181, 83);
            this.TXT_Descripcion.TabIndex = 5;
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(94, 29);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(181, 20);
            this.TXT_Nombre.TabIndex = 3;
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
            // GB_EliminarMateriales
            // 
            this.GB_EliminarMateriales.Controls.Add(this.CB_MaterialesRequeridos);
            this.GB_EliminarMateriales.Controls.Add(this.BTN_EliminarRequisito);
            this.GB_EliminarMateriales.Location = new System.Drawing.Point(318, 27);
            this.GB_EliminarMateriales.Name = "GB_EliminarMateriales";
            this.GB_EliminarMateriales.Size = new System.Drawing.Size(254, 95);
            this.GB_EliminarMateriales.TabIndex = 2;
            this.GB_EliminarMateriales.TabStop = false;
            this.GB_EliminarMateriales.Text = "Materiales requeridos";
            // 
            // CB_MaterialesRequeridos
            // 
            this.CB_MaterialesRequeridos.FormattingEnabled = true;
            this.CB_MaterialesRequeridos.Location = new System.Drawing.Point(6, 29);
            this.CB_MaterialesRequeridos.Name = "CB_MaterialesRequeridos";
            this.CB_MaterialesRequeridos.Size = new System.Drawing.Size(242, 21);
            this.CB_MaterialesRequeridos.TabIndex = 4;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_AñadirRequisito);
            this.groupBox2.Controls.Add(this.CB_NuevoMaterialRequerido);
            this.groupBox2.Location = new System.Drawing.Point(318, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir material requerido";
            // 
            // BTN_AñadirRequisito
            // 
            this.BTN_AñadirRequisito.Location = new System.Drawing.Point(6, 57);
            this.BTN_AñadirRequisito.Name = "BTN_AñadirRequisito";
            this.BTN_AñadirRequisito.Size = new System.Drawing.Size(98, 23);
            this.BTN_AñadirRequisito.TabIndex = 4;
            this.BTN_AñadirRequisito.Text = "Añadir requisito";
            this.BTN_AñadirRequisito.UseVisualStyleBackColor = true;
            // 
            // CB_NuevoMaterialRequerido
            // 
            this.CB_NuevoMaterialRequerido.FormattingEnabled = true;
            this.CB_NuevoMaterialRequerido.Location = new System.Drawing.Point(6, 30);
            this.CB_NuevoMaterialRequerido.Name = "CB_NuevoMaterialRequerido";
            this.CB_NuevoMaterialRequerido.Size = new System.Drawing.Size(242, 21);
            this.CB_NuevoMaterialRequerido.TabIndex = 0;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menú principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // menuAvanzadoToolStripMenuItem
            // 
            this.menuAvanzadoToolStripMenuItem.Name = "menuAvanzadoToolStripMenuItem";
            this.menuAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.menuAvanzadoToolStripMenuItem.Text = "Menú avanzado";
            this.menuAvanzadoToolStripMenuItem.Click += new System.EventHandler(this.menuAvanzadoToolStripMenuItem_Click);
            // 
            // tecnicaToolStripMenuItem
            // 
            this.tecnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTecnicaToolStripMenuItem,
            this.buscarTecnicaToolStripMenuItem});
            this.tecnicaToolStripMenuItem.Name = "tecnicaToolStripMenuItem";
            this.tecnicaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tecnicaToolStripMenuItem.Text = "Técnica";
            // 
            // crearTecnicaToolStripMenuItem
            // 
            this.crearTecnicaToolStripMenuItem.Name = "crearTecnicaToolStripMenuItem";
            this.crearTecnicaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearTecnicaToolStripMenuItem.Text = "Crear Tecnica";
            this.crearTecnicaToolStripMenuItem.Click += new System.EventHandler(this.crearTecnicaToolStripMenuItem_Click);
            // 
            // buscarTecnicaToolStripMenuItem
            // 
            this.buscarTecnicaToolStripMenuItem.Name = "buscarTecnicaToolStripMenuItem";
            this.buscarTecnicaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarTecnicaToolStripMenuItem.Text = "Buscar Tecnica";
            this.buscarTecnicaToolStripMenuItem.Click += new System.EventHandler(this.buscarTecnicaToolStripMenuItem_Click);
            // 
            // antecedenteToolStripMenuItem
            // 
            this.antecedenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAntecedenteToolStripMenuItem,
            this.buscarAntecedenteToolStripMenuItem});
            this.antecedenteToolStripMenuItem.Name = "antecedenteToolStripMenuItem";
            this.antecedenteToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.antecedenteToolStripMenuItem.Text = "Antecedente";
            // 
            // crearAntecedenteToolStripMenuItem
            // 
            this.crearAntecedenteToolStripMenuItem.Name = "crearAntecedenteToolStripMenuItem";
            this.crearAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.crearAntecedenteToolStripMenuItem.Text = "Crear Antecedente";
            this.crearAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.crearAntecedenteToolStripMenuItem_Click);
            // 
            // buscarAntecedenteToolStripMenuItem
            // 
            this.buscarAntecedenteToolStripMenuItem.Name = "buscarAntecedenteToolStripMenuItem";
            this.buscarAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.buscarAntecedenteToolStripMenuItem.Text = "Buscar Antecedente";
            this.buscarAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.buscarAntecedenteToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMaterialToolStripMenuItem,
            this.buscarMaterialToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // crearMaterialToolStripMenuItem
            // 
            this.crearMaterialToolStripMenuItem.Name = "crearMaterialToolStripMenuItem";
            this.crearMaterialToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.crearMaterialToolStripMenuItem.Text = "Crear Material ";
            this.crearMaterialToolStripMenuItem.Click += new System.EventHandler(this.crearMaterialToolStripMenuItem_Click);
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar Material";
            this.buscarMaterialToolStripMenuItem.Click += new System.EventHandler(this.buscarMaterialToolStripMenuItem_Click);
            // 
            // ejercicioToolStripMenuItem
            // 
            this.ejercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEjercicioToolStripMenuItem,
            this.buscarEjercicioToolStripMenuItem});
            this.ejercicioToolStripMenuItem.Name = "ejercicioToolStripMenuItem";
            this.ejercicioToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ejercicioToolStripMenuItem.Text = "Ejercicio";
            // 
            // crearEjercicioToolStripMenuItem
            // 
            this.crearEjercicioToolStripMenuItem.Name = "crearEjercicioToolStripMenuItem";
            this.crearEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.crearEjercicioToolStripMenuItem.Text = "Crear Ejercicio";
            this.crearEjercicioToolStripMenuItem.Click += new System.EventHandler(this.crearEjercicioToolStripMenuItem_Click);
            // 
            // buscarEjercicioToolStripMenuItem
            // 
            this.buscarEjercicioToolStripMenuItem.Name = "buscarEjercicioToolStripMenuItem";
            this.buscarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarEjercicioToolStripMenuItem.Text = "Buscar Ejercicio";
            this.buscarEjercicioToolStripMenuItem.Click += new System.EventHandler(this.buscarEjercicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // VerTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_EliminarMateriales);
            this.Controls.Add(this.gb_informacionDeLaTecnica);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VerTecnica";
            this.Text = "Modificar técnica";
            this.Load += new System.EventHandler(this.VerTecnica_Load);
            this.gb_informacionDeLaTecnica.ResumeLayout(false);
            this.gb_informacionDeLaTecnica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).EndInit();
            this.GB_EliminarMateriales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDeLaTecnica;
        private System.Windows.Forms.NumericUpDown NUD_Precio;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_EliminarMaterial;
        private System.Windows.Forms.GroupBox GB_EliminarMateriales;
        private System.Windows.Forms.ComboBox CB_MaterialesRequeridos;
        private System.Windows.Forms.Button BTN_EliminarRequisito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_AñadirRequisito;
        private System.Windows.Forms.ComboBox CB_NuevoMaterialRequerido;
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