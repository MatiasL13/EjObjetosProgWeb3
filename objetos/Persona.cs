using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public  class Persona
    {
        protected string nombre;
        protected string apellido;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
        }

        public Persona(string apellido)
        {
        }

        //public virtual string Despedir()
        //{
        //    return "adios";
        //}
        public string Despedir()
        {
            return "adios";
        }
     
    }
}