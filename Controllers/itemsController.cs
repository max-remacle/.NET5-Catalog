using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{  
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase 
    {
        private readonly InMemItemsRepo repository;
        public ItemsController()
        {
            repository = new InMemItemsRepo();
        }
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null){
                return NotFound();
            }

            return item;
        }
    }
}