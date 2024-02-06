using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public class Client : User
    {  
        public string NumSS
        {
            get;
            set;
        } 

        #region Constructors
        public Client(int id, string nom, string email, string numSS)
            : base(nom, email)
        {
            this.NumSS = numSS;
            this.id = id;
        }

        public Client()
        {

        }

        public Client(string email, string nom, string numSS, string adresse, string codePostal, string ville)
            : base(nom, email)
        {
            var address = new Address()
            {
                city = ville,
                street = adresse,
                zipcode = codePostal,
            };
            this.address = address;
        }

        #endregion

        #region Méthodes
        public override string SePresenter()
        {
            return string.Format("#{2}:{0} {1}", this.name, this.email, NumSS);
        } 
        #endregion
    }
}
