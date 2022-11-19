using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Core
{
    public class Person : BaseEntity
    {
        
        public string? Name { get; set; }
        public string? Correo { get; set; }
        public string? Tel { get; set; }

    }
}
