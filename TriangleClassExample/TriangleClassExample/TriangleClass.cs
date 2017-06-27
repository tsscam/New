using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClassExample
{
    class TriangleClass
    {
        private double Base;
        private double Height;

        public double TriangleBase1
        {
            get
            {
                return Base;
            }

            set
            {
                Base = value;
            }
        }

        public double TriangleHeight1
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }
        public TriangleClass()
        {
            Base = 0;
            Height = 0.0;
        }
        //public TriangleClass(double BaseInput, double HeightInput)
        //{
        //    Base = BaseInput;
        //    Height = HeightInput;
        public TriangleClass(double Base, double Height)
        {   // this refers to th global variable (class variables)
            this.Base = Base;
            this.Height = Height;
        }
        public double GetArea()
        {
            return Base * Height * 0.5;
        }
        }
    }

