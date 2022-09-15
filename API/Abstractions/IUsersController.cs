using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public interface IUsersController
{
    Task<ActionResult<IEnumerable<AppUser>>> GetUsers();
    Task<ActionResult<AppUser>> GetUser(int id);
}