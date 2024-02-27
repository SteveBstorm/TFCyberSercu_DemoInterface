using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public abstract class Vehicule : IVehicule
    {

        public string Couleur { get; set; }

        public abstract void SeDeplacer();
    }
}
