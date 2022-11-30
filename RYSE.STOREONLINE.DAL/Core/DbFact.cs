using Microsoft.EntityFrameworkCore;
using RYSE.STOREONLINE.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Core
{
    public class DbFact : IDbFact
    {
        private readonly DbContext context;
        private bool isDisposed;

        public DbFact(StoreContext context) => this.context = context;
        public DbContext GetDbContext => this.context;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }

            isDisposed = true;

        }
    }
}
