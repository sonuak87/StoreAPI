using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Entity;
using Store.IStoreRepository;

namespace Store.DAL
{
    public class StoreRepository : IStore, IDisposable
    {
        private DataContaxt _context;
        public StoreRepository(DataContaxt coontext)
        {
            _context = coontext;
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        public Product GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
        
}
