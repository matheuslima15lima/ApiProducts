using ProductWebApi.Domains;

namespace ProductWebApi.Interfaces
{
    public interface IProductsRepository
    {
        public  List<Products> GetProducts();

        public Products GetProductsById(int id);

        public void Post(Products products);

        public void Delete(Products products);

        public void Update(Guid idProduct, Products products);
    }
}
