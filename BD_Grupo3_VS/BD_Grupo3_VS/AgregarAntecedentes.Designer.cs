namespace BD_Grupo3_VS
{
    partial class AgregarAntecedentes
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
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.LINK_ListaPacientes = new System.Windows.Forms.LinkLabel();
            this.TXT_NombreAnte = new System.Windows.Forms.TextBox();
            this.LBL_NombreAnte = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Descripcion = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.GB_InfoAntecedente = new System.Windows.Forms.GroupBox();
            this.TXT_TipoAnt = new System.Windows.Forms.TextBox();
            this.LBL_TipoAnt = new System.Windows.Forms.Label();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.GB_InfoAntecedente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(163, 10);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(192, 33);
            this.LBL_Titulo.TabIndex = 5;
            this.LBL_Titulo.Text = "Antecedentes";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(28, 44);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 6;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LINK_ListaPacientes
            // 
            this.LINK_ListaPacientes.AutoSize = true;
            this.LINK_ListaPacientes.Location = new System.Drawing.Point(408, 10);
            this.LINK_ListaPacientes.Name = "LINK_ListaPacientes";
            this.LINK_ListaPacientes.Size = new System.Drawing.Size(131, 13);
            this.LINK_ListaPacientes.TabIndex = 7;
            this.LINK_ListaPacientes.TabStop = true;
            this.LINK_ListaPacientes.Text = "Ir a Lista de Antecedentes";
            // 
            // TXT_NombreAnte
            // 
            this.TXT_NombreAnte.Location = new System.Drawing.Point(170, 81);
            this.TXT_NombreAnte.Name = "TXT_NombreAnte";
            this.TXT_NombreAnte.Size = new System.Drawing.Size(154, 20);
            this.TXT_NombreAnte.TabIndex = 8;
            // 
            // LBL_NombreAnte
            // 
            this.LBL_NombreAnte.AutoSize = true;
            this.LBL_NombreAnte.Location = new System.Drawing.Point(28, 84);
            this.LBL_NombreAnte.Name = "LBL_NombreAnte";
            this.LBL_NombreAnte.Size = new System.Drawing.Size(127, 13);
            this.LBL_NombreAnte.TabIndex = 9;
            this.LBL_NombreAnte.Text = "Nombre del antecedente:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(170, 41);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 10;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(28, 126);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.LBL_Descripcion.TabIndex = 11;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(170, 123);
            this.TXT_Descripcion.Multiline = true;
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(154, 20);
            this.TXT_Descripcion.TabIndex = 12;
            // 
            // GB_InfoAntecedente
            // 
            this.GB_InfoAntecedente.Controls.Add(this.TXT_TipoAnt);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_TipoAnt);
            this.GB_InfoAntecedente.Controls.Add(this.BTN_Agregar);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_Descripcion);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_Descripcion);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_NombreAnte);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_NombreAnte);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_Cedula);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_Cedula);
            this.GB_InfoAntecedente.Location = new System.Drawing.Point(31, 62);
            this.GB_InfoAntecedente.Name = "GB_InfoAntecedente";
            this.GB_InfoAntecedente.Size = new System.Drawing.Size(497, 245);
            this.GB_InfoAntecedente.TabIndex = 13;
            this.GB_InfoAntecedente.TabStop = false;
            this.GB_InfoAntecedente.Text = "Detellas del antecedente";
            // 
            // TXT_TipoAnt
            // 
            this.TXT_TipoAnt.Location = new System.Drawing.Point(170, 187);
            this.TXT_TipoAnt.Name = "TXT_TipoAnt";
            this.TXT_TipoAnt.Size = new System.Drawing.Size(154, 20);
            this.TXT_TipoAnt.TabIndex = 25;
            // 
            // LBL_TipoAnt
            // 
            this.LBL_TipoAnt.AutoSize = true;
            this.LBL_TipoAnt.Location = new System.Drawing.Point(28, 190);
            this.LBL_TipoAnt.Name = "LBL_TipoAnt";
            this.LBL_TipoAnt.Size = new System.Drawing.Size(110, 13);
            this.LBL_TipoAnt.TabIndex = 24;
            this.LBL_TipoAnt.Text = "Tipo de Antecedente:";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(380, 194);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(90, 35);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.LinkColor = System.Drawing.Color.Blue;
            this.LINK_Menu.Location = new System.Drawing.Point(408, 30);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(97, 13);
            this.LINK_Menu.TabIndex = 14;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Ir al Menú Principal";
            // 
            // AgregarAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 319);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.GB_InfoAntecedente);
            this.Controls.Add(this.LINK_ListaPacientes);
            this.Controls.Add(this.LBL_Titulo);
            this.Name = "AgregarAntecedentes";
            this.Text = "AgregarAntecedentes";
            this.GB_InfoAntecedente.ResumeLayout(false);
            this.GB_InfoAntecedente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.LinkLabel LINK_ListaPacientes;
        private System.Windows.Forms.TextBox TXT_NombreAnte;
        private System.Windows.Forms.Label LBL_NombreAnte;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Descripcion;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.GroupBox GB_InfoAntecedente;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.TextBox TXT_TipoAnt;
        private System.Windows.Forms.Label LBL_TipoAnt;
    }
}