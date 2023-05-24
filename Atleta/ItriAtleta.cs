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
    public partial class ItriAtleta : Form
    {
        public ItriAtleta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre a classe TriAtleta e usa o metodo VerHabilidade
            this.Close();
            Triatleta t = new Triatleta();
            t.VerHabilidade();

            // Mostra a habilidade do TriAtleta na tela

            MessageBox.Show("TriAtleta: Pedalar, Correr e Nadar");

               
        }

    }
}
