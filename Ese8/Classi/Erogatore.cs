using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese8.Classi
{
    public class Erogatore
    {
        public Dictionary<int, Merendina> ER = new Dictionary<int, Merendina>
        {
            [1] = new Buondi(),
            [2] = new Patatine(),
            [3] = new Acqua(),
            [4] = new Aranciata(),
        };
    }
}
