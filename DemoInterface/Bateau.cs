using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Bateau : Vehicule, IBateau
    {
        public int NbMoteur { get; set; }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je flotte");
        }
    }
}
