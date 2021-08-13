using _07_BlazorHosted.Server.Data;
using _07_BlazorHosted.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_BlazorHosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly SqlContext _context;

        public ProductsController(SqlContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var result = _context.Products.ToList();
            var products = new List<Product>();

            foreach (var item in result)
                products.Add(new Product
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    ImageUrl = item.ImageUrl,
                    Price = item.Price,
                    Category = item.Category,
                    Vendor = item.Vendor
                });

            return products;
        }
    }
}