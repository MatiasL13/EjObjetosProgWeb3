using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Auto : IDeplazable
    {
        private double aceleracion;
        private string marca;
        private string modelo;
        private string escuderia;


        public Auto(string marcaOut, string modeloOut, string escuderiaOut)
        {
            marca = marcaOut;
            modelo = modeloOut;
            escuderia = escuderiaOut;
        }

        public double Aceleracion
        {
            get { return aceleracion; }
            set { aceleracion =  value; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string Modelo
        {
            get { return modelo; }
        }
        public string Escuderia
        {
            get { return escuderia; }
        }

        public void Acelerar(double aceleracionExtra)
        {
            aceleracion += aceleracionExtra;
        }

    }
}