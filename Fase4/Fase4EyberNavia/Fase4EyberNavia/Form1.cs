namespace Fase4EyberNavia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ( pass.Text =="unad")
            {
                Men�Escenarios form = new Men�Escenarios();
                pass.Text = "";             
                form.Show();   
                
                
            }
            else
            {
                MessageBox.Show("Error,Por favor ingrese nuevamente la contrase�a");
                pass.Text = "";
            }
        }
    }
}