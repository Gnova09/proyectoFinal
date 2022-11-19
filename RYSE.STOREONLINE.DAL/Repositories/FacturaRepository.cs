using Microsoft.Extensions.Logging;
using RYSE.STOREONLINE.DAL.Context;
using RYSE.STOREONLINE.DAL.Entities;
using RYSE.STOREONLINE.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Repositories
{
    public class FacturaRepository:IFacturaRepository
    {
        private readonly StoreContext context;
        private readonly ILogger<FacturaRepository> logger;

        public FacturaRepository(StoreContext context, ILogger<FacturaRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(int facturaID)
        {
            try
            {
                return context.Facturas.Any(cd => cd.Id == facturaID);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public IEnumerable<Factura> GetAll()
        {
            try
            {
                return context.Facturas;
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public Factura GetFacturas(int facturaID)
        {
            try
            {
                return context.Facturas.Find(facturaID);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Remove(Factura factura)
        {
            try { 
             context.Facturas.Remove(factura);
            }catch(Exception e) {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Save(Factura factura)
        {
            try
            {
             context.Facturas.Add(factura);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Update(Factura factura)
        {
            try
            {
            context.Facturas.Update(factura); 
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }
    }
}
