using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public sealed class Manager : Employe
    {
        #region Constructors
        public Manager(string nom, string email) : base(nom, email)
        {
        } 
        #endregion
    }
}
