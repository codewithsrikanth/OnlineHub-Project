using OnlineHub.Entities;

namespace OnlineHub.Services.Interfaces
{
    public interface ICatalogService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<ItemType> GetItemsTypes();
        IEnumerable<Item> GetItems();
        Item GetItem(int id);
        void AddItem(Item item);
        void DeleteItem(int id);
        void UpdateItem(Item item);
    }
}
