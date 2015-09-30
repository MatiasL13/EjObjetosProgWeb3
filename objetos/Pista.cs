using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace objetos
{
    public class Pista
    {
        public enum DificultadEnum { facil, medio, dificil };
        private float distancia;
        private string terreno;
        private DificultadEnum dificultad;
        private string lugar;

        public float Distancia
        {
            get { return distancia; }
            set {distancia = value;}
        }
        public string Terreno
        {
            get { return terreno; }
            set { terreno = value; }
        }
        public DificultadEnum Dificultad
        {
            get { return dificultad; }
            set { dificultad = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
    }
}