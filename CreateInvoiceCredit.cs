using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ServiceReference1;
namespace TMS
{
    public class CreateInvoiceCredit : ServiceInstance
    {
        string token = new LoginFunctions().GetToken
        ("projecttms2019@gmail.com", "m6080405");
        // CreateInvoiceCredit for regular client
        public Document CreateDocumentRegularCustomer(int id, string InvoiceNum, double sum, string customerEmail)
        {
            Document doc = new Document()
            {
                //using for InvoiceCredit

                ClientID = id,
                DocumentType = (int)DocumentType.InvoiceCredit,
                Subject = "עבור חשבונית מס : " + InvoiceNum,
                Currency = "ILS",
                // can be at the Past no erlierthen last invoice
                IssueDate = DateTime.Now,
                Total = sum,
                CreditAmount = sum,
                Invoices = GetInvoices
                (token, sum, DocumentType.InvoiceCredit, InvoiceNum),
                DocumentReffType = (int)DocumentType.Invoice,

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
                    Mail =customerEmail,
                    IsUserMail = false
                }
                },


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

        /* Function for GetInvoices  detail*/
        private Document[]
        GetInvoices(string token, double sumToCredit,
        DocumentType documentType, int docNum)
        {
            // Init array
            Document[] docs = new Document[1];
            //Get document to credit
            DocumentsRequest dr = new
            DocumentsRequest()
            {
                DocumentNumber = docNum,
                Type = DocumentType.Invoice,
                ReportType = ReportTypes.Document
            };
            docs[0] = apiSrv.GetDocuments(dr, token).Response[0];
            //Set Credit Amount
            if (documentType == DocumentType.InvoiceCredit)
                docs[0].CreditAmount = sumToCredit;
            docs[0].ReceiptAmount = sumToCredit;
            return docs;
        }
    }
}