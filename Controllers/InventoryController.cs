using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Interfaces;
using api.Database;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // GET: api/Inventory
        [HttpGet]
        public List<Inventory> Get()
        {
            IGetAllProducts readProducts = new InventoryDataAccess();
            return readProducts.GetAllProducts();
        }

        // GET: api/Inventory/5
        [HttpGet("{id}", Name = "Get")]
        public Inventory Get(int id)
        {
            IGetAllProducts oneProduct = new InventoryDataAccess();
            return oneProduct.GetOneProduct(id);
        }

        // POST: api/Inventory
        [HttpPost]
        public void Post([FromBody] Inventory value)
        {
            IAddToInventory newInventory = new AddToInventory();
            newInventory.AddProduct(value);
        }

        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Inventory value)
        {
            IEditInventoryCount quantityEdit = new EditInventoryCount();
            quantityEdit.EditQty(id, value);
        }

        // DELETE: api/Inventory/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IRemoveFromInventory noProduct = new RemoveFromInventory();
            noProduct.OutOfStockProduct(id);
        }
    }
}