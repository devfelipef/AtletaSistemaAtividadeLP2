using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atleta
{
    public partial class INadador : Form
    {
        public INadador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre a classe Nadador e usa o metodo VerHabilidade

            Nadador n = new Nadador();
            n.VerHabilidade();

            // Mostra a habilidade do Nadador na tela

            MessageBox.Show("Nadador: Nadar");


        }
    }
}
