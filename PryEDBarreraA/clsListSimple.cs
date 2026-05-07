using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    
    internal class clsListSimple : clsEstructurasLineales
    {
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                if (nuevo.Codigo <= pri.Codigo) 
                {
                    nuevo.Siguiente = pri;
                    pri = nuevo;
                } else
                {
                    clsNodo aux = pri;
                    clsNodo ant = null;
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;                  
                    }
                    nuevo.Siguiente = aux;
                    ant.Siguiente = nuevo;
                }
            }
        }

        public void Eliminar(int Codigo)
        {
            if (Primero == null)
            {
                MessageBox.Show("La lista está vacía");
                return;
            }

            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
                return;
            }

            clsNodo aux = Primero;
            clsNodo anterior = null;

            while (aux != null && aux.Codigo != Codigo)
            {
                anterior = aux;
                aux = aux.Siguiente;
            }

            if (aux == null)
            {
                MessageBox.Show("Código no encontrado");
                return;
            }

            anterior.Siguiente = aux.Siguiente;
        }
    }
}
