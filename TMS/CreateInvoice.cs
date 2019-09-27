using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;

namespace TMS
{
    public class CreateInvoice : ServiceInstance
    {


        string token = new
         LoginFunctions().GetToken("projecttms2019@gmail.com", "m6080405");

        public Document CreateDocumentGeneralClient(int x , string y )
        {
            
           
            Document doc = new Document()
            {
                ClientID =  x ,
                Currency = "ILS",
                
                /* calculate the tax backwards , for example ,
                if your price input is 100 , this would be the total
                sum and the tax would be -100 / 1.17
                TaxIncluded = true,
                */
                DocumentType = (int)DocumentType.InvoiceOrder,
                Items = new DocumentItem[]
            {
                new DocumentItem(){
                    Code ="",// inv.number.ToString(), // catalog item code
                    Name = y,
                    Price = 100,//double.Parse(inv.In_A.Text),
                    Quantity =2, //double.Parse(inv.In_Q.Text)
                }
            },
                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = "Document Subject",
                TaxPercentage = 17,
                AssociatedEmails = new AssociatedEmail[]
            {
                // send info mail to user account mail
                new AssociatedEmail()
                {
                    Mail = "test@test.com",
                    IsUserMail = true
                },
                // send mail to customer
                new AssociatedEmail()
                {
                    Mail = "moshikomesi@gmail.com",//inv.C_Email,
                    IsUserMail = false
                }
            },
            // You can add your own guide 
            
        };

       doc = apiSrv.CreateDocument(doc, token);

        if (doc.Errors.Length > 0)
        {
            // HANDLE ERROR
        }
        else
        {
            // HANDLE SUCCESS
        }
        return doc;
    }

}
}
