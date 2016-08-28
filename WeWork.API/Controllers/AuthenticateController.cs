using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeWork.BusinessDomain;
using WeWork.Logging;
using WeWork.Models;

namespace WeWork.API.Controllers
{
    public class AuthenticateController : ApiController
    {
        
        [HttpGet]
        [Route("api/v1.0/VerifyPassword")]
        public string VerifyPassword()
        {
            AccountType obj=new AccountType{
                Type="Cheque"
            };
            BdAccountType.Save(obj);
            LoggerWrapper.LogError("API.Authenticate").Error("Invalid string",new Exception("str"));
            return "Hello Pinky";
        }
    }
}
