using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptiDesk.Product.Dto.Pivot;
using OptiDesk.Product.Dto;

namespace OptiDesk.Product.Test
{
    [TestClass]
    public class LunetteTest
    {
        [TestMethod]
        public void Lunette_Constructor_WithValidSphereParam()
        {
            Lunette lunette = new Lunette();
            lunette.OeilDroit = new Verre(1.25, -0.25, 90, TypeVerre.None);
            lunette.OeilGauche = new Verre(1.00, -0.25, 90, TypeVerre.None);

            bool test = (Math.Abs(lunette.OeilDroit.Sphere - lunette.OeilGauche.Sphere) <= 0.5);
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void Lunette_Constructor_WithInValidSphereParam()
        {
            Lunette lunette = new Lunette();
            lunette.OeilDroit = new Verre(0.75, -0.25, 90, TypeVerre.None);
            lunette.OeilGauche = new Verre(1.75, -0.25, 90, TypeVerre.None);

            bool test = (Math.Abs(lunette.OeilDroit.Sphere - lunette.OeilGauche.Sphere) <= 0.5);
            Assert.IsFalse(test);
        }
    }
}
