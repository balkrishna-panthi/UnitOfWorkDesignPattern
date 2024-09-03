using Domain;
using Microsoft.AspNetCore.Mvc;
using UnitofWork.Interfaces;

namespace PersonalBloggingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class User : ControllerBase
    {


        public  ILoginUnit LoginUnit{ get; set; }

        public User(ILoginUnit loginUnit)
        {
          LoginUnit = loginUnit;
        }

        [HttpGet(Name = "GetAllUsers")]
        public IEnumerable<Domain.User> Get()
        {
            return LoginUnit.Users.GetAll();
        }
    }
}
