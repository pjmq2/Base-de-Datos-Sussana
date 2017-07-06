﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class AgregarMaterial : Form
    {

        Material material;

        public AgregarMaterial()
        {
            InitializeComponent();
            material = new Material();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int result = material.agregarMaterial(txt_nombre.Text, (int)nud_precio.Value);
            if(result == 0)
            {
                MessageBox.Show("El material ha sido agregado exitosamente",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                txt_nombre.Clear();
                nud_precio.Value = 0;
            } else if(result == 2627)
            {
                MessageBox.Show("Ya existe dicho material en el sistema.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_agregarMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarMaterial agregarMaterial = new AgregarMaterial();
            agregarMaterial.Show();
            this.Hide();
        }

        private void lnk_menuPrincipal_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                //Aun no cierra todo el programa
            }
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Hide();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Hide();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAntecedentes antecedente = new ConsultarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Hide();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Hide();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Hide();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEjercicios ejercicio = new ConsultarEjercicios();
            ejercicio.Show();
            this.Hide();
        }
        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
