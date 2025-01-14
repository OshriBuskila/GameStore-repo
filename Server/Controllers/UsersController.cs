using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GamesStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        [HttpPost("Register")]
        public int Register([FromBody] Userr newUser)
        {

            int result = Userr.Register(newUser.Name, newUser.Email, newUser.Password);

            return result;

        }

        [HttpPost("Login")]
        public Userr Login([FromBody] Userr userToLogin)
        {
            return userToLogin.Login(userToLogin.Email, userToLogin.Password);

        }

        //[HttpPost("UpdateName")]
        //public int UpdateName(int currentID,string newName)
        //{
        //    int result = Userr.UpdateName(currentID, newName);
        //    return result;
        //}
        //[HttpPost("UpdatePassword")]
        //public int UpdatePass(int currentID, string newPass)
        //{
        //    int result = Userr.UpdatePass(currentID, newPass);
        //    return result;
        //}
        [HttpPut("UpdateUser")]
        public Userr UpdateUser([FromBody]Userr changesForUser)
        {
            return Userr.UpdateUser(changesForUser);
        }
    }
}
