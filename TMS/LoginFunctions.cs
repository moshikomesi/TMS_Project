using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;

namespace TMS
{
    class LoginFunctions
    {
        ApiServiceClient apiSrv = new
    ApiServiceClient("BasicHttpBinding_ApiService1");

        public string GetToken(string email, string password)
        {
            return apiSrv.VerifyLogin(email, password);
        }
     
        public User isAuthenticated(string token)
        {
            return apiSrv.IsAuthenticated(token);
        }
  
    }

}
