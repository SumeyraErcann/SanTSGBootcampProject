using BootcampProje.Application.Interfaces;
using BootcampProje.Application.Models;
using BootcampProje.Data;
using BootcampProje.Domain.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampProje.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;        
        private readonly IEmailService _emailService;        
        private IStringLocalizer<SharedResource> _localizer;

        public UserController(UserDbContext context, IStringLocalizer<SharedResource> localizer, IEmailService emailService)
        {
            _context = context;
            _localizer = localizer;            
            _emailService = emailService;
            
        }
        public IActionResult Index()
        {            
            var kullanıcılar = _context.Users.Where(x=>x.RecStatus=='A').ToList();
            return View(kullanıcılar);
        }       

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult Create(User user)
        {
            //Bu alanda mailimizin gövdesini ve alıcı, gönderici, konu gibi alanları belirtiyoruz.
            //Mail gönderme işlemi
            MailRequest mail = new MailRequest()
            {
                Body = "Kaydınız başarı ile alınmıştır...", //gönderilen mesaj içeriği
                Subject = "BootcampProje Kayıt Onayı", //epostaya iletilen konu başlığı
                ToEmail = user.Email
            };
            _emailService.SendEmailAsync(mail);
            
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var kullanıcı = _context.Users.FirstOrDefault(x => x.Id == id);

            if (kullanıcı == null)
                return NotFound();
            return View(kullanıcı);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost(int? id)
        {
            var kullanıcı = _context.Users.FirstOrDefault(x => x.Id == id);

            if (kullanıcı == null)
                return NotFound();

            _context.Users.Remove(kullanıcı);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var kullanıcı = _context.Users.FirstOrDefault(x => x.Id == id);

            if (kullanıcı == null)
                return NotFound();
            return View(kullanıcı);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            var kullanıcı = _context.Users.FirstOrDefault(x => x.Id == id);

            if (kullanıcı == null)
                return NotFound();

            _context.Users.Remove(kullanıcı);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
