using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;

namespace TMS
{
    class CreateReceipt : ServiceInstance
    {

        string token = new
         LoginFunctions().GetToken("projecttms2019@gmail.com", "m6080405");

        // Receipt for general client
        // CHECK
        public Document CreateDocumentGeneralClient(string ck_number,string Ac_num ,string Bk_name,string Bk_br,string name,string id,DateTime docDate, DateTime BillDate ,double amount,string docDetails,string C_Email)
        {
            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,
                },
                Currency = "ILS",
                /*
             calculate the tax backwards , for example ,
            if your price input is 100 , this would be the total
                sum and the tax would be -100 / 1.17
                */
                TaxIncluded = true,

                DocumentType = (int)DocumentType.Receipt,
                IssueDate = docDate,
                
                Payments = new Payment[]{
                        new Payment(){
                            Date=BillDate,
                            Amount=amount,
                            BankName = Bk_name,
                            BranchName = Bk_br,
                           AccountNumber = Ac_num,
                           PaymentNumber = ck_number,
                            PaymentType=(int)
                            PaymentTypes.Check
                        },
                },

           
                 
                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = docDetails,
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
                    Mail = C_Email,
                    IsUserMail = false
                }
            },
                // You can add your own guide 
                //    to track the documents later on your side
                ApiIdentifier = Guid.NewGuid().ToString()
            };

            doc = apiSrv.CreateDocument(doc, token);

            if (doc.Errors.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show("ישנה טעות בהפקת המסמך");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("מסמך הופק ונשלח אל הלקוח בהצלחה");
            }
            return doc;
        }

        // money transfer bill

        public Document CreateDocumentGeneralClient( string Ac_num, string Bk_name, string Bk_br, string name, string id, DateTime docDate, DateTime BillDate, double amount, string docDetails, string C_Email)
        {
            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,
                },
                Currency = "ILS",
                /*
             calculate the tax backwards , for example ,
            if your price input is 100 , this would be the total
                sum and the tax would be -100 / 1.17
                */
                TaxIncluded = true,

                DocumentType = (int)DocumentType.Receipt,
                IssueDate = docDate,

                Payments = new Payment[]{
                        new Payment(){
                            Date=BillDate,
                            Amount=amount,
                            BankName = Bk_name,
                            BranchName = Bk_br,
                           AccountNumber = Ac_num,
                      //     PaymentNumber = ck_number,
                            PaymentType=(int)
                            PaymentTypes.MoneyTransfer
                        },
                },



                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = docDetails,
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
                    Mail = C_Email,
                    IsUserMail = false
                }
            },
                // You can add your own guide 
                //    to track the documents later on your side
                ApiIdentifier = Guid.NewGuid().ToString()
            };

            doc = apiSrv.CreateDocument(doc, token);

            if (doc.Errors.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show("ישנה טעות בהפקת המסמך");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("מסמך הופק ונשלח אל הלקוח בהצלחה");
            }
            return doc;
        }
        // bill for cash
        public Document CreateDocumentGeneralClient( string name, string id, DateTime docDate, DateTime BillDate, double amount, string docDetails, string C_Email)
        {
            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = name,
                    Identifier = id,
                },
                Currency = "ILS",
                /*
             calculate the tax backwards , for example ,
            if your price input is 100 , this would be the total
                sum and the tax would be -100 / 1.17
                */
                TaxIncluded = true,

                DocumentType = (int)DocumentType.Receipt,
                IssueDate = docDate,

                Payments = new Payment[]{
                        new Payment(){
                            Date=BillDate,
                            Amount=amount,
                            PaymentType=(int)
                            PaymentTypes.Cash
                        },
                },



                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = docDetails,
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
                    Mail = C_Email,
                    IsUserMail = false
                }
            },
                // You can add your own guide 
                //    to track the documents later on your side
                ApiIdentifier = Guid.NewGuid().ToString()
            };

            doc = apiSrv.CreateDocument(doc, token);

            if (doc.Errors.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show("ישנה טעות בהפקת המסמך");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("מסמך הופק ונשלח אל הלקוח בהצלחה");
            }
            return doc;
        }


        /*  PaymentTypes enum*/
        public enum PaymentTypes
        {
            CreditCard = 1,
            Check = 2,
            MoneyTransfer = 3,
            Cash = 4,
            Credit = 5,
            WithholdingTax = 6

        }

    }

    
}

