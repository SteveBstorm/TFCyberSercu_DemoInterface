using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Dissimulation
{
    public interface IAdmin : IUtilisateur
    {
        void PublierArticle();
    }
}
