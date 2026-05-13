using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsListaDoble : clsEstructurasLineales
    {
        private clsNodo ult;

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
                ult = nuevo;
            }
            else
            {
                if (nuevo.Codigo < pri.Codigo)
                {
                    nuevo.Siguiente = pri;
                    pri.Anterior = nuevo;
                    pri = nuevo;
                }
                else
                {
                    if (nuevo.Codigo > ult.Codigo)
                    {
                        ult.Siguiente = nuevo;
                        nuevo.Anterior = ult;
                        ult = nuevo;
                    }
                    else
                    {
                        clsNodo aux = pri;
                        clsNodo ant = pri;
                        while (aux.Codigo < nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null) break;
                        }
                        nuevo.Siguiente = aux;
                        nuevo.Anterior = aux.Anterior;
                        aux.Anterior.Siguiente = nuevo;
                        aux.Anterior = nuevo;

                    }
                }
            }
        }
        public void Eliminar(int cod)
        {
            if (pri == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            if (Primero.Codigo == cod && Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
                return;
            }

            if (Primero.Codigo == cod)
            {
                Primero = Primero.Siguiente;
                Primero.Anterior = null;
                return;
            }

            if (Ultimo.Codigo == cod)
            {
                Ultimo = Ultimo.Anterior;
                Ultimo.Siguiente = null;
                return;
            }

            clsNodo aux = Primero.Siguiente;
            while (aux != null && aux.Codigo != cod)
            {
                aux = aux.Siguiente;
            }

            if (aux == null)
            {
                MessageBox.Show("Código no encontrado.");
                return;
            }

            aux.Anterior.Siguiente = aux.Siguiente;
            aux.Siguiente.Anterior = aux.Anterior;
        }
        public void Recorrer_desc(DataGridView dgv)
        {
            clsNodo aux = Ultimo;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void Recorrer_desc(ListBox lst)
        {
            clsNodo aux = Ultimo;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void Recorrer_desc(ComboBox cmb)
        {
            clsNodo aux = Ultimo;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void Recorrer_desc()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            clsNodo aux = Ultimo;
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
    }
}

