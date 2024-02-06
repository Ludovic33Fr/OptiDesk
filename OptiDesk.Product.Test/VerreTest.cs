using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptiDesk.Product.Dto.Pivot;
using OptiDesk.Product.Dto;

namespace OptiDesk.Product.Test
{
    [TestClass]
    public class VerreTest
    {
        [TestMethod]
        public void Verre_Constructor_WithValidParam()
        {
            Verre verre = new Verre(1.25, -0.25, 90, TypeVerre.None);

            Assert.IsNotNull(verre);
            Assert.AreEqual<double>(1.25, verre.Sphere);
            Assert.AreEqual<double>(-0.25, verre.Cylindre);
            Assert.AreEqual<int>(90, verre.Axe);
            Assert.AreEqual<double>(verre.Ser, 1.25 + 0.5 * -0.25);
        }

        [TestMethod]
        public void Verre_ConstructorAdd_WithValidParam()
        {
            Verre verre = new Verre(-1.25, 2.75, 0.25, 90, TypeVerre.None);

            Assert.IsNotNull(verre);
            Assert.AreEqual<double>(-1.25, verre.Sphere);
            Assert.AreEqual<double>(2.75, verre.SphereAdd);
            Assert.AreEqual<double>(0.25, verre.Cylindre);
            Assert.AreEqual<int>(90, verre.Axe);
            Assert.AreEqual<double>(verre.Ser, -1.25 + 0.5 * 0.25);
        }

        [TestMethod]
        public void Verre_Constructor_WithInValidParam_Sphere()
        {
            try 
            {
                Verre verre = new Verre(1.54, 0.25, 90, TypeVerre.None);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is VerreParamException);
            }
        }

        [TestMethod]
        public void Verre_Constructor_WithInValidParam_Cylindre()
        {
            try 
            {
                Verre verre = new Verre(1.5, 0.23, 90, TypeVerre.None);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is VerreParamException);
            }
        }

        [TestMethod]
        public void Verre_Constructor_WithInValidParam_Axe()
        {
            try 
            {
                Verre verre = new Verre(1.54, 0.25, 190, TypeVerre.None);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is VerreParamException);
            }
            finally
            {

            }
        }

        [TestMethod]
        public void Verre_ConstructorAdd_WithInValidParam_SphereAdd()
        {
            try 
            {
                Verre verre = new Verre(1.5, -0.25, 0.25, 90, TypeVerre.None);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is VerreParamException);
            }
        }
    }
}
