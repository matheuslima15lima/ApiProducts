using ProductWebApi.Contexts;
using ProductWebApi.Domains;
using ProductWebApi.Interfaces;

namespace ProductWebApi.Repositories
{
    public class ProductRepository : IProductsRepository
    {

        private readonly Context _context;

        public ProductRepository()
        {
            _context = new Context();
        }
        public void Delete(Products products)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetProducts()
        {
            try
            {
                return  _context.Products
                    .Select(e=> new Products
                    {
                        IdProduct= e.IdProduct,
                        Name= e.Name,
                        Price = e.Price
                    }).OrderBy(e => e.IdProduct).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Products GetProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Products products)
        {
            try
            {
                _context.Add(products);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void Update(Guid idProduct, Products products)
        {
            throw new NotImplementedException();
        }
    }
}
