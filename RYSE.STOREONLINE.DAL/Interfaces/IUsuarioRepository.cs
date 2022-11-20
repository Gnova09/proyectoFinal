using RYSE.STOREONLINE.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.DAL.Interfaces
{
    public interface IUsuarioRepository
    {
        void Save(Usuario usuario);

        void Update(Usuario usuario);

        void Remove(Usuario usuario);

        Factura GetUsuario(int usuarioID);

        bool Exists(int usuarioID);

        IEnumerable<Usuario> GetAll();
    }
}
