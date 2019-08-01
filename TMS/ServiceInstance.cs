using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;

namespace TMS
{
 public class ServiceInstance
    {
        public ApiServiceClient apiSrv = new
  ApiServiceClient("BasicHttpBinding_ApiService");

        public void ResetService()
        {
            apiSrv = new
            ApiServiceClient("BasicHttpBinding_ApiService");
        }
    }
}
