using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Business.UserLogic;

namespace OnlineStore.WebAPI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserLogic userLogic = new UserLogic();
        //add user
        [HttpGet]
        [Route("register")]
        public async Task<Boolean> AddUser(string firstname, string lastname, string email, string gender, string contatctno, string addressline1, string addressline2, string state, string postalcode, string password)
        {
            bool result = await userLogic.CreateNewUser(firstname, lastname, email, gender, contatctno, addressline1, addressline2, state, postalcode, password);
            return result;
        }
    }
}
