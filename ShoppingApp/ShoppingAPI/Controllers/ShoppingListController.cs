using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models.Api;
using ShoppingAPI.Models.Data;

namespace ShoppingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;
        public ShoppingListController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpPost]
        public CreatedShoppingListResponse CreateShoppingList([FromBody] CreateShoppingListRequest request)
        {
            //_databaseContext.ShoppingLists.ad
        }
    }
}
