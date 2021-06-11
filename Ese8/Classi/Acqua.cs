using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese8.Classi
{
    class Acqua : Merendina
    {
        public override Etichetta Nome { get; } = Etichetta.ACQUA;
        public override double Prezzo { get; set; } = 0.4;
    }
}
