using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Reserv
    {
        public String fecIni { get; set; }
        public String fecFin { get; set; }
        public float resAnt { get; set; }
        public String resCliRFC { get; set; }
        public int resCantHab { get; set; }
        public int resCantPer { get; set; }
        public int resHotelId { get; set; }
        public int resHabId { get; set; }
        public String resMetodo { get; set; }
        public String accion { get; set; }
        public int resCod { get; set; }
    }
}
