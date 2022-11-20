using RYSE.STOREONLINE.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Entities
{
    public class Usuario:Person
    {
        public int Id { get; set; }
        public string? IdUser { get; set; }
        public string? HashPass { get; set; }//password
        public  string? IdCarrito { get; set; }
    }
}
