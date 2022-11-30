using RYSE.STOREONLINE.DAL.Core;
using Item = RYSE.STOREONLINE.DAL.Entities.Item;

namespace RYSE.STOREONLINE.DAL.Interfaces
{
    public interface IItemRepository: IRepositoryBase<Item>
	{

        Item GetItems( int itemID);

        bool Exists(int itemID);

        IEnumerable<Item> GetAll();

    }
}
