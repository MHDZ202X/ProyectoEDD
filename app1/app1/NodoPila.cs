using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class NodoPila
    {
        private int dato;
        private NodoPila sig;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoPila Sig
        {
            get { return sig; }
            set { sig = value; }
        }

        public NodoPila()
        {
            dato = 0;
            sig = null;
        }
        public NodoPila(int dato, NodoPila sig)
        {
            this.dato = dato;
            this.sig = sig;
        }




        public override string ToString()
        {
            return dato + "";
        }
    }
}

