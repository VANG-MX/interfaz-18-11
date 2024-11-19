using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class PermisoSalir : Form
    {
        private Conexion mConexion = new Conexion();
        public PermisoSalir()
        {
            InitializeComponent();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NR = Nreloj.Text;
            string QueryPermisoSR = "INSERT INTO historial_salidas Values(null" + "," + NR + ",'" + CorreroTB.Text + "','" + HsCB.SelectedItem + "'," + "0, null)";
            string QueryPermisoCR = "INSERT INTO historial_salidas Values(null" + "," + NR + ",'" + CorreroTB.Text + "','" + HsCB.SelectedItem + "'," + "1" + ",'" + HrCB.SelectedItem + "')";
            
            if(RegresoCB.Checked)
            {
                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand(QueryPermisoCR);
                cmd.Connection = mConexion.getConexion();
                try
                {
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    this.Close();
                }
                catch(Exception ex)
                {

                }
                

                
            }
            else
            {
                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand(QueryPermisoSR);
                cmd.Connection = mConexion.getConexion();
                try
                {
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    this.Close();
                }
                catch (Exception ex)
                {

                }
            }
            
            
            
            

        }

        private void PermisoSalir_Load(object sender, EventArgs e)
        {
            

        }

        public void comprobar()
        {
            if(Aceptado1CB.Checked && Aceptado2CB.Checked)
                EnviarButton.Enabled = true;
            if (!Aceptado1CB.Checked || !Aceptado2CB.Checked)
                EnviarButton.Enabled = false;

        }
        

        private void Aceptado1CB_CheckedChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void Aceptado2CB_CheckedChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(RegresoCB.Checked)
            {
                HrCB.Enabled = true;
            }
            if(!RegresoCB.Checked)
            {
                HrCB.Enabled = false;
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aceptado1CB.Enabled=true;
            Aceptado2CB.Enabled=true;
        }

       
    }
}
