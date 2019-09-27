using TMS.ServiceReference1;
namespace TMS
{
    class CreateCustomers: ServiceInstance
    {

        string token = new
LoginFunctions().GetToken("projecttms2019@gmail.com", "m6080405");

        /* Function for Customer Create detail*/
        public Customer CreateCustomer()
        {
            User User = new LoginFunctions().isAuthenticated(token);
            Customer customer = new Customer()
            {
                Name = "New Client",
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

            customer = apiSrv.CreateCustomer(customer, token);

            if (customer.Errors.Length > 0)
            {
                // HANDLE ERROR
            }
            else
            {
                // HANDLE SUCCESS
            }
            return customer;
        }
    }
}
