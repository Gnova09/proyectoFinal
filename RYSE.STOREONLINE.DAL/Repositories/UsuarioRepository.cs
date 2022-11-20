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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly StoreContext context;
        private readonly ILogger<UsuarioRepository> logger;

        public UsuarioRepository(StoreContext context, ILogger<UsuarioRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(int usuarioID)
        {
            try
            {
            return context.Usuarios.Any(cd=>cd.Id== usuarioID);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            try
            {
            return context.Usuarios;
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public Factura GetUsuario(int usuarioID)
        {
            try
            {
                return context.Usuarios.Find(usuarioID);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Remove(Usuario usuario)
        {
            try
            {
                context.Remove(usuario);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Save(Usuario usuario)
        {
            try
            {
                context.Add(usuario);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                context.Update(usuario);
            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }
    }
}
