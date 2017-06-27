using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class CircleCls: Shape
    {
        private double Radius;


        public double Radius1
        {
            get
            {
                return Radius;
            }

            set
            {
                Radius = value;
            }
        }

        public double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double GetCircumference()
      
        {
            return 2.0 * Math.PI * Radius;
        }
    }
}

