using POOCapasCubo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCapasCubo.Datos
{
    public class RepositorioDeCubos
    {
        public List<Cubo> listaCubos;
        public RepositorioDeCubos()
        {
            listaCubos = new List<Cubo>();
            listaCubos = ManejadroDeArchivosSecuencial.CargarArchivo();
        }
        public void ArgregarCubo(Cubo c) 
        {
            listaCubos.Add(c);
        }
        public int GetCantidad() =>listaCubos.Count();
        public List<Cubo> GetLista()
        {
            return listaCubos;
        }
        public void Guardar()
        {
            ManejadroDeArchivosSecuencial.GuardarArch(listaCubos);
            //Falta si HAY CAMBIOS
        }
        public void Borrar(Cubo cubo)
        {
            listaCubos.Remove(cubo);
        }
        public List<Cubo> OrdenAscendente()
        {
            return listaCubos.OrderBy(p => p.Arista).ToList();
        }

        public List<Cubo> OrdenDescendente()
        {
            return listaCubos.OrderByDescending(p => p.Arista).ToList();
        }

        public List<Cubo> FiltrarPorColor(Colores colorfiltro)
        {
            return listaCubos.Where(p => p.Color == colorfiltro).ToList();
        }
    }
}
