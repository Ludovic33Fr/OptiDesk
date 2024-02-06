

using OptiDesk.User.Bll;
using OptiDesk.User.Dto.Pivot;

namespace OptiDesk.User.Test
{
    public class EmployeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Personne_Compte_NombreConnecte()
        {
            Employe e1 = new Employe("Nom1", "email1@test.com");
            Employe e2 = new Employe("Nom2", "email1@test.com");

            Assert.That(Employe.NombreConnecte(), Is.EqualTo(0));

            e1.Login(Employe.EmptyValue, Employe.EmptyValue);
            e2.Login(Employe.EmptyValue, Employe.EmptyValue);

            Assert.That(Employe.NombreConnecte(), Is.EqualTo(2));

            e1.Logout();
            Assert.That(Employe.NombreConnecte(), Is.EqualTo(1));
        }
    }
}