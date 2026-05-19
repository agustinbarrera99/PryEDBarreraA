using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsArbolBinario
    {

        public clsNodo Raiz
        {
            get { return Raiz; }
            set { Raiz = value; }
        }

        public void Agregar (clsNodo nuevo)
        {
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (nuevo.Codigo < Aux.Codigo) Aux = Aux.Izquierda;
                    else Aux = Aux.Derecha;
                }
                if (nuevo.Codigo < Ant.Codigo) Ant.Izquierda = nuevo;
                else Ant.Derecha = nuevo;
            }
        }
        public void Recorrer(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrderAsc(dgv, Raiz);
        }
        public void InOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrderAsc(dgv, R.Izquierda);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrderAsc(dgv, R.Derecha);
        }
    }
}
