namespace BD_Grupo3_VS
{
    partial class AgregarEjercicio
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
            this.lbl_imagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_LoadAndSave = new System.Windows.Forms.Button();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LINK_Eliminar = new System.Windows.Forms.LinkLabel();
            this.LINK_Modificar = new System.Windows.Forms.LinkLabel();
            this.LINK_ConsultarCita = new System.Windows.Forms.LinkLabel();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.gb_informacionDelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_informacionDelMaterial
            // 
            this.gb_informacionDelMaterial.Controls.Add(this.btn_Guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_imagen);
            this.gb_informacionDelMaterial.Controls.Add(this.pictureBox1);
            this.gb_informacionDelMaterial.Controls.Add(this.TXT_Descripcion);
            this.gb_informacionDelMaterial.Controls.Add(this.btn_LoadAndSave);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_descripcion);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.txt_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(48, 93);
            this.gb_informacionDelMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(567, 335);
            this.gb_informacionDelMaterial.TabIndex = 1;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del Ejercicio";
            // 
            // lbl_imagen
            // 
            this.lbl_imagen.AutoSize = true;
            this.lbl_imagen.Location = new System.Drawing.Point(58, 216);
            this.lbl_imagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_imagen.Name = "lbl_imagen";
            this.lbl_imagen.Size = new System.Drawing.Size(58, 17);
            this.lbl_imagen.TabIndex = 12;
            this.lbl_imagen.Text = "Imagen:";
            this.lbl_imagen.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 65);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(162, 83);
            this.TXT_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_Descripcion.Multiline = true;
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(355, 116);
            this.TXT_Descripcion.TabIndex = 10;
            // 
            // btn_LoadAndSave
            // 
            this.btn_LoadAndSave.Location = new System.Drawing.Point(162, 288);
            this.btn_LoadAndSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadAndSave.Name = "btn_LoadAndSave";
            this.btn_LoadAndSave.Size = new System.Drawing.Size(222, 29);
            this.btn_LoadAndSave.TabIndex = 5;
            this.btn_LoadAndSave.Text = "Buscar y Guardar";
            this.btn_LoadAndSave.UseVisualStyleBackColor = true;
            this.btn_LoadAndSave.Click += new System.EventHandler(this.btn_LoadAndSave_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(58, 88);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(86, 17);
            this.lbl_descripcion.TabIndex = 4;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(58, 35);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(162, 31);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(254, 47);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(178, 42);
            this.LBL_Titulo.TabIndex = 7;
            this.LBL_Titulo.Text = "Ejercicios";
            // 
            // LINK_Eliminar
            // 
            this.LINK_Eliminar.AutoSize = true;
            this.LINK_Eliminar.Location = new System.Drawing.Point(401, 19);
            this.LINK_Eliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Eliminar.Name = "LINK_Eliminar";
            this.LINK_Eliminar.Size = new System.Drawing.Size(115, 17);
            this.LINK_Eliminar.TabIndex = 22;
            this.LINK_Eliminar.TabStop = true;
            this.LINK_Eliminar.Text = "Eliminar Ejercicio";
            // 
            // LINK_Modificar
            // 
            this.LINK_Modificar.AutoSize = true;
            this.LINK_Modificar.Location = new System.Drawing.Point(177, 14);
            this.LINK_Modificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Modificar.Name = "LINK_Modificar";
            this.LINK_Modificar.Size = new System.Drawing.Size(122, 17);
            this.LINK_Modificar.TabIndex = 21;
            this.LINK_Modificar.TabStop = true;
            this.LINK_Modificar.Text = "Modificar Ejercicio";
            // 
            // LINK_ConsultarCita
            // 
            this.LINK_ConsultarCita.AutoSize = true;
            this.LINK_ConsultarCita.Location = new System.Drawing.Point(22, 14);
            this.LINK_ConsultarCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_ConsultarCita.Name = "LINK_ConsultarCita";
            this.LINK_ConsultarCita.Size = new System.Drawing.Size(132, 17);
            this.LINK_ConsultarCita.TabIndex = 20;
            this.LINK_ConsultarCita.TabStop = true;
            this.LINK_ConsultarCita.Text = "Consultar Ejercicios";
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.LinkColor = System.Drawing.Color.Blue;
            this.LINK_Menu.Location = new System.Drawing.Point(542, 19);
            this.LINK_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(128, 17);
            this.LINK_Menu.TabIndex = 19;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Ir al Menú Principal";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(445, 253);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(100, 64);
            this.btn_Guardar.TabIndex = 13;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // AgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 441);
            this.Controls.Add(this.LINK_Eliminar);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.LINK_Modificar);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.Controls.Add(this.LINK_ConsultarCita);
            this.Controls.Add(this.LINK_Menu);
            this.Name = "AgregarEjercicio";
            this.Text = "AgregarEjercicio";
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.Button btn_LoadAndSave;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label lbl_imagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.LinkLabel LINK_Eliminar;
        private System.Windows.Forms.LinkLabel LINK_Modificar;
        private System.Windows.Forms.LinkLabel LINK_ConsultarCita;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.Button btn_Guardar;
    }
}