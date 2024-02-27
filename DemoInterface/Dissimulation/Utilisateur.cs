using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Dissimulation
{
    public class Utilisateur : IAdmin, IPayement
    {
        public void LireArticle()
        {

        }

        public void Payer(int somme)
        {
            throw new NotImplementedException();
        }

        public void PublierArticle() { }
    }
}
