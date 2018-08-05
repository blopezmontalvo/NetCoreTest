using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement;
using Services.Interfaces.Inventory.CategoryManagement.Request;
using Services.Interfaces.Inventory.CategoryManagement.Response;

namespace Presentacion.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            this._categoryManager = categoryManager;
        }

        [HttpPost("Create")]
        public async Task<GeneralCategory> Create([FromBody] NewCategory newRegistry)
        {
            return await this._categoryManager.Create(newRegistry);
        }

        [HttpGet("List")]
        public async Task<List<GeneralCategory>> List(Page page)
        {
            return await this._categoryManager.List(page);
        }

    }
}