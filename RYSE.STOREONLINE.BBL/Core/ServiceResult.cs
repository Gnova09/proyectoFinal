using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.SERVICE.Core
{
    public class ServiceResult
    {
        public ServiceResult() { 
            this.Success=true;
            this.Loading=false;
        
        }
        public bool Success { get; set; }
        public bool Loading { get; set; }
        public string? Message { get; set; }
        public dynamic? Data { get; set; }
    }
}
