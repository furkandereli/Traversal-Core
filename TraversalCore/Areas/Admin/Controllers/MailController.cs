using Microsoft.AspNetCore.Mvc;
using TraversalCore.Models;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAdressFrom = new MailboxAddress("Admin", "oxt47026@nezid.com");
            mimeMessage.From.Add(mailboxAdressFrom);

            MailboxAddress mailboxAdressTo = new MailboxAddress("User",mailRequest.receiverMail);
            mimeMessage.To.Add(mailboxAdressTo);

            mimeMessage.Subject = mailRequest.subject;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("oxt47026@nezid.com", "123456Aa-");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }
    }
}
