using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsPila : clsEstructurasLineales
    {

        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                nuevo.Siguiente = pri;
                pri = nuevo;
            }
        } 
        public void Eliminar()
        {
            if (pri != null)
            {
                pri = pri.Siguiente;
            }
        }
    }
}
