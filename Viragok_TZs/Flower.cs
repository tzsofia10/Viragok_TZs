using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viragok_TZs
{
    internal class Flower
    {
        public string Fajta { get; set; }
        public int Ar { get; set; }
        public string Szine { get; set; }
       

        public Flower(string sorok) 
        {
            var sor = sorok.Split(";");
            Fajta = sor[0];
            Ar = Convert.ToInt32(sor[1]);
            Szine= sor[2];
            
        }
    }
}
