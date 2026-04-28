using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    
    internal class clsListSimple
    {
        private clsNodo pri;
        private string NombreArchivo;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
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
        public void Recorrer(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            clsNodo aux = Primero;
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
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
