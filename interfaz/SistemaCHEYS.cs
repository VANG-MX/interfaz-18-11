using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace interfaz
{
    public partial class SistemaCHEYS : Form
    {
        private Conexion mConexion = new Conexion();
        private VideoCaptureDevice videoSource;

        public SistemaCHEYS()
        {
            InitializeComponent();
            MostrarAllRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Manual();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new PermisoSalir();
            f1.Show();
        }

        private void HoraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new Ayuda();
            f1.Show();
        }

        private void SistemaCHEYS_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            InitializeWebcam();  // Inicia la cámara cuando se carga el formulario
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RelojTB.Text = DateTime.Now.ToShortTimeString();
            FechaTB.Text = DateTime.Now.ToShortDateString();
        }

        private void RelojTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Método actualizado para mostrar registros, ahora con Nombre y Carrera
        public void MostrarAllRegistros()
        {
            // Consulta SQL actualizada para incluir Nombre y Carrera desde la tabla empleados
            string inve = @"SELECT r.No_Reloj, r.Hora, r.Fecha, e.Nombre, e.Carrera 
                            FROM `Registros` r
                            JOIN `empleados` e ON r.No_Reloj = e.No_Reloj";  // Realizando JOIN entre Registros y empleados

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(inve);
                cmd.Connection = mConexion.getConexion();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaAllRegitros.DataSource = dt;  // Asigna los datos al DataGridView
            }
            else
            {
                MessageBox.Show("Problemas de conexion a la DB");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NR = No_RelojTextBox.Text;
            string nombre = string.Empty;
            string carrera = "Desconocida"; // Establecer un valor por defecto para la carrera si no se obtiene de algún lado.

            // Consulta para obtener el nombre y carrera del empleado asociado al NR
            string queryNombreCarrera = "SELECT Nombre, Carrera FROM `empleados` WHERE No_Reloj = @NR";  // Usando la tabla empleados
            MySqlCommand cmdNombreCarrera = new MySqlCommand(queryNombreCarrera);
            cmdNombreCarrera.Connection = mConexion.getConexion();
            cmdNombreCarrera.Parameters.AddWithValue("@NR", NR);

            try
            {
                // Obtener el nombre y carrera del empleado
                MySqlDataReader dr = cmdNombreCarrera.ExecuteReader();
                if (dr.Read())  // Si encuentra un registro
                {
                    nombre = dr.GetString("Nombre");
                    carrera = dr.GetString("Carrera"); // Obtener la carrera del empleado
                }
                dr.Close();

                // Verifica si se obtuvo un nombre
                if (!string.IsNullOrEmpty(nombre))
                {
                    // Realiza la inserción incluyendo el nombre y la carrera
                    string queryInsert = "INSERT INTO registros (No_Reloj, Nombre, Carrera, Hora, Fecha) VALUES (@NR, @Nombre, @Carrera, @Hora, @Fecha)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert);
                    cmdInsert.Connection = mConexion.getConexion();
                    cmdInsert.Parameters.AddWithValue("@NR", NR);
                    cmdInsert.Parameters.AddWithValue("@Nombre", nombre);
                    cmdInsert.Parameters.AddWithValue("@Carrera", carrera); // Insertar la carrera
                    cmdInsert.Parameters.AddWithValue("@Hora", RelojTB.Text);
                    cmdInsert.Parameters.AddWithValue("@Fecha", FechaTB.Text);

                    // Ejecuta la inserción
                    cmdInsert.ExecuteNonQuery();

                    No_RelojTextBox.Text = ""; // Limpia el campo NR
                    MostrarAllRegistros();     // Refresca la lista de registros
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con el No_Reloj proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar registro: " + ex.Message);
            }
        }

        private void No_RelojTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Método para inicializar la cámara
        private void InitializeWebcam()
        {
            // Obtiene la lista de dispositivos de video disponibles
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna cámara.");
                return;
            }

            // Selecciona la primera (y única) cámara disponible
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();  // Inicia la captura del video
        }

        // Evento que maneja los nuevos frames capturados por la cámara
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Establece el frame de la cámara como la imagen en el PictureBox
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        // Detener la cámara cuando el formulario se cierra
        private void SistemaCHEYS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();  // Detener la captura
                videoSource.WaitForStop();   // Espera a que se detenga completamente
            }
        }
    }
}
