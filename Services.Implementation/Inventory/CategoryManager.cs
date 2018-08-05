using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement;
using Services.Interfaces.Inventory.CategoryManagement.Request;
using Services.Interfaces.Inventory.CategoryManagement.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation.Inventory
{
    public class CategoryManager : ICategoryManager
    {
        public async Task<GeneralCategory> Create(NewCategory newRegistry)
        {
            using (InventoryDB db = new InventoryDB())
            {
                Category category = new Category()
                {
                    Name = newRegistry.Name,
                    Description = newRegistry.Description
                };
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                return new GeneralCategory()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                };
            }
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GeneralCategory>> List(Page page)
        {
            using (InventoryDB db = new InventoryDB())
            {
                return await db.Categories.Where(x => x.Deleted == false)
                         .Skip(page.Number * page.Size) //esto es para paginar
                         .Take(page.Size) //esto es para paginar
                         .Select(x => new GeneralCategory()
                         {
                             Id = x.Id,
                             Name = x.Name,
                             Description = x.Description
                         }).ToListAsync();
            }
        }

        public Task<GeneralCategory> Update(UpdateCategory ÚpdateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
