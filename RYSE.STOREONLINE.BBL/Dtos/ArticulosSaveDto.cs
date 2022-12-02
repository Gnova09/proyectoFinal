using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.SERVICE.Dtos
{
    public class ArticulosSaveDto
    {
        public string? Description { get; set; }
        public string? Tamano { get; set; }
        public string? Name { get; set; }
        public int Cant { get; set; }
        public int UserCreation { get; set; }
        public DateTime CreationDate { get; set; }

        public ArticulosSaveDto() { //inicializando las variables para que no sean null//
            Description= string.Empty;
            Tamano= string.Empty;
            Name= string.Empty;
            CreationDate = DateTime.Now;
        
        }

    }
}
