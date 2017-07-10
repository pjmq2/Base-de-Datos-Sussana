using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            int result = tecnica.actualizarTecnica(nombreTecnica, TXT_Nombre.Text, TXT_Descripcion.Text, (int)NUD_Precio.Value);
            if(result == 0)
            {
                MessageBox.Show("La técnica ha sido actualizada exitosamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                nombreTecnica = TXT_Nombre.Text;
                TXT_Nombre.BackColor = System.Drawing.SystemColors.Window;
                TXT_Descripcion.BackColor = System.Drawing.SystemColors.Window;
                NUD_Precio.BackColor = System.Drawing.SystemColors.Window;
                NUD_Cantidad.BackColor = System.Drawing.SystemColors.Window;
            } else
            {
                MessageBox.Show("No se ha podido actualizar la técnica.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarTecnica_Click(object sender, EventArgs e)
        {
            int result;
            result = tecnica.eliminarTecnica(nombreTecnica);
            if (result == 0)
            {
                MessageBox.Show("La técnica ha sido borrada exitosamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                BuscarTecnicas buscarTecnicas = new BuscarTecnicas();
                this.Dispose();
                buscarTecnicas.Show();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la técnica, intente eliminar sus requisitos primero.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTN_AñadirRequisito_Click(object sender, EventArgs e)
        {
            int result = tecnica.agregarRequerimientoDeMaterial(nombreTecnica, CB_Materiales.Text, (int)NUD_CantidadNueva.Value);
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
            else
            {
                MessageBox.Show("No se ha podido agregar el requerimiento.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            CB_Materiales.Items.Clear();
            CB_MaterialesRequeridos.Items.Clear();
            this.llenarMateriales();
            this.llenarMaterialesRequeridos();
            NUD_CantidadNueva.Value = 0;
            NUD_CantidadNueva.BackColor = System.Drawing.SystemColors.Window;
        }

        private void BTN_EliminarRequisito_Click(object sender, EventArgs e)
        {
            int result;
            result = tecnica.eliminarRequerimientoDeMaterial(nombreTecnica, CB_MaterialesRequeridos.Text);
            if (result == 0)
            {
                MessageBox.Show("El requerimiento ha sido eliminado correctamente.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                BuscarTecnicas buscarTecnicas = new BuscarTecnicas();
                CB_Materiales.Items.Clear();
                CB_MaterialesRequeridos.Items.Clear();
                this.llenarMateriales();
                this.llenarMaterialesRequeridos();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el requerimiento.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            NUD_Cantidad.Value = 0;
            CB_Materiales.Items.Clear();
            CB_MaterialesRequeridos.Items.Clear();
            llenarMateriales();
            llenarMaterialesRequeridos();
        }

        private void BTN_GuardarCantidad_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = tecnica.actualizarRequerimientoDeMaterial(nombreTecnica, CB_MaterialesRequeridos.Text, (int)NUD_Cantidad.Value);
            if (result == 0)
            {
                MessageBox.Show("La cantidad fue cambiada correctamente",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                BuscarTecnicas buscarTecnicas = new BuscarTecnicas();
                CB_Materiales.Items.Clear();
                CB_MaterialesRequeridos.Items.Clear();
                this.llenarMateriales();
                this.llenarMaterialesRequeridos();
                NUD_Cantidad.Value = 0;
                NUD_Cantidad.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                MessageBox.Show("No se ha podido cambiar la cantidad.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void llenarMaterialesRequeridos()
        {
            SqlDataReader datos = tecnica.obtenerListaMaterialesRequeridos(nombreTecnica);

            if (datos != null)
            {
                while (datos.Read())
                {
                    CB_MaterialesRequeridos.Items.Add(datos.GetValue(0));
                }
            }
        }

        private void llenarMateriales()
        {
            SqlDataReader datos = tecnica.obtenerListaMaterialesNoRequeridos(nombreTecnica);

            if (datos != null)
            {
                while (datos.Read())
                {
                    CB_Materiales.Items.Add(datos.GetValue(0));
                }
            }
        }

        private void VerTecnica_Load(object sender, EventArgs e)
        {
            cambios = false;
            BTN_AñadirRequisito.Enabled = false;
            this.TXT_Nombre.Text = nombreTecnica;
            this.NUD_Precio.Value = precio;
            this.TXT_Descripcion.Text = tecnica.consultarDescripcion(nombreTecnica);
            this.llenarMaterialesRequeridos();
            this.llenarMateriales();
        }

        #region Métodos de Changed
        private void CB_MaterialesRequeridos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NUD_Cantidad.Value = tecnica.consultarCantidad(nombreTecnica, CB_MaterialesRequeridos.Text);
            this.NUD_Cantidad.BackColor = System.Drawing.SystemColors.Window;
        }

        private void NUD_Precio_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_Precio.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void NUD_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_Cantidad.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void NUD_CantidadNueva_ValueChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                NUD_CantidadNueva.BackColor = System.Drawing.Color.LightBlue;
            }
            if ((int)NUD_CantidadNueva.Value == 0)
            {
                BTN_AñadirRequisito.Enabled = false;
            }
            else
            {
                BTN_AñadirRequisito.Enabled = true;
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
            }
            else
            {
                BTN_Guardar.Enabled = false;
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
        #endregion

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