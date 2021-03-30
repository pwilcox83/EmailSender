using EmailDispatcherApi.Models;
using EmailDispatcherApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmailDispatcherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService, ILogger<EmailController> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_emailService.GetEmails());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public IActionResult Post(Email email)
        {
            return Ok(_emailService.CreateEmail(email));
        }
    }
}