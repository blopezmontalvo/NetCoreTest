using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement.Request;
using Services.Interfaces.Inventory.CategoryManagement.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.CategoryManagement
{
    public interface ICategoryManager : IGeneralManager<GeneralCategory, NewCategory, UpdateCategory>
    {
    }
}
