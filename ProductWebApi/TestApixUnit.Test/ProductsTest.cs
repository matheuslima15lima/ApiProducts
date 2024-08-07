using Moq;
using ProductWebApi.Domains;
using ProductWebApi.Interfaces;

namespace TestApixUnit.Test
{
    public class ProductsTest
    {
        /// <summary>
        /// Teste para funcionalidade de listar todos os produtos
        /// </summary>
        [Fact]
        public void Get()
        {
            //Arrange (organizar)

            //Lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products  {IdProduct = Guid.NewGuid(), Name= "Produto1", Price = 78},
                 new Products  {IdProduct = Guid.NewGuid(), Name= "Produto2", Price = 100},
                  new Products  {IdProduct = Guid.NewGuid(), Name= "Produto3", Price = 48}
            };

            //Cria um objeto de simulacao do tipo ProductRepository
            var mockRepository =  new Mock<IProductsRepository>();

            //COnfigura o metodo "GetProducts" para que quando for acionado retorne a lista "mockada"
            mockRepository.Setup(x => x.GetProducts()).Returns(productList);

            //Act (agir)

            //Executando o metodo "GetProducts" e atribue a resposta em result
            var result = mockRepository.Object.GetProducts();

            //Assert (provar)

            Assert.Equal(3, result.Count);

        }

        [Fact]
        public void Post ()
        {
            //Criar o objeto
            Products products = new Products
            {
                IdProduct = Guid.NewGuid(),
                Name = "xpto",
                Price = 45
            };

            //Criar a lista
            List<Products> productList = new List<Products>();
           
            //Cria um objeto de simulacao do tipo ProductRepository
            var mockRepository = new Mock<IProductsRepository>();

           
            //COnfigura o metodo "GetProducts" para que quando for acionado retorne a lista "mockada"
            mockRepository.Setup(x => x.Post(products)).Callback<Products>(x =>productList.Add(products));

            //Act (agir)
             mockRepository.Object.Post(products);


            //Assert
            Assert.Contains(products, productList);



        }

        //Delete
        //DoesNotContain
        [Fact]
        public void Delete ()
        {
           
            List<Products> productList = new List<Products>
            {
                new Products  {IdProduct = Guid.NewGuid(), Name= "Produto1", Price = 78},
                 new Products  {IdProduct = Guid.NewGuid(), Name= "Produto2", Price = 100},
                  new Products  {IdProduct = Guid.NewGuid(), Name= "Produto3", Price = 48}
            };

            Products products = new Products();
            var mockRepository = new Mock<IProductsRepository>();

            var produtoDeletar = productList.First();

            mockRepository.Setup(x => x.Delete(produtoDeletar.IdProduct)).Callback(()=>productList.RemoveAll(p=> p.IdProduct == produtoDeletar.IdProduct));


            mockRepository.Object.Delete(produtoDeletar.IdProduct);
            Assert.DoesNotContain(produtoDeletar, productList);
        }

        [Fact]
        public void GetById()
        {
            var id = Guid.NewGuid();
            List<Products> productList = new List<Products>
            {
                new Products  {IdProduct = id, Name= "Produto1", Price = 78},
                 new Products  {IdProduct = Guid.NewGuid(), Name= "Produto2", Price = 100},
                  new Products  {IdProduct = Guid.NewGuid(), Name= "Produto3", Price = 48}
            };
            Products products = new Products();
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetProductsById(products.IdProduct)).Returns(productList.FirstOrDefault(x => x.IdProduct == products.IdProduct)!);
           
            var result = mockRepository.Object.GetProductsById(products.IdProduct);

            Assert.True(result != null);
        }

        [Fact]
         public void Put()
        {
            var productId = Guid.NewGuid();

            Products product = new Products { IdProduct = productId, Name = "Ps2", Price = 100 };

            List<Products> productList = new List<Products>();

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Update(productId, product)).Callback<Guid, Products>((id, p) =>
            {
                var item = productList.FirstOrDefault(x => x.IdProduct == id);


                if (item != null)
                {
                    p.Name = item.Name;
                    p.Price = item.Price;
                    productList.Add(product);
                }
            });

            mockRepository.Object.Update(productId, product);
            Assert.Equal(product.Name, "Ps2");
        }

    }
}