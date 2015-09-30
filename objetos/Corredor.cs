using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Corredor : Persona
    {
        public enum CategoriaEnum { Amateur, SemiAmateur, Profesional };
  
        private int edad;
        private int numero;
        private Auto auto;
        private CategoriaEnum categoria;
        

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public CategoriaEnum Categoria
        {
            get { return categoria; }
          
        }
   
        public Auto Auto
        {
            get { return auto; }
        }

        public Corredor(Auto auto, CategoriaEnum categoria, string apellido) :base(apellido)
        {
            this.auto = auto;
            this.categoria = categoria;
            this.apellido = apellido;
        }

        public void Correr()
        {
        }

        public void SubirCambio(int cambio)
        {
            int acceleracion = 0;
            switch (cambio)
            {
                default:
                    break;
                case 1:
                    acceleracion = 1;
                    break;
                case 2:
                    acceleracion = 4;
                    break;
                case 3:
                    acceleracion = 10;
                    break;
                case 4:
                    acceleracion = 20;
                    break;
                case 5:
                    acceleracion = 40;
                    break;      
            }

            auto.Acelerar(acceleracion);
        }

        public void BajarCambio()
        {
        }
        public string Saludar()
        {
           return String.Format("hola! soy {0},{1} - {2}", this.nombre, this.apellido, this.categoria);
        }

        //public override string Despedir() // 
        //{
        //    return "chau";
        //}
        public new string Despedir() // ocultamiento new
        {
            return "chau";
        }
        
    }
}