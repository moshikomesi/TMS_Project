using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;

namespace TMS
{
  public  class Customer : ServiceInstance
    {
        string token = new
  LoginFunctions().GetToken("Testing@test.com", "123456");

        public bool Active { get; private set; }
        public string Address { get; private set; }
        public string Cell { get; private set; }
        public string City { get; private set; }
        public string Email { get; private set; }
        public string Fax { get; private set; }
        public string Name { get; private set; }
        public int OrgID { get; private set; }
        public int PayTerms { get; private set; }
        public string Phone { get; private set; }
        public string UniqueID { get; private set; }
        public string Zip { get; private set; }


        /* Function for Customer Create detail*/
        /*
        public Customer CreateCustomer()
        {
            User User = new LoginFunctions().isAuthenticated(token);
            Customers customer = new Customers()
            {
                Name = ,
                Email = "sample@gmail.com",
                Phone = "0465422356",
                Fax = "046588689",
                Address = "äøçåá äøàùé",
                City = "òéø çùåáä",
                Zip = "523367",
                UniqueID = "064558083",
                OrgID = User.OrganizationID,
                PayTerms = 30,
                Cell = "0522256664",
                Active = true,

            };
            customer= apiSrv.CreateCustomer(customer, token);
            return customer;

        }
        */
    }
    
}
