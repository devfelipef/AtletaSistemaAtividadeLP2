using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    class Ciclista : Atleta
    {
        public override void VerHabilidade()
        {
            Console.WriteLine("Ciclista: Pedalar");
        }
    }
}
