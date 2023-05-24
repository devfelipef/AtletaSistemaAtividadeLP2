using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    class Corredor : Atleta
    {
        public override void VerHabilidade()
        {
            Console.WriteLine("Corredor: Correr");
        }
    }
}
