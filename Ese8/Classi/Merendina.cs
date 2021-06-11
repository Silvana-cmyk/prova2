using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese8.Classi
{
    public enum Etichetta
    {
        BUONDI,
        PATATINE,
        ACQUA,
        ARANCIATA
    }
    public abstract class Merendina
    {
        public abstract Etichetta Nome { get; }
        public abstract double Prezzo { get; set; }
    }
}
