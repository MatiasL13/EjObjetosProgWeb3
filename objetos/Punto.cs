using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PW3.POO;

namespace objetos
{
    public class Punto : IPunto
    {
        private double x;
        private double y;
        public Punto()
        {
            X = 0.0;
            Y = 0.0;
        }
        public Punto(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        { 
            get{return y;}
            set{ y = value;}
        }
}

    }
