using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public class Employe : User
    {
        #region Attributs
        public const string EmptyValue = "TBD";
        private string login { get; set; }
        private string password { get; set; }
        private static List<string> listeConnection = new List<string>();
        #endregion

        #region Constructors
        public Employe(string nom, string email) : base(nom, email)
        {
            this.login = EmptyValue;
            this.password = EmptyValue;
        } 
        #endregion

        #region Méthodes
        public bool Login(string login, string password)
        {
            bool result = this.login.Equals(login) && this.password.Equals(password);

            if (result)
                Employe.listeConnection.Add(login);

            return result;
        }

        public void Logout()
        {
            listeConnection.Remove(login);
        }
        
        public static int NombreConnecte()
        {
            return Employe.listeConnection.Count;
        }

        public override string SePresenter()
        {
            return string.Format("{0} {1} / lg:{2}", email, name, login);
        } 
        #endregion
    }
}
