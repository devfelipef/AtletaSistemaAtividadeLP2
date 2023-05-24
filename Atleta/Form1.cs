namespace Atleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Abre a tela ciclista

            ICiclista telaCiclista = new ICiclista();

            telaCiclista.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ICorredor telaCorredor = new ICorredor();

            telaCorredor.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            INadador telaNadador = new INadador();

            telaNadador.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItriAtleta telaTriatleta = new ItriAtleta();

            telaTriatleta.Show();
        }
    }
}