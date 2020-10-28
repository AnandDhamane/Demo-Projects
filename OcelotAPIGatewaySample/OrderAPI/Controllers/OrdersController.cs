using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase {
        [HttpGet, Route("")]
        public IActionResult Get() {
            Order order_1 = new Order() { Id = 1, Amount = 100 };
            Order order_2 = new Order() { Id = 2, Amount = 200 };

            return Ok(new List<Order> { order_1, order_2 });
        }
    }

    public class Order {
        public int Id { get; set; }
        public double Amount { get; set; }
    }
}
