using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestDemoBLL;
using UnitTestDemoDAL;

namespace UnitTestDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public ActionResult GetUserById(int id)
        {
            try
            {
                return Ok(_userService.GetUserById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            try
            {
                return Ok(_userService.CreateUser(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }
        [HttpPut]
        public ActionResult UpdateUser(User user)
        {
            try
            {
                return Ok(_userService.UpdateUser(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public ActionResult DeleteUserById(int id)
        {
            try
            {
                return Ok(_userService.DeleteUserById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
