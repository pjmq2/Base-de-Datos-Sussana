﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class VerEjercicio : Form
    {
        Ejercicio ejercicio;
        string nombre;
        string descripcion;
        Image imagen;
        byte[] img;

        public VerEjercicio(string nombreNuevo, string descripcionNuevo)
        {
            InitializeComponent();
            ejercicio = new Ejercicio();
            nombre = nombreNuevo;
            TXT_Nombre.Text = nombre;
        }

        private void cargarAtributos()
        {

            descripcion = ejercicio.obtenerDescripcion(nombre);
            imagen = ejercicio.obtenerImagen(nombre) ;

            TXT_Descripcion.Text = descripcion;
            PB_Imagen.Image = imagen;
            PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_LoadAndSave_Click(object sender, EventArgs e)
        {
            if (PB_Imagen != null)
            {
                PB_Imagen.Image.Dispose();
            }

            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[JPG,JPEG]|*.jpg"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(img, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array       

                MessageBox.Show("Image Save Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
                var ms = new MemoryStream(img);
                PB_Imagen.Image = Image.FromStream(ms);
                PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }
    }
}
