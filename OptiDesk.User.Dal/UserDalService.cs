using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OptiDesk.User.Dto;
using OptiDesk.User.Dto.Pivot;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OptiDesk.User.Dal
{
    public class UserDalService
    {
        public Client GetUser(int id)
        {
            var url = $"https://jsonplaceholder.typicode.com/users/{id}";

            Client res = RestUtility.Fetch<Client>(url);

            return res;
        }

        public List<Client> GetAllUser()
        {
            var url = "https://jsonplaceholder.typicode.com/users/";

            List<Client> res = RestUtility.Fetch<List<Client>>(url);

            return res;
        }

        public bool UpdateUser(int id, Client data)
        {
            var url = $"https://jsonplaceholder.typicode.com/users/{id}";

            RestUtility.Send<Client>(url, Verb.PUT, data);

            return true;
        }

        public bool DeleteUser(int id)
        {
            var url = $"https://jsonplaceholder.typicode.com/users/{id}";

            RestUtility.Send<Client>(url, Verb.DELETE, null);

            return true;
        }
    }
}
