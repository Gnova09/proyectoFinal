    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Now;
            Deleted = false;
        }
        public int UserCreation { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserModify { get; set; }
        public DateTime ModifyDate { get; set; }
        public int UserDelete { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Deleted { get; set; }

    }
}
