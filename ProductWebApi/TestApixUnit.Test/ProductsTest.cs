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

            var produtoDeletar = productList.();

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
            //mockRepository.Setup(x => x.GetProductsById(products.IdProduct)).Returns(p => p.IdProduct == products.id));
            //mockRepository.Setup(x => x.GetProductsById(products.IdProduct)).Callback(() => productList.();

        }

    }
}