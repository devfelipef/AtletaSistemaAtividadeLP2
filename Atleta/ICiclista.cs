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
    public partial class ICiclista : Form
    {
        public ICiclista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chama a class Ciclista e usa o metodo VerHabilidade
            Ciclista c = new Ciclista();
            c.VerHabilidade();
            

            //O nome da caixa é Ciclista e a habilidade é Pedalar
            MessageBox.Show("Ciclista: Pedalar");


        }
    }
}
