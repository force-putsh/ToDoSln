using Microsoft.AspNetCore.Mvc;
using ToDoApI.Data;
using ToDoApI.Entities;

namespace ToDoApI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return DataFaker.GetUsers();
        }
    }
}
