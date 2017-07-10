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
        Material material;
        string nombreMaterial;
        int precio;
        bool cambios = false;

        public VerMaterial(string nombre, int precio)
        {
            nombreMaterial = nombre;
            this.precio = precio;
            InitializeComponent();
            material = new Material();
        }

        private void ModificarMaterial_Load(object sender, EventArgs e)
        {
            NUD_Precio.Value = precio;
            TXT_Nombre.Text = nombreMaterial;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            int result = material.actualizarMaterial(nombreMaterial, TXT_Nombre.Text, (int)NUD_Precio.Value);
            if (result == 0)
            {
                MessageBox.Show("El material ha sido actualizado exitosamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);                
                nombreMaterial = TXT_Nombre.Text;
                TXT_Nombre.BackColor = System.Drawing.SystemColors.Window;
                NUD_Precio.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar el material.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            int result = material.eliminarMaterial(nombreMaterial);
            if (result == 0)
            {
                MessageBox.Show("El material ha sido borrado exitosamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                BuscarMateriales buscarMat = new BuscarMateriales();
                buscarMat.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el material, intente eliminar sus requisitos primero.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void NUD_Precio_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_Precio.BackColor = System.Drawing.Color.LightBlue;
            }

        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }

            if (!string.IsNullOrWhiteSpace(this.TXT_Nombre.Text))
            {
                BTN_Guardar.Enabled = true;
                BTN_EliminarMaterial.Enabled = true;
            }
            else
            {
                BTN_Guardar.Enabled = false;
                BTN_EliminarMaterial.Enabled = false;
            }
            cambios = true;
        }

        #region Métodos del Menu Strip
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicación", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            }
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Dispose();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Dispose();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Dispose();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Dispose();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Dispose();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Dispose();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Dispose();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Dispose();
        }
        #endregion
    }
}