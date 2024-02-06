using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.Product.Dto.Pivot
{
    public class Verre
    {
        private double sphere;
        private double sphereAdd;
        private double cylindre;
        private int axe;

        #region Accessors
        public double Sphere
        {
            get
            {
                return sphere;
            }
            private set
            {
                CheckAndSet(ref sphere, value, "Sphere", -10, 10);
            }
        }

        public double SphereAdd
        {
            get
            {
                return sphereAdd;
            }
            private set
            {
                CheckAndSet(ref sphereAdd, value, "Sphere secondaire", 0.75, 3.0);
            }
        }

        public double Cylindre
        {
            get
            {
                return cylindre;
            }
            private set
            {
                CheckAndSet(ref cylindre, value, "Cylindre", -10, 10);
            }
        }

        public int Axe
        {
            get
            {
                return axe;
            }
            private set
            {
                if (value >= 0 && value <= 180)
                    axe = value;
                else
                    throw new VerreParamException("Axe", value);
            }
        }

        public double Ser
        {
            get
            {
                return Sphere + 0.5 * Cylindre;
            }
        }

        public TypeVerre Type
        {
            get;
            private set;
        }

        public Correction Correction
        {
            get;
            private set;
        }
        #endregion

        #region Constructors
        public Verre(double sphere, double cylindrique, int axe, TypeVerre type)
        {
            this.Sphere = sphere;
            this.Cylindre = cylindrique;
            this.Axe = axe;
            this.Type = type;
        }

        public Verre(double sphere, double sphereAdd, double cylindrique, int axe, TypeVerre type)
            : this(sphere, cylindrique, axe, type)
        {
            this.SphereAdd = sphereAdd;
        }
        #endregion

        #region Private method
        private void CheckAndSet(ref double sphere, double value, string nom, double min, double max)
        {
            if (value >= min && value <= max && ((value * 100) % 25).Equals(0.0))
                sphere = value;
            else
                throw new VerreParamException(nom, value);
        }
        #endregion
    }
}
