﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebApi.Domains;
using ProductWebApi.Interfaces;
using ProductWebApi.Repositories;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private IProductsRepository _productsRepository { get; set; }

        public ProductController()
        {
            _productsRepository = new ProductRepository();
        }

        [HttpPost]
        public IActionResult Post(Products products)
        {
            try
            {
                _productsRepository.Post(products);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productsRepository.GetProducts());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_productsRepository.GetProductsById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Products products)
        {
            try
            {
                _productsRepository.Update(id, products);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) {
            try
            {
                _productsRepository.Delete(id);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
