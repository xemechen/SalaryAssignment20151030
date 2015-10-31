using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Vector
    {
        public static int TotalVectors { get; set; }
        
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
            Vector.TotalVectors++;
        }

        public Vector()
        {
            this.X = 0.0;
            this.Y = 0.0;
            Vector.TotalVectors++;
        }

        public double Length
        {
            get { return Math.Sqrt(X * X + Y * Y); }
            
        }

        public Vector Add(Vector other)
        {
            this.X += other.X;
            this.Y += other.Y;
            return this;
        }

        public Vector Minus(Vector other)
        {
            this.X -= other.X;
            this.Y -= other.Y;
            return this;
        }

        //public void Minus(Vector other)
        //{
        //    this.X -= other.X;
        //    this.Y -= other.Y;
        //    return;
        //}
    
    }
}
