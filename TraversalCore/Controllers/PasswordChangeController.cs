using AutoMapper.Internal;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
	[AllowAnonymous]
	public class PasswordChangeController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public PasswordChangeController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
		{
			var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
			string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
			var passwordResetTokenLink = Url.Action("ResetPassword","PasswordChange", new
			{
				userId = user.Id,
				token = passwordResetToken
			},HttpContext.Request.Scheme);

			MimeMessage mimeMessage = new MimeMessage();
			MailboxAddress mailboxAdressFrom = new MailboxAddress("Admin", "formyprojectsmail1@gmail.com");
			mimeMessage.From.Add(mailboxAdressFrom);

			MailboxAddress mailboxAdressTo = new MailboxAddress("User", forgetPasswordViewModel.Mail);
			mimeMessage.To.Add(mailboxAdressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = passwordResetTokenLink;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = "Şifre değişiklik talebi";
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 587, false);
			smtpClient.Authenticate("formyprojectsmail1@gmail.com","dfhwzjnvuietvhml");
			smtpClient.Send(mimeMessage);
			smtpClient.Disconnect(true);

			return View();
		}

		[HttpGet]
		public IActionResult ResetPassword(string userId, string token)
		{
			TempData["userid"] = userId;
			TempData["token"] = token;
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
			var userId = TempData["userid"];
			var token = TempData["token"];
			
			if(userId == null || token == null)
			{
				//hata
			}
			var user = await _userManager.FindByIdAsync(userId.ToString());
			var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);

			if(resetPasswordViewModel.Password != resetPasswordViewModel.ConfirmPassword)
			{
				TempData["NotMatch"] = "Şifreler birbiriyle aynı olmalıdır ! Kontrol edip tekrar deneyiniz.";
			}

			if (result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}
            
			return View();
        }
    }
}
