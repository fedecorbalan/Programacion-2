using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._3._1
{
    public class Creadora
    {
        private static DateTime fechaCreacionPrimerObjeto;
        private static int contadorObjetosCreados;
        private DateTime fechaCreacion;

        static Creadora()
        {
            Creadora.fechaCreacionPrimerObjeto = DateTime.Now;
            Creadora.contadorObjetosCreados = 0;
        }
        public Creadora() 
        {
            this.fechaCreacion = DateTime.Now;
            Creadora.contadorObjetosCreados++; 
        }
        public static int ObtenerCantidadObjetosCreados()
        {
            return contadorObjetosCreados;
        }
        public string ObtenerDiferencia()
        {
            TimeSpan diferencia = fechaCreacion - fechaCreacionPrimerObjeto;

            return diferencia.TotalMilliseconds.ToString();
        }


    }
}