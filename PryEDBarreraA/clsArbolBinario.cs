using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsArbolBinario
    {
        private clsNodo raiz;

        public clsNodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        // ─── AGREGAR (árbol binario de búsqueda por Codigo) ───────────────────
        public void Agregar(clsNodo Nuevo)
        {
            if (raiz == null)
            {
                raiz = Nuevo;
            }
            else
            {
                clsNodo Ant = raiz;
                clsNodo Aux = raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                        Aux = Aux.Anterior;  // Hacia la izquierda
                    else
                        Aux = Aux.Siguiente; // Hacia la derecha
                }
                if (Nuevo.Codigo < Ant.Codigo)
                    Ant.Anterior = Nuevo;
                else
                    Ant.Siguiente = Nuevo;
            }
        }

        // ─── BUSCAR ───────────────────────────────────────────────────────────
        public clsNodo Buscar(int codigoBuscado)
        {
            return BuscarRecursivo(raiz, codigoBuscado);
        }

        private clsNodo BuscarRecursivo(clsNodo actual, int codigoBuscado)
        {
            if (actual == null)
                return null;

            if (codigoBuscado == actual.Codigo)
                return actual;
            else if (codigoBuscado < actual.Codigo)
                return BuscarRecursivo(actual.Anterior, codigoBuscado);
            else
                return BuscarRecursivo(actual.Siguiente, codigoBuscado);
        }

        // ─── RECORRIDOS A ARCHIVO ─────────────────────────────────────────────
        public void Recorrer()
        {
            StreamWriter sw = new StreamWriter("Arbol.txt");
            RecorrerEscribirArchivo(raiz, sw);
            sw.Close();
        }

        private void RecorrerEscribirArchivo(clsNodo actual, StreamWriter sw)
        {
            if (actual == null) return;
            RecorrerEscribirArchivo(actual.Anterior, sw);
            sw.WriteLine(actual.Codigo + "," + actual.Nombre + "," + actual.Tramite);
            RecorrerEscribirArchivo(actual.Siguiente, sw);
        }

        // ─── RECORRER → DataGridView (Según el RadioButton) ───────────────────
        public void Recorrer(DataGridView Grilla, string orden)
        {
            Grilla.Rows.Clear();

            switch (orden)
            {
                case "InOrden":
                    RecorrerInOrden(raiz, Grilla);
                    break;
                case "PreOrden":
                    RecorrerPreOrden(raiz, Grilla);
                    break;
                case "PostOrden":
                    RecorrerPostOrden(raiz, Grilla);
                    break;
            }
        }

        // Izquierda -> Raíz -> Derecha
        private void RecorrerInOrden(clsNodo actual, DataGridView Grilla)
        {
            if (actual == null) return;
            RecorrerInOrden(actual.Anterior, Grilla);
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
            RecorrerInOrden(actual.Siguiente, Grilla);
        }

        // Raíz -> Izquierda -> Derecha
        private void RecorrerPreOrden(clsNodo actual, DataGridView Grilla)
        {
            if (actual == null) return;
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
            RecorrerPreOrden(actual.Anterior, Grilla);
            RecorrerPreOrden(actual.Siguiente, Grilla);
        }

        // Izquierda -> Derecha -> Raíz
        private void RecorrerPostOrden(clsNodo actual, DataGridView Grilla)
        {
            if (actual == null) return;
            RecorrerPostOrden(actual.Anterior, Grilla);
            RecorrerPostOrden(actual.Siguiente, Grilla);
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
        }

        // ─── RECORRER → TreeView (Estructura visual) ──────────────────────────
        public void Recorrer(TreeView arbol)
        {
            arbol.Nodes.Clear();
            if (raiz == null) return;

            TreeNode nodoRaiz = new TreeNode("Raíz: " + raiz.Codigo + " - " + raiz.Nombre);
            arbol.Nodes.Add(nodoRaiz);

            RecorrerTreeView(raiz, nodoRaiz);
            arbol.ExpandAll();
        }

        private void RecorrerTreeView(clsNodo actual, TreeNode nodoActual)
        {
            // Hijo izquierdo (Anterior)
            if (actual.Anterior != null)
            {
                TreeNode nodoIzq = new TreeNode("Izq: " + actual.Anterior.Codigo + " - " + actual.Anterior.Nombre);
                nodoActual.Nodes.Add(nodoIzq);
                RecorrerTreeView(actual.Anterior, nodoIzq);
            }

            // Hijo derecho (Siguiente)
            if (actual.Siguiente != null)
            {
                TreeNode nodoDer = new TreeNode("Der: " + actual.Siguiente.Codigo + " - " + actual.Siguiente.Nombre);
                nodoActual.Nodes.Add(nodoDer);
                RecorrerTreeView(actual.Siguiente, nodoDer);
            }
        }

        // ─── RECORRER → ListBox ───────────────────────────────────────────────
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            RecorrerLista(raiz, Lista);
        }

        private void RecorrerLista(clsNodo actual, ListBox Lista)
        {
            if (actual == null) return;

            RecorrerLista(actual.Anterior, Lista);
            Lista.Items.Add(actual.Codigo + " - " + actual.Nombre);
            RecorrerLista(actual.Siguiente, Lista);
        }

        // ─── EQUILIBRAR ───────────────────────────────────────────────────────────
        public void Equilibrar()
        {
            int total = ContarNodos(raiz);
            if (total == 0) return;

            clsNodo[] arr = new clsNodo[total];
            int i = 0;
            RecolectarInOrden(raiz, arr, ref i);

            raiz = null;
            raiz = ConstruirEquilibrado(arr, 0, total - 1);
        }

        private int ContarNodos(clsNodo actual)
        {
            if (actual == null) return 0;
            return 1 + ContarNodos(actual.Anterior) + ContarNodos(actual.Siguiente);
        }

        private void RecolectarInOrden(clsNodo actual, clsNodo[] arr, ref int i)
        {
            if (actual == null) return;
            RecolectarInOrden(actual.Anterior, arr, ref i);
            arr[i++] = actual;
            RecolectarInOrden(actual.Siguiente, arr, ref i);
        }

        private clsNodo ConstruirEquilibrado(clsNodo[] arr, int inicio, int fin)
        {
            if (inicio > fin) return null;

            int medio = (inicio + fin) / 2;
            clsNodo nodo = arr[medio];

            nodo.Anterior = null;
            nodo.Siguiente = null;

            nodo.Anterior = ConstruirEquilibrado(arr, inicio, medio - 1);
            nodo.Siguiente = ConstruirEquilibrado(arr, medio + 1, fin);

            return nodo;
        }

        // ─── ELIMINAR ─────────────────────────────────────────────────────────────
        public bool Eliminar(int codigo)
        {
            bool eliminado = false;
            raiz = EliminarRecursivo(raiz, codigo, ref eliminado);
            return eliminado;
        }

        private clsNodo EliminarRecursivo(clsNodo actual, int codigo, ref bool eliminado)
        {
            if (actual == null) return null;

            if (codigo < actual.Codigo)
            {
                actual.Anterior = EliminarRecursivo(actual.Anterior, codigo, ref eliminado);
            }
            else if (codigo > actual.Codigo)
            {
                actual.Siguiente = EliminarRecursivo(actual.Siguiente, codigo, ref eliminado);
            }
            else
            {
                eliminado = true;

                if (actual.Anterior == null && actual.Siguiente == null)
                    return null;

                if (actual.Anterior == null)
                    return actual.Siguiente;

                if (actual.Siguiente == null)
                    return actual.Anterior;

                clsNodo sucesor = ObtenerMinimo(actual.Siguiente);

                // Copiar datos del sucesor al nodo actual
                actual.Codigo = sucesor.Codigo;
                actual.Nombre = sucesor.Nombre;
                actual.Tramite = sucesor.Tramite;

                // Eliminar el sucesor del subárbol derecho
                actual.Siguiente = EliminarRecursivo(actual.Siguiente, sucesor.Codigo, ref eliminado);
                eliminado = true;
            }

            return actual;
        }

        private clsNodo ObtenerMinimo(clsNodo actual)
        {
            while (actual.Anterior != null)
                actual = actual.Anterior;
            return actual;
        }

    }
}