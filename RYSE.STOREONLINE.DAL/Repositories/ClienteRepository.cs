using Microsoft.Extensions.Logging;
using RYSE.STOREONLINE.DAL.Context;
using RYSE.STOREONLINE.DAL.Entities;
using RYSE.STOREONLINE.DAL.Interfaces;


namespace RYSE.STOREONLINE.DAL.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly StoreContext context;
        private readonly ILogger<ClienteRepository> logger;

        public ClienteRepository(StoreContext context, ILogger<ClienteRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(int clienteID)
        {
            try
            {
            return context.Clientes.Any(cd=> cd.Id== clienteID);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            try
            {
            return context.Clientes;
               
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
                return Enumerable.Empty<Cliente>();
            }
        }

        public Cliente GetClientes(int clienteID)
        {
            try
            {
            return context.Clientes.Find(clienteID);
                
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
                
            }
        }

        public void Remove(Cliente cliente)
        {
            try
            {
             context.Clientes.Remove(cliente);
               
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Save(Cliente cliente)
        {
            try
            {
             context.Clientes.Add(cliente);
              
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                 context.Clientes.Update(cliente);  
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }
    }
}
