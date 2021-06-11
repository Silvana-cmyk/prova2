using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese8.Classi
{
    class Patatine : Merendina
    {
        public override Etichetta Nome { get; } = Etichetta.PATATINE;
        public override double Prezzo { get; set; } = 0.5;
    }
}
