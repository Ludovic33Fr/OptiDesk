using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.Product.Dto
{
    public class VerreParamException : Exception
    {
        public VerreParamException(string nom, double valeur) : base(string.Format("Mauvaise valeur pour {0} : {1}", nom, valeur))
        {
        }

        public VerreParamException(string nom, int valeur) : base(string.Format("Mauvaise valeur pour {0} : {1}", nom, valeur))
        {
        }
    }
}
