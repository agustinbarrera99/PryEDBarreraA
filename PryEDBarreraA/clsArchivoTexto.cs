using System;
using System.IO;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsArchivoTexto
    {
        public string NombreArchivo;

        public void Grabar(string dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(dato);
            AD.Close();
        }

        public void Grabar(string codigo, string nombre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(codigo);
            AD.Write(";");
            AD.WriteLine(nombre);
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

        private void AsegurarArchivo()
        {
            if (!File.Exists(NombreArchivo))
                File.Create(NombreArchivo).Close();
        }
        public void Recorrer(ListBox lst)
        {
            lst.Items.Clear();
            AsegurarArchivo();

            StreamReader AD = new StreamReader(NombreArchivo);
            string datoLeido = AD.ReadLine();
            while (datoLeido != null)
            {
                if (!string.IsNullOrWhiteSpace(datoLeido))
                    lst.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView dgv)
        {
            dgv.Rows.Clear();
            AsegurarArchivo();

            StreamReader AD = new StreamReader(NombreArchivo);
            string datoLeido = AD.ReadLine();
            while (datoLeido != null)
            {
                if (!string.IsNullOrWhiteSpace(datoLeido))
                    dgv.Rows.Add(datoLeido.Split(';'));
                datoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            AsegurarArchivo();

            StreamReader AD = new StreamReader(NombreArchivo);
            string datoLeido = AD.ReadLine();
            while (datoLeido != null)
            {
                if (!string.IsNullOrWhiteSpace(datoLeido))
                    cmb.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            if (cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }
    }
}