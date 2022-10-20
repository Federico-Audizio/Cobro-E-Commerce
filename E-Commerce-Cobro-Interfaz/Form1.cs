
namespace E_Commerce_Cobro_Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            Tarjeta formTarjeta = new Tarjeta();
            Usuario usuarioNuevo = new Usuario();
            Tarjetaclass tarjeta = new Tarjetaclass(usuarioNuevo);

            if (comboFormaPago.Text == "Tarjeta de credito")
            {
                tarjeta.Tipo = TipoTarjeta.Credito;
                formTarjeta.Show();
                
            }
            else if(comboFormaPago.Text == "Tarjeta de debito")
            {
                tarjeta.Tipo = TipoTarjeta.Debito;
                formTarjeta.Show();
                
                
            }
            else
            {
                MessageBox.Show("Error");
            }
    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}