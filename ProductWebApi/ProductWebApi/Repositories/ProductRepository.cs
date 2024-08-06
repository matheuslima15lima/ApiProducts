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
        public void Delete(Guid id)
        {
            try
            {
                Products productBuscado = _context.Products.Find(id)!;

                if (productBuscado != null)
                {
                    _context.Products.Remove(productBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
         
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

        public Products GetProductsById(Guid id)
        {
            try
            {
                return _context.Products.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
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
            try
            {
                Products productBuscado = _context.Products.Find(idProduct)!;

                if(productBuscado != null)
                {
                    productBuscado.Name = products.Name;
                    productBuscado.Price = products.Price;
                }

                _context.Products.Update(productBuscado);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
