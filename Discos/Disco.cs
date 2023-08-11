using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discos
{
    internal class Disco
    {
        public string Nombre { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        public Edicion Edicion { get; set; }
    }
}
