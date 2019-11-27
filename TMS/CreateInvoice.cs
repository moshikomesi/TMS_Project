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
// for one line
        public Document CreateDocumentGeneralClient( DateTime date, string id , string name, string details,double price, double quantity,string Cmail,string sub)
        {


            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,


                },
                Currency = "ILS",

                DocumentType = (int)DocumentType.Invoice,
                IssueDate = date,
                Items = new DocumentItem[]
            {
                new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details,
                    Price = price,
                    Quantity = quantity,      
                }
                
                
            },
                
            // you can round the total items sum up to 0.5
            RoundAmount = 0, 
            Subject = sub,
            TaxPercentage = 17,
            AssociatedEmails = new AssociatedEmail[]
            {
                // send info mail to user account mail
                new AssociatedEmail()
                {
                    Mail = "projecttms2019@gmail.com",
                    IsUserMail = true
                },
                // send mail to customer
                new AssociatedEmail()
                {
                    Mail = Cmail,
                    IsUserMail = false
                }
            },
            // You can add your own guide 
          //  to track the documents later on your side
            ApiIdentifier = Guid.NewGuid().ToString()
        };

       

       doc = apiSrv.CreateDocument(doc, token);
            
            /*
        if (doc.Errors.Length > 0)
        {
                System.Windows.Forms.MessageBox.Show("בעיה בהפקת חשבונית");
            }
        else
        {
                System.Windows.Forms.MessageBox.Show("חשבונית הופקה ונשלחה בהצלחה ללקוח");
            }
            */
        return doc;
    }
        public Document CreateDocumentGeneralClient(DateTime date, string id, string name, string details, double price, double quantity, string Cmail, string sub,string details2,double price2, double quantity2 )
        {


            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,


                },
                Currency = "ILS",

                DocumentType = (int)DocumentType.Invoice,
                IssueDate = date,
                Items = new DocumentItem[]
            {
                new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details,
                    Price = price,
                    Quantity = quantity,
                },
                 new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details2,
                    Price = price2,
                    Quantity = quantity2,
                }


            },
                

                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = sub,
                TaxPercentage = 17,
                AssociatedEmails = new AssociatedEmail[]
            {
                // send info mail to user account mail
                new AssociatedEmail()
                {
                    Mail = "projecttms2019@gmail.com",
                    IsUserMail = true
                },
                // send mail to customer
                new AssociatedEmail()
                {
                    Mail = Cmail,
                    IsUserMail = false
                }
            },
                // You can add your own guide 
                //  to track the documents later on your side
                ApiIdentifier = Guid.NewGuid().ToString()
            };



            doc = apiSrv.CreateDocument(doc, token);

            /*
        if (doc.Errors.Length > 0)
        {
                System.Windows.Forms.MessageBox.Show("בעיה בהפקת חשבונית");
            }
        else
        {
                System.Windows.Forms.MessageBox.Show("חשבונית הופקה ונשלחה בהצלחה ללקוח");
            }
            */
            return doc;
        }

        // for 3 lines
        public Document CreateDocumentGeneralClient(DateTime date, string id, string name, string details, double price, double quantity, string Cmail, string sub, string details2, double price2, double quantity2, string details3, double price3, double quantity3)
        {


            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,


                },
                Currency = "ILS",

                DocumentType = (int)DocumentType.Invoice,
                IssueDate = date,
                Items = new DocumentItem[]
            {
                new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details,
                    Price = price,
                    Quantity = quantity,
                },
                 new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details2,
                    Price = price2,
                    Quantity = quantity2,
                },
                  new DocumentItem(){
                    Code = "", // catalog item code
                    Name = details3,
                    Price = price3,
                    Quantity = quantity3,
                },


            },


                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = sub,
                TaxPercentage = 17,
                AssociatedEmails = new AssociatedEmail[]
            {
                // send info mail to user account mail
                new AssociatedEmail()
                {
                    Mail = "projecttms2019@gmail.com",
                    IsUserMail = true
                },
                // send mail to customer
                new AssociatedEmail()
                {
                    Mail = Cmail,
                    IsUserMail = false
                }
            },
                // You can add your own guide 
                //  to track the documents later on your side
                ApiIdentifier = Guid.NewGuid().ToString()
            };



            doc = apiSrv.CreateDocument(doc, token);

            /*
        if (doc.Errors.Length > 0)
        {
                System.Windows.Forms.MessageBox.Show("בעיה בהפקת חשבונית");
            }
        else
        {
                System.Windows.Forms.MessageBox.Show("חשבונית הופקה ונשלחה בהצלחה ללקוח");
            }
            */
            return doc;
        }

    }
}
