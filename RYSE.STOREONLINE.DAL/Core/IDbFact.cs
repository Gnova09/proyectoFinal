using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Core
{
    public interface IDbFact
    {
        DbContext GetDbContext { get; }
    }
}
