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
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Descripcion = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.GB_InfoAntecedente = new System.Windows.Forms.GroupBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
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
            this.LBL_Cedula.Location = new System.Drawing.Point(15, 81);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 6;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // LINK_ListaPacientes
            // 
            this.LINK_ListaPacientes.AutoSize = true;
            this.LINK_ListaPacientes.Location = new System.Drawing.Point(408, 26);
            this.LINK_ListaPacientes.Name = "LINK_ListaPacientes";
            this.LINK_ListaPacientes.Size = new System.Drawing.Size(131, 13);
            this.LINK_ListaPacientes.TabIndex = 7;
            this.LINK_ListaPacientes.TabStop = true;
            this.LINK_ListaPacientes.Text = "Ir a Lista de Antecedentes";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(170, 81);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(15, 44);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(127, 13);
            this.LBL_Nombre.TabIndex = 9;
            this.LBL_Nombre.Text = "Nombre del antecedente:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(170, 41);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(154, 20);
            this.TXT_Nombre.TabIndex = 10;
            // 
            // LBL_Descripcion
            // 
            this.LBL_Descripcion.AutoSize = true;
            this.LBL_Descripcion.Location = new System.Drawing.Point(15, 124);
            this.LBL_Descripcion.Name = "LBL_Descripcion";
            this.LBL_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.LBL_Descripcion.TabIndex = 11;
            this.LBL_Descripcion.Text = "Descripción:";
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(170, 124);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(154, 20);
            this.TXT_Descripcion.TabIndex = 12;
            // 
            // GB_InfoAntecedente
            // 
            this.GB_InfoAntecedente.Controls.Add(this.BTN_Agregar);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_Descripcion);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_Descripcion);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_Cedula);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_Nombre);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_Cedula);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_Nombre);
            this.GB_InfoAntecedente.Location = new System.Drawing.Point(31, 62);
            this.GB_InfoAntecedente.Name = "GB_InfoAntecedente";
            this.GB_InfoAntecedente.Size = new System.Drawing.Size(497, 245);
            this.GB_InfoAntecedente.TabIndex = 13;
            this.GB_InfoAntecedente.TabStop = false;
            this.GB_InfoAntecedente.Text = "Detellas del antecedente";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(380, 194);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(90, 35);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            // 
            // AgregarAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 319);
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
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Descripcion;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.GroupBox GB_InfoAntecedente;
        private System.Windows.Forms.Button BTN_Agregar;
    }
}