using System;
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
    public partial class VerMaterial : Form
    {
        Material materiales;
        string nombreMaterial;
        int precio;
        bool cambios = false;

        public VerMaterial(string nombre, int precio)
        {
            nombreMaterial = nombre;
            this.precio = precio;
            InitializeComponent();
            materiales = new Material();
        }

        private void ModificarMaterial_Load(object sender, EventArgs e)
        {
            TXT_Nombre.Text = nombreMaterial;
            NUD_Precio.Value = precio;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            //Falta código principal
            nombreMaterial = TXT_Nombre.Text;
            TXT_Nombre.BackColor = System.Drawing.SystemColors.Window;
            NUD_Precio.BackColor = System.Drawing.SystemColors.Window;
            TXT_Nombre.Clear();
            NUD_Precio.Value = 0;
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            materiales.eliminarMaterial(nombreMaterial);
        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void NUD_Precio_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_Precio.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios = true;
        }

        /* A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicación", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
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
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
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
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Hide();
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
    }
}