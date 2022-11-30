using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.SERVICE.Dtos
{
    public class ArticulosDeleteDto
    {
        public int Id { get; set; }
        public int UserDelete { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
