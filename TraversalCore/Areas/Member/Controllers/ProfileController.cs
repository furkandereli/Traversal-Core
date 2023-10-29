using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Areas.Member.Models;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.name;
            userEditViewModel.surname = values.surname;
            userEditViewModel.phoneNumber = values.PhoneNumber;
            userEditViewModel.email = values.Email;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.imageUrl = imageName;
            }
            user.name = p.name;
            user.surname = p.surname;
            if (p.password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }
            user.PhoneNumber = p.phoneNumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)            
                return RedirectToAction("SignIn", "Login");
            return View();
        }
    }
}
