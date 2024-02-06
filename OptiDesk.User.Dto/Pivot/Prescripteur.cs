using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public class Prescripteur : User
    {
        /// <summary>
        /// Numero du prescripteur. Commence par le numero du département et composé de 9 chiffres
        /// </summary>
        public string Numero
        {
            get;
            private set;
        } 

        public Prescripteur(string nom, string email, string numero)
            : base(nom, email)
        {
            this.Numero = numero;
        }

        #region Méthodes
        public override string SePresenter()
        {
            return string.Format("Dc {0} {1}", this.name, this.email);
        } 
        #endregion
    }
}
