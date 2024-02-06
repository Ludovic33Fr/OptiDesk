using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public class Mutualise : Client
    {
        #region Properties
        public string NumAdherent
        {
            get;
            private set;
        }

        #endregion

        #region Constructors
        public Mutualise(int id, string nom, string email, string numSS, string numAdherent)
            : base(id,nom, email, numSS)
        {
            this.NumAdherent = numAdherent;
        } 
        #endregion
    }
}
