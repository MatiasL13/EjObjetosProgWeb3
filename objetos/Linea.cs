using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Linea
    {
        public Punto A;
        public Punto B;

        public Linea()
        {
            A = new Punto();
            B = new Punto();
        }

        public Linea(Punto A, Punto B)
        {
            this.A = A;
            this.B = B;
        }

        public void MueveDerecha(double mov)
        {
            A.X += mov;
            B.X += mov;
        }
        public void MueveIzquierda(double mov)
        {
            A.X -= mov;
            B.X -= mov;
        }
        public void MueveArriba(double mov)
        {
            A.Y += mov;
            B.Y += mov;
        }
        public void MueveAbajo(double mov)
        {
            A.Y -= mov;
            B.Y -= mov;
        }

        public string MostrarLinea()
        {
            return String.Format(" Punto 1 {0},{1} - Punto 2 {2} {3}", this.A.X, this.A.Y, this.B.X, this.B.Y);
        }

    }
}