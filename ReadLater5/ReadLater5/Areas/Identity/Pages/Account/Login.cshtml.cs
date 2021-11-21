using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ReadLater5.Controllers;
using Services;

namespace ReadLater5.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    [Authorize]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IAccountService _auth;

        public LoginModel(
           UserManager<IdentityUser> userManager,
           SignInManager<IdentityUser> signInManager,
           ILogger<LoginModel> logger,
           IEmailSender emailSender,
           IAccountService auth)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _auth = auth;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Email/Username")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "RememberMe")]
            public bool RememberMe { get; set; }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Username doesn't exist.");
                return Page();
            }
            var tokenResponse = await TryCreateAccessToken(user, Input.Password);
            var result = await _signInManager.PasswordSignInAsync(Input.Email,
                         Input.Password, Input.RememberMe, lockoutOnFailure: true);

            if (tokenResponse == null)
            {
                ModelState.AddModelError("", "Invalid Credentials.");
                return Page();
            }
            else 
                return RedirectToAction(nameof(HomeController.Index), "Home");
          
        }

        private async Task<AccessTokenResponse> TryCreateAccessToken(IdentityUser user, string password)
        {
            var passwordConfirmed = await _userManager.CheckPasswordAsync(user, password);
            if (user != null && !passwordConfirmed)
                return null;

            return _auth.BuildAccessToken(user);
        }
    }
}
