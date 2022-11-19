using RYSE.STOREONLINE.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente = RYSE.STOREONLINE.DAL.Entities.Cliente;

namespace RYSE.STOREONLINE.DAL.Interfaces
{
    public interface IClienteRepository
    {
        void Save(Cliente cliente);

        void Update(Cliente cliente);

        void Remove(Cliente cliente);

        Cliente GetClientes(int clienteID);

        bool Exists(int clienteID);

        IEnumerable<Cliente> GetAll();
    }
}
