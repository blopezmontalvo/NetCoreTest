using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestructure.ContextTest
{
    [TestClass]
    public class InventoryContext 
    {
        [AssemblyInitialize]
        public static void EnviromentSetup(TestContext testContext)
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureDeleted();
            }
        }

        [TestMethod]
        public void DatabaseCreation()
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureCreated();
            }
        }

        [TestMethod]
        public void InsertCategory()
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Categories.Add(new Category()
                {
                    Name = "Electrodomesticos",
                    Description = "Equipos electricos para el uso domestico"
                });
                int numberOfChanges = db.SaveChanges();
                Assert.AreEqual(numberOfChanges, 1);
            }
        }



    }
}
