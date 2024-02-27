using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class VehiculeAmphibie : Bateau, IVoiture
    {
        public int NbPlace { get; set; }

        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine("je flotte");
        }
    }
}
