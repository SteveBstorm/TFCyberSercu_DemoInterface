using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Voiture : Vehicule, IVoiture
    {
        public int NbPlace { get; set; }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je roule");
        }
    }
}
