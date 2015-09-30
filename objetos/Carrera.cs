using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Carrera
    {
        private List<Corredor> corredores;
        private DateTime horario;
        private Pista pista;

        public List<Corredor> Corredores
        {
            get { return corredores; }
            set { corredores = value; }
        }
        public DateTime Horario
        {
            get { return horario;}
            set { horario = value;}
        }
        public Pista Pista
        {
            get { return pista; }
            set { pista = value; }
        }

        public void anoto()
        {
        }

    }
}