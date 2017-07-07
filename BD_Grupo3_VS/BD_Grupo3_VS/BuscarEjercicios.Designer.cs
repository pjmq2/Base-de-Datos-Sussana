namespace BD_Grupo3_VS
{
    partial class BuscarEjercicios
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
            this.LBL_ConsultaDeEjercicios = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.CMB_FiltroNombre = new System.Windows.Forms.ComboBox();
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
            this.LBL_Filtro = new System.Windows.Forms.Label();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.TXT_Filtro = new System.Windows.Forms.TextBox();
            this.DGV_Ejercicios = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ejercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDeEjercicios
            // 
            this.LBL_ConsultaDeEjercicios.AutoSize = true;
            this.LBL_ConsultaDeEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDeEjercicios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_ConsultaDeEjercicios.Location = new System.Drawing.Point(128, 48);
            this.LBL_ConsultaDeEjercicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ConsultaDeEjercicios.Name = "LBL_ConsultaDeEjercicios";
            this.LBL_ConsultaDeEjercicios.Size = new System.Drawing.Size(388, 42);
            this.LBL_ConsultaDeEjercicios.TabIndex = 4;
            this.LBL_ConsultaDeEjercicios.Text = "Consulta de Ejercicios";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(25, 119);
            this.LBL_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(58, 17);
            this.LBL_Nombre.TabIndex = 28;
            this.LBL_Nombre.Text = "Nombre";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Image = global::BD_Grupo3_VS.Properties.Resources.Ejercicio_Buscar;
            this.BTN_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Buscar.Location = new System.Drawing.Point(431, 106);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(105, 92);
            this.BTN_Buscar.TabIndex = 32;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click_1);
            // 
            // CMB_FiltroNombre
            // 
            this.CMB_FiltroNombre.FormattingEnabled = true;
            this.CMB_FiltroNombre.Location = new System.Drawing.Point(89, 116);
            this.CMB_FiltroNombre.Name = "CMB_FiltroNombre";
            this.CMB_FiltroNombre.Size = new System.Drawing.Size(324, 24);
            this.CMB_FiltroNombre.TabIndex = 34;
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
            this.menuStrip1.Size = new System.Drawing.Size(679, 28);
            this.menuStrip1.TabIndex = 35;
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
            // LBL_Filtro
            // 
            this.LBL_Filtro.AutoSize = true;
            this.LBL_Filtro.Location = new System.Drawing.Point(25, 167);
            this.LBL_Filtro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Filtro.Name = "LBL_Filtro";
            this.LBL_Filtro.Size = new System.Drawing.Size(39, 17);
            this.LBL_Filtro.TabIndex = 36;
            this.LBL_Filtro.Text = "Filtro";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Modificar.Image = global::BD_Grupo3_VS.Properties.Resources.Ejercicio_Modificar;
            this.BTN_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Modificar.Location = new System.Drawing.Point(544, 106);
            this.BTN_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(105, 92);
            this.BTN_Modificar.TabIndex = 37;
            this.BTN_Modificar.Text = "Ver/Modificar";
            this.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // TXT_Filtro
            // 
            this.TXT_Filtro.Location = new System.Drawing.Point(89, 164);
            this.TXT_Filtro.Name = "TXT_Filtro";
            this.TXT_Filtro.Size = new System.Drawing.Size(324, 22);
            this.TXT_Filtro.TabIndex = 38;
            // 
            // DGV_Ejercicios
            // 
            this.DGV_Ejercicios.AllowUserToAddRows = false;
            this.DGV_Ejercicios.AllowUserToDeleteRows = false;
            this.DGV_Ejercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ejercicios.Location = new System.Drawing.Point(25, 206);
            this.DGV_Ejercicios.Name = "DGV_Ejercicios";
            this.DGV_Ejercicios.ReadOnly = true;
            this.DGV_Ejercicios.RowTemplate.Height = 24;
            this.DGV_Ejercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Ejercicios.Size = new System.Drawing.Size(623, 298);
            this.DGV_Ejercicios.TabIndex = 39;
            // 
            // ConsultarEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 515);
            this.Controls.Add(this.DGV_Ejercicios);
            this.Controls.Add(this.TXT_Filtro);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.LBL_Filtro);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CMB_FiltroNombre);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.LBL_ConsultaDeEjercicios);
            this.Name = "ConsultarEjercicios";
            this.Text = "ConsultarEjercicios";
            this.Load += new System.EventHandler(this.ConsultarEjercicios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ejercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ConsultaDeEjercicios;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.ComboBox CMB_FiltroNombre;
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
        private System.Windows.Forms.Label LBL_Filtro;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.TextBox TXT_Filtro;
        private System.Windows.Forms.DataGridView DGV_Ejercicios;
    }
}