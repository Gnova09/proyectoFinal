using RYSE.STOREONLINE.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Entities
{
    public class Cliente: Person
    {
        public int Id { get; set; }
        public int Edad { get; set; }
        public int IdCarrito { get; set; }
    }
}
