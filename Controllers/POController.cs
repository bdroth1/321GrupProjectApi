// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using api.Models;
// using api.Interfaces;
// using api.Database;

// namespace api.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class POController : ControllerBase
//     {
//         // GET: api/Cart
//         [HttpGet]
//         public List<Inventory> Get()
//         {
//             // IGetAllCardProducts readProducts = new CartDataAccess();
//             // return readProducts.GetAllCartProducts();
//         }

//         // GET: api/Cart/5
//         [HttpGet("{id}", Name = "Get")]
//         public string Get(int id)
//         {
//             return "value";
//         }

//         // POST: api/Cart
//         // [HttpPost]
//         // public void Post([FromBody] Cart value)
//         // {
//         // }

//         // // PUT: api/Cart/5
//         // [HttpPut("{id}")]
//         // public void Put(int id, [FromBody] string value)
//         // {
//         // }

//         // // DELETE: api/Cart/5
//         // [HttpDelete("{id}")]
//         // public void Delete([FromBody] Cart value, int id)
//         // {
//         // }
//     }
// }
