using Store.Entity;

namespace Store.IStoreRepository
{
    public interface IStore:IDisposable
    {
        IEnumerable<Product> Get();
        Product GetByID(int Id);
        void Insert(Product obj);
        void Delete(int ID);
        void Update(Product obj);
        bool Save();
    }
}
