using ProductWebApi.Domains;

namespace ProductWebApi.Interfaces
{
    public interface IProductsRepository
    {
        public  List<Products> GetProducts();

        public Products GetProductsById(Guid id);

        public void Post(Products products);

        public void Delete(Guid id);

        public void Update(Guid idProduct, Products products);
    }
}
