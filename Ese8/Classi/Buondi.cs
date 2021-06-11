using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese8.Classi
{
    class Buondi : Merendina
    {
        public override Etichetta Nome { get; } = Etichetta.BUONDI;
        public override double Prezzo { get; set; } = 1.00;

        //SE FACCIO COSTRUTTORE NON FUNZIONA! USARE METODO OVERRIDE
        //SE USO Merendina m

    }
}
