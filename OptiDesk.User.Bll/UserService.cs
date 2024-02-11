using OptiDesk.User.Dal;
using OptiDesk.User.Dto.Pivot;
using System.Reflection;

namespace OptiDesk.User.Bll
{
    public class UserService : IDisposable
    {
        private UserDalService userDalSvc = new UserDalService(); 

        public void Dispose()
        {
            userDalSvc = null;
        }

        public Client GetClient(int id)
        {
            var res = userDalSvc.GetUser(id);
            res.NumSS = GenererNumeroSecuriteSociale();

            return res;
        }

        public List<Client> GetAllClients()
        {
            var res = userDalSvc.GetAllUser();
            foreach(var client in res)
            {
                client.NumSS = GenererNumeroSecuriteSociale();
            }

            return res;
        }

        public List<Client> GetClientsByName(string name)
        {
            var res = GetAllClients();

            return res.Where<Client>(p => p.name.Contains(name)).ToList();
        }

        private string GenererNumeroSecuriteSociale()
        {
            Random random = new Random();
            int region = random.Next(1, 100);
            int anneeNaissance = random.Next(0, 100);
            int numeroUnique = random.Next(1, 10000);

            // Formatage du numéro de sécurité sociale
            string numeroSecuriteSociale = $"{region:D2}{anneeNaissance:D2}{numeroUnique:D4}";
            return numeroSecuriteSociale;
        }

        public bool UpdateClient(int id, Client model)
        {
           return userDalSvc.UpdateUser(id, model);
        }

        public bool DeleteClient(int id)
        {
            return userDalSvc.DeleteUser(id);
        }
    }
}
