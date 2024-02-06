using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.Product.Dto.Pivot
{
    public class Lunette
    {
        #region Accessors
        public Verre OeilGauche
        {
            get;
            set;
        }

        public Verre OeilDroit
        {
            get;
            set;
        } 
        #endregion

        public Lunette()
        {

        }
    }
}
