using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsArchivoTexto
    {
        public string NombreArchivo;

        public void Grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Grabar(string Codigo, string Nombre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(Codigo);
            AD.Write(";");
            AD.WriteLine(Nombre);
            AD.Close();
        }

        public void Grabar(string dato1, string dato2, string dato3)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(dato1);
            AD.Write(";");
            AD.Write(dato2);
            AD.Write(";");
            AD.WriteLine(dato3);
            AD.Close();
        }

        public void Recorrer(ListBox lst)
        {
            String DatoLeido;
            lst.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView dgv)
        {
            String DatoLeido;
            dgv.Rows.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                dgv.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(ComboBox cmb)
        {
            String DatoLeido;
            cmb.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmb.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
            cmb.SelectedIndex = 0;
        }
    }

}
