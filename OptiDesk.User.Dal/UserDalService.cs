using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OptiDesk.User.Dto;
using OptiDesk.User.Dto.Pivot;

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
    }
}
