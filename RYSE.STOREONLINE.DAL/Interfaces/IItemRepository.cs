using Item = RYSE.STOREONLINE.DAL.Entities.Item;

namespace RYSE.STOREONLINE.DAL.Interfaces
{
    public interface IItemRepository
	{
		void Save(Item item);

        void Update(Item item);

        void Remove(Item item);

        Item GetItems( int itemID);

        bool Exists(int itemID);

        IEnumerable<Item> GetAll();

    }
}
