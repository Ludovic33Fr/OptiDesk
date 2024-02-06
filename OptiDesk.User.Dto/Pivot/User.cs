using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dto.Pivot
{
    public abstract class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        #region Méthodes
        /// <summary>
        ///  Méthode abstraite pour décliner son identité
        /// </summary>
        /// <returns></returns>
        public abstract string SePresenter();
        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur : nom / prenom
        /// </summary>
        /// <param name="nom">Nom de la personne</param>
        /// <param name="email">Mail de la personne</param>
        public User(string nom, string email)
        {
            this.name = nom;
            this.email = email; 
        }

        /// <summary>
        /// Constructeur par défault
        /// </summary>
        public User()
        {

        }
        #endregion

    }

    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

}
