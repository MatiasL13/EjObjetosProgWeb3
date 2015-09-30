using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Inspector : Persona
    {
        private int matricula;

        public int Matricula
        { 
            get { return matricula;}
            set { matricula = value; }
        }

        public Inspector(string apellido)
            : base(apellido)
        { 

        }

    }
}