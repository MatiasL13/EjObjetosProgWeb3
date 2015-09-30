using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PW3.POO;

namespace objetos
{
    public partial class WebForm2 : DibujadorWeb
    {
        static private Auto autoG = new Auto("algo", "uno", "eh");
        static private Corredor conductor = new Corredor(autoG, objetos.Corredor.CategoriaEnum.Amateur, "Perez");
      //  static private Linea linea = new Linea();
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona p;
            Corredor c;

            c = new Corredor(autoG,Corredor.CategoriaEnum.Amateur,"Perez");
            Response.Write(c.Despedir());
            p = c;
            Response.Write(p.Despedir()); 
            // si se llama con override se llama p.Despedir() llama a c.Despedir
            // si se oculta con New, P.Despedir llamara a P.despedir
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Auto autoUno = new Auto("algo", "uno", "eh");
            Corredor c = new Corredor(autoUno, objetos.Corredor.CategoriaEnum.Amateur , "Perez");

            Label1.Text = c.Saludar();
            c.Nombre = "juan";

            Label2.Text = c.Saludar();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int cambio = Int32.Parse(DDLcambio.SelectedItem.ToString());
            conductor.SubirCambio(cambio);
            LBLAceleracion.Text = autoG.Aceleracion.ToString() + "KM/h";
        }


        public Linea Instanciar()
        {
            Punto A = new Punto(double.Parse(txtAX.Text), double.Parse(txtAY.Text));
            Punto B = new Punto(double.Parse(txtBX.Text), double.Parse(txtBY.Text));
            Linea lin = new Linea(A, B);
            return lin;
        }
        protected void ButtonDerecha_Click(object sender, EventArgs e)
        {
            Linea lin = Instanciar();
            lin.MueveDerecha(double.Parse(txtMover.Text));
            DibujarLinea(lin.A.X, lin.A.Y, lin.B.X, lin.B.Y,System.Drawing.Color.Blue);
        }

        protected void ButtonIzquierda_Click(object sender, EventArgs e)
        {
            Linea lin = Instanciar();
            lin.MueveIzquierda(double.Parse(txtMover.Text));
            DibujarLinea(lin.A.X, lin.A.Y, lin.B.X, lin.B.Y, System.Drawing.Color.Blue);
        }

        protected void ButtonArriba_Click(object sender, EventArgs e)
        {
            Linea lin = Instanciar();
            lin.MueveArriba(double.Parse(txtMover.Text));
            DibujarLinea(lin.A.X, lin.A.Y, lin.B.X, lin.B.Y, System.Drawing.Color.Blue);
        }

        protected void ButtonAbajo_Click(object sender, EventArgs e)
        {
            Linea lin = Instanciar();
            lin.MueveAbajo(double.Parse(txtMover.Text));
            DibujarLinea(lin.A.X, lin.A.Y, lin.B.X, lin.B.Y, System.Drawing.Color.Blue);
        }
    }
}