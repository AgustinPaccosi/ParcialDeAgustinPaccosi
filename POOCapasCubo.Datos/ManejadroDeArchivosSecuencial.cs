using POOCapasCubo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCapasCubo.Datos
{
    public static class ManejadroDeArchivosSecuencial
    {
        private static string archivo = "Cubos.txt";
        public static void GuardarArch(List<Cubo> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var cubo in lista)
                {
                    string linea = ConstruirLinea(cubo);
                    escritor.WriteLine(linea);
                }
            }

        }

        private static string ConstruirLinea(Cubo cubo)
        {
            return $"{cubo.Arista}|{cubo.Color.GetHashCode()}|{cubo.Trazo.GetHashCode()}";
        }

        public static List<Cubo> CargarArchivo()
        {
            List<Cubo> lista = new List<Cubo>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Cubo cubo = ConstruirCubo(linea);
                        lista.Add(cubo);
                    }
                }

            }
            return lista;
        }

        private static Cubo ConstruirCubo(string linea)
        {
            var campos = linea.Split('|');
            Cubo cubo = new Cubo()
            {
                Arista = double.Parse(campos[0]),
                Color = (Colores)int.Parse(campos[1]),
                Trazo = (Trazo)int.Parse(campos[2])
            };
            return cubo;
        }
    }
}
