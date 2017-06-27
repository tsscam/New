using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class FourSideCls: Shape
    {
        private double side1, side2, side3, side4;

        public double Side1
        {
            get
            {
                return Side1;
            }

            set
            {
                Side1 = value;
            }
        }

        public double Side2
        {
            get
            {
                return Side2;
            }

            set
            {
                Side2 = value;
            }
        }

        public double Side3
        {
            get
            {
                return Side3;
            }

            set
            {
                Side3 = value;
            }
        }

        public double Side4
        {
            get
            {
                return Side4;
            }

            set
            {
                Side4 = value;
            }
        }


        public override double GetCircumference()
        {
            double perimeter = Side1 + Side2 + Side3 + Side4;
            return perimeter;
        }
    }
}
        

