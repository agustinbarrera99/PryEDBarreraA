using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDBarreraA
{
    internal class clsNodo
    {
        private int cod;
        private string nom;
        private string tra;
        private clsNodo sig;


        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
