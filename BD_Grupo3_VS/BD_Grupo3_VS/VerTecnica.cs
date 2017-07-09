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
    public partial class VerTecnica : Form
    {
        Tecnica tecnica;
        string nombreTecnica;
        int precio;
        bool cambios = false;

        public VerTecnica(string nombre, int precio)
        {
            nombreTecnica = nombre;
            this.precio = precio;
            InitializeComponent();
            tecnica = new Tecnica();
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            //Falta código principal
            nombreTecnica = TXT_Nombre.Text;
            TXT_Nombre.BackColor = System.Drawing.SystemColors.Window;
            TXT_Descripcion.BackColor = System.Drawing.SystemColors.Window;
            NUD_Precio.BackColor = System.Drawing.SystemColors.Window;
            NUD_Cantidad.BackColor = System.Drawing.SystemColors.Window;

            TXT_Nombre.Clear();
            NUD_Precio.Value = 0;
        }

        private void BTN_EliminarRequisito_Click(object sender, EventArgs e)
        {

        }

        private void BTN_AñadirRequisito_Click(object sender, EventArgs e)
        {
            int result = tecnica.agregarRequerimientoDeMaterial(nombreTecnica, CB_NuevoMaterialRequerido.Text, (int)NUD_Cantidad.Value);
            if (result == 0)
            {
                MessageBox.Show("El requerimiento ha sido agregado exitosamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
            else if (result == 2627)
            {
                MessageBox.Show("Ya existe dicho requerimiento en el sistema.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            llenarMateriales();
            llenarMaterialesRequeridos();
        }

        private void llenarMaterialesRequeridos()
        {

        }

        private void llenarMateriales()
        {

        }

        private void VerTecnica_Load(object sender, EventArgs e)
        {
            cambios = false;
            this.TXT_Nombre.Text = nombreTecnica;
            this.NUD_Precio.Value = precio;
            this.TXT_Descripcion.Text = tecnica.consultarDescripcion(nombreTecnica);
            this.llenarMaterialesRequeridos();
            this.llenarMateriales();
        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void NUD_Precio_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_Precio.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void NUD_CantidadNueva_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_CantidadNueva.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void TXT_Descripcion_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                TXT_Descripcion.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios = true;
        }

        /*  A partir de aqui empiezan los metodos para la cinta del menu    */
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