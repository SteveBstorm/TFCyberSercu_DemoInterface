using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface IBateau : IVehicule
    {
        public int NbMoteur { get; set; }

        
    }
}
