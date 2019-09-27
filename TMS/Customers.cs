﻿using System;
using TMS.ServiceReference1;
namespace TMS
{
    public partial class Customers : MetroFramework.Forms.MetroForm
    {

    //    string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";

        public Customers()
        {
            InitializeComponent();
        }
        

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        string token = new
    LoginFunctions().GetToken("Testing@test.com", "123456");

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
            CreateCustomers crc = new CreateCustomers();
            customer = crc.apiSrv.CreateCustomer(customer, token);

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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Customer cust = CreateCustomer();
        }
    }

}