using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class ListaCircular2
    {
        private NodoCircular2 head;
        public NodoCircular2 Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaCircular2()
        {
            head = null;
            //empieza la lista vacia
        }
        public ListaCircular2(NodoCircular2 n)
        {
            head = n;//empieza con un nodo
            n.Atras = head;
            n.Siguiente = head;
        }
        public bool Agregar(NodoCircular2 n)
        {
            //agrega nodos en la lista
            NodoCircular2 h = head;
            if (head == null) //Si la lista esta vacia agrega el primer nodo a la lista
            {

                n.Atras = n;
                n.Siguiente = n;
                head = n;
                return true;
            }
            if (Buscar(n.Dato))  //si existe ese nodo no lo agregue
            {
                return false;
            }

            if (n.Dato < head.Dato)//inserta nueva cabeza
            {
                head.Atras.Siguiente = n;
                n.Atras = head.Atras;
                n.Siguiente = head;
                head.Atras = n;
                head = n;
                return true;

            }
            do
            {
                if (n.Dato < h.Siguiente.Dato) //agrega en medio o final
                {
                    break;
                }
                h = h.Siguiente;
            } while (h != head);
            if (n.Dato < h.Siguiente.Dato)
            {
                h.Siguiente.Atras = n;
                n.Atras = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Atras = h.Atras;
                h.Atras.Siguiente = n;
                h.Atras = n;
            }
            return true;
        }
        public bool Buscar(int b) //metodo para buscar un nodo
        {
            NodoCircular2 h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == b)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }
        public int ContarNodos()
        {
            int cuenta = 0; //cuenta empieza de cero
            if (head != null) // si la cabeza es diferente de null
            {
                NodoCircular2 h = head;
                do //hacer 
                {
                    cuenta++; // cuenta incrementa
                    h = h.Siguiente; // h apunta a siguiente
                } while (h != head); // mientras h es diferente de head
            }
            return cuenta; //retorna la cuenta
        }

        public string MostrarDatos()
        {
            NodoCircular2 h = head;
            string s = "";
            do
            {
                s += h.Dato + "-";
                h = h.Siguiente;
            } while (h != head);
            return s;
        }
        public string MostrarDatosAnt()
        {
            NodoCircular2 h = head;
            string s = "";
            do
            {
                s += h.Atras.Dato;
                h = h.Atras;
            } while (h != head);
            return s;

        }
        public void Vaciar()
        {
            head = null; //vaciar la lista
        }
        public bool Eliminar(int b)
        {
            if (Buscar(b))
            {
                NodoCircular2 h = head;

                while (h.Siguiente != head) //mientras no se llegue al ultimo elemento/ no sea el final de la lista 
                {
                    if (h.Dato == b)
                    {
                        break;
                    }

                    h = h.Siguiente;
                }
                h.Atras.Siguiente = h.Siguiente;
                h.Siguiente.Atras = h.Atras;
                if (h == head)
                {

                    head = head.Siguiente;


                }

                return true;

            }
            return false;

            //  if (head == null)
            //  {
            //    return;
            //  }
            //  if (!Buscar(n))
            //  {
            //    return;
            //  }
            //  inicio
            //  if (n == head.Dato)
            //  {
            //    head.Atras.Siguiente = head.Siguiente;
            //    head.Siguiente.Atras = head.Atras;
            //    head = head.Siguiente;
            //    return;
            //  }
            //  Nodo h = head;
            //  do
            //  {
            //    if (n == (h.Siguiente).Dato)
            //    {
            //      if (h.Siguiente.Siguiente != head) //centro
            //      {
            //        h.Siguiente = h.Siguiente.Siguiente;
            //        h.Siguiente.Atras = h;
            //        return;
            //      }
            //      else //final
            //      {
            //        h.Siguiente = head;
            //        head.Atras = head.Atras.Atras;
            //        return;
            //      }
            //    }
            //    h = h.Siguiente;
            //  } while (h != head);
            //hasta aqui es mio
            //Nodo actual = new Nodo();
            //actual = head;
            //Nodo anterior = new Nodo();
            //anterior = null;
            //bool encontrado = false;
            //int nodoBuscado = x;
            //if (actual != null)
            //{
            //  do
            //  {
            //    if (actual.Dato == nodoBuscado)
            //    {
            //      if (actual == head)
            //      {
            //        head = head.Siguiente;
            //        head.Atras = Ultimo;
            //        Ultimo.Siguiente = head;//al llegar aqui "ultimo" a veces es nulo y no borra, tu cambia eso porfi <3

            //      }
            //      else if (actual == Ultimo)
            //      {
            //        Ultimo = anterior;
            //        Ultimo.Siguiente = head;
            //        head.Atras = Ultimo;


            //      }
            //      encontrado = true;

            //    }
            //    anterior = actual;
            //    actual = actual.Siguiente;

            //  } while (actual != head && encontrado != true);
            //  if (!encontrado)
            //  {
            //    return ("\n Nodo no encontrado\n");//return usado para regresar un status de operacion (revisa que entre)
            //  }
            //}
            //else if (actual == null)//pon una condicion para cuando la lista está vacia
            //{
            //  return("\n La lista se encuentra vacía\n");//return usado para regresar un status de operacion (revisa que entre)
            //}
            //  return ("nodo eliminado con exito");//return usado para regresar un status de operacion
        }
        public override string ToString()
        {
            string lista = "";
            NodoCircular2 h = head;
            if (h != null)
            {
                //corregir 
                do
                {
                    lista += h.Dato + "" + h.Dato;
                    h = h.Siguiente;
                } while (h != head);
                return lista;

            }
            return lista = "No Hay Nada";
        }
    }
}


