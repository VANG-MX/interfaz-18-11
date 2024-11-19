using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class SolicitarTectnico : Form
    {
        public SolicitarTectnico()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitarTectnico_Load(object sender, EventArgs e)
        {

        }

        private void NRTextBox_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            if(NRTextBox.Text == "")
            {
                button1.Enabled= false;
            }
        }

        private void SEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                NRTextBox.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NRTextBox.Text == "")
            {
                MessageBox.Show("escribe algo");
            }
            else
            {
                this.Close();
            }
        }
    }
}
