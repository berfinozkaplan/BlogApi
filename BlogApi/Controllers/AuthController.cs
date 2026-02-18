using BlogApi.Data;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly BlogContext _context;

        public AuthController(BlogContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // 1. Veritabanında böyle bir kullanıcı var mı?
            var user = _context.Users.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);

            if (user == null)
            {
                return Unauthorized("Kullanıcı adı veya şifre yanlış!");
            }

            // 2. Kullanıcı bulunduysa ona basit bir 'Token' verelim
            // (Normalde burada JWT üretilir ama staj için bu kadarı yeterli)
            var token = "bu-sifreli-bir-token-" + Guid.NewGuid().ToString();

            return Ok(new { Message = "Giriş Başarılı!", Token = token, UserId = user.Id });
        }
    }

    // Giriş yaparken istenecek bilgiler için küçük bir kutucuk (Model)
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}