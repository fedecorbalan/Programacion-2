using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class TrenElectrico : Tren
    {
        protected List<Pasajero> pasajeros;

        public TrenElectrico(int cantidad, string destino) : base(cantidad, destino)
        {
            this.pasajeros = new List<Pasajero>();
        }
        public override List<Pasajero> Pasajeros 
        {
            get
            {    
                return this.pasajeros;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            foreach (Pasajero p in this.pasajeros)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString();
        }

        public override string IndicarDestino()
        {
            return $"El tren electrico tiene destino {base.destino}";
        }
    }
}
