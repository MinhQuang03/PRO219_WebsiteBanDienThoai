using AppData.IRepositories;
using AppData.Models;
using AppData.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public ProductController()
        {

        }
        [HttpGet]        
    
        public List<Product> GetProducts()
        {
            List<Product> lstpro = new List<Product>()
            {
                 new Product {Name = "Iphone 14",Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fm.viettelstore.vn%2Fdien-thoai%2Fiphone-14-pro-max-pid293824.html&psig=AOvVaw0D_IGKOD-eRnC8OtPabTUO&ust=1693323856748000&source=images&cd=vfe&opi=89978449&ved=0CA4QjRxqFwoTCKjzgojZ_4ADFQAAAAAdAAAAABAD",Price = 10000 },
                 new Product {Name = "Iphone 1",Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Ffptshop.com.vn%2Fdien-thoai%2Fiphone-14-pro-max&psig=AOvVaw0D_IGKOD-eRnC8OtPabTUO&ust=1693323856748000&source=images&cd=vfe&opi=89978449&ved=0CA8QjRxqFwoTCKjzgojZ_4ADFQAAAAAdAAAAABAH",Price = 20000 },
                 new Product {Name = "Iphone 2",Image = "iphone2.jpg",Price = 30000 },
                 new Product {Name = "Iphone 3",Image = "iphone3.jpg",Price = 40000 }
            };

            return lstpro;
        }

    }
}
