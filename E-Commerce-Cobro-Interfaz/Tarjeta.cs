using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Cobro_Interfaz
{
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {          
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPagarFin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 formCobro = new Form1();
            formCobro.Show();
            
        }
    }
}
