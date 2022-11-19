using RYSE.STOREONLINE.DAL.Entities;

namespace RYSE.STOREONLINE.DAL.Interfaces
{
    public interface IFacturaRepository
    {
        void Save(Factura factura);

        void Update(Factura factura);

        void Remove(Factura factura);

        Factura GetFacturas(int facturaID);

        bool Exists(int facturaID);

        IEnumerable<Factura> GetAll();
    }
}
