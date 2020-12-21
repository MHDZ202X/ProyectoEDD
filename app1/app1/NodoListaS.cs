using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class NodolistaS
    {
        //VARIABLES
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private NodolistaS siguiente;

        public NodolistaS Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        //CONSTRUCTORES
        public NodolistaS(int numero, string nombre, NodolistaS siguiente)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.siguiente = siguiente;
        }

    }
}
