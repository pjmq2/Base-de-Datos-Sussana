using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BD_Grupo3_VS
{
    public partial class VerPaciente : Form
    {
        Paciente paciente;
        DatosClinicos datosClinicos;
        bool cambiosNombre = false;
        bool cambiosApellido1 = false;
        bool cambiosApellido2 = false;
        bool cambiosCedula = false;
        bool cambiosSexo = false;
        bool cambiosTelefono = false;
        bool cambiosEmail = false;
        bool cambiosFechaNac = false;
        bool cambiosValoracion = false;
        bool cambiosComentarios = false;
        string nombre;
        string apellido1;
        string apellido2;
        string cedula;
        byte[] archivo;

        public VerPaciente(string cedulaNueva, string nombreNuevo, string apellido1Nuevo, string apellido2Nuevo)
        {
            InitializeComponent();
            paciente = new Paciente();
            nombre = nombreNuevo;
            apellido1 = apellido1Nuevo;
            apellido2 = apellido2Nuevo;
            cedula = cedulaNueva;
            TXT_Nombre.Text = nombre;
            TXT_Apellido1.Text = apellido1;
            TXT_Apellido2.Text = apellido2;
            TXT_Cedula.Text = cedula;
            datosClinicos = new DatosClinicos(cedula);
        }

        private void VerPaciente_Load(object sender, EventArgs e)
        {
            SqlDataReader dato = paciente.obtenerTelefono(TXT_Cedula.Text);
            dato.Read();
            TXT_Telefono.Text = dato.GetString(0);

            dato = paciente.obtenerEmail(TXT_Cedula.Text);
            dato.Read();
            TXT_Email.Text = dato.GetString(0);

            dato = paciente.obtenerSexo(TXT_Cedula.Text);
            dato.Read();
            TXT_Sexo.Text = dato.GetString(0);

            dato = paciente.obtenerValoracion(TXT_Cedula.Text);
            dato.Read();
            TXT_Valoracion.Text = dato.GetString(0);

            dato = paciente.obtenerComentarios(TXT_Cedula.Text);
            dato.Read();
            TXT_Comentarios.Text = dato.GetString(0);

            dato = paciente.obtenerFechaNac(TXT_Cedula.Text);
            dato.Read();
            DTP_FechaNac.Value = dato.GetDateTime(0);

            LBL_NombreCambiante.Text = "Nombre del Paciente: "+nombre +" "+ apellido1 + " " + apellido2;
            llenarComboBoxDatos(CB_DatoClinico);
        }
  

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            paciente.eliminarPaciente(cedula);
            MessageBox.Show("¡El paciente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            bool cambioshechos = true;
            int result;
            if (cambiosCedula)
            {
                result = paciente.modificarCedula(cedula, TXT_Cedula.Text);
                if (result == 2627)
                {
                    MessageBox.Show("Ya existe esta cédula asociada a otro paiente. Por favor ingrese otra.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosNombre)
            {
                result = paciente.modificarNombre(TXT_Cedula.Text, TXT_Nombre.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosApellido1)
            {
                result = paciente.modificarApellido1(TXT_Cedula.Text, TXT_Apellido1.Text);
                if(result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosApellido2)
            {
                result = paciente.modificarApellido2(TXT_Cedula.Text, TXT_Apellido2.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosEmail)
            {
                result = paciente.modificarEmail(TXT_Cedula.Text, TXT_Email.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosTelefono)
            {
                result = paciente.modificarTelefono(TXT_Cedula.Text, TXT_Telefono.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosFechaNac)
            {
                string s = DTP_FechaNac.Value.ToString("yyyyMMdd");
                result = paciente.modificarFechaNac(TXT_Cedula.Text, s);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosValoracion)
            {
                result = paciente.modificarValoracion(TXT_Cedula.Text, TXT_Valoracion.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosComentarios)
            {
                result = paciente.modificarComentarios(TXT_Cedula.Text, TXT_Comentarios.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }

            if (cambioshechos)
            {
                MessageBox.Show("¡El paciente se ha sido modificado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                //this.VerPaciente_Load(this, null);
                //this.Refresh();
                VerPaciente vp = new VerPaciente(TXT_Cedula.Text, TXT_Nombre.Text, TXT_Apellido1.Text, TXT_Apellido2.Text);
                this.Dispose();
                vp.Show();
                
            }
        }

        #region cambio color de fondo
        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambiosNombre)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosNombre = true;
        }

        private void TXT_Apellido1_TextChanged(object sender, EventArgs e)
        {           
            if (cambiosApellido1)
            {
                TXT_Apellido1.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosApellido1 = true;
        }

        private void TXT_Apellido2_TextChanged(object sender, EventArgs e)
        {           
            if (cambiosApellido2)
            {
                TXT_Apellido2.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosApellido2 = true;
        }

        private void TXT_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (cambiosCedula)
            {
                TXT_Cedula.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosCedula = true;
        }

        private void TXT_Sexo_TextChanged(object sender, EventArgs e)
        {
            if (cambiosSexo)
            {
                TXT_Sexo.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosSexo = true;
        }

        private void TXT_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (cambiosTelefono)
            {
                TXT_Telefono.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosTelefono = true;
        }

        private void TXT_Email_TextChanged(object sender, EventArgs e)
        {
            if (cambiosEmail)
            {
                TXT_Email.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosEmail = true;
        }

        //No se cambia
        private void DTP_FechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (cambiosFechaNac)
            {
                DTP_FechaNac.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
                //DTP_FechaNac
            }
            cambiosFechaNac = true;
        }

        private void TXT_Valoracion_TextChanged(object sender, EventArgs e)
        {
            if (cambiosValoracion)
            {
                TXT_Valoracion.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosValoracion = true;
        }

        private void TXT_Comentarios_TextChanged(object sender, EventArgs e)
        {
            if (cambiosComentarios)
            {
                TXT_Comentarios.BackColor = System.Drawing.Color.LightBlue;
            }
                cambiosComentarios = true;           
        }
#endregion

        private void llenarComboBoxDatos(ComboBox combo)
        {
            SqlDataReader datos = datosClinicos.obtenerLista();
            if (datos != null)
            {
                while (datos.Read())
                {
                    combo.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                combo.Items.Clear();
            }
            combo.SelectedItem = 0;
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[PDF]|*.pdf"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                archivo = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(archivo, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array       

                MessageBox.Show("Archivo Cargado Exitosamente!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
            }
            else
            {
                MessageBox.Show("Favor seleccionar una archivo .pdf!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        private void BTN_GuardaDatosClinicos_Click(object sender, EventArgs e)
        {
            bool cambiosGuardados = false;
            if (CB_DatoClinico.Text!="" && archivo != null)
            {
                datosClinicos.agregarDato(CB_DatoClinico.Text);
                datosClinicos.insertarArchivo(CB_DatoClinico.Text, archivo);
                MessageBox.Show("Dato guardado Exitosamente!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
                cambiosGuardados = true;
            }
            else if (CB_DatoClinico.Text != "" && archivo == null)
            {
                datosClinicos.agregarDato(CB_DatoClinico.Text);
                MessageBox.Show("Dato guardado Exitosamente!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
                cambiosGuardados = true;
            }
            else
            {
                MessageBox.Show("Favor seleccionar una archivo .pdf y un valor correcto para Datos!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
            if (cambiosGuardados)
            {
                VerPaciente paciente = new VerPaciente(cedula, nombre, apellido1, apellido2);
                paciente.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] archivoDescargar;
            if (CB_DatoClinico.Text != "")
            {
                MessageBox.Show("Empieza descarga");
                archivoDescargar = datosClinicos.obtenerArchivo(CB_DatoClinico.Text);
                SaveFileDialog saveFile = new SaveFileDialog();
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(saveFile.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);
                    sw.Write(archivoDescargar);
                    MessageBox.Show("El archivo se guardo Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
                }
            }
            else
            {
                MessageBox.Show("Favor seleccionar un valor correcto para Datos!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        #region Menu
        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void avanzadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void crearPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }


        /*             Hasta aqui las instrucciones de la cinta del menu  */
        #endregion

        
    }
}
