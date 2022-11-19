using RYSE.STOREONLINE.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Entities
{
    public class Factura:BaseEntity
    {
        public int Id { get; set; }
        public int IdCarrito { get; set; }
        public string? Articulo { get; set; }
        public int Monto { get; set; }
        public int MontoCDescuento { get; set; }
    }
}
