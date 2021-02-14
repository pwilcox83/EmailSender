using System.Collections.Generic;
using System.Linq;
using EmailDispatcherApi.Models;
using EmailDispatcherApi.Services.Interfaces;

namespace EmailDispatcherApi.Services
{
    public class EmailService : IEmailService
    {
        
        
        public IEnumerable<Email> GetEmails()
        {
            return new List<Email>
            {
                new Email
                {
                    Body = "Test",
                    Cc = new List<string> {"p@email.com"},
                    To = new List<string>{"b@email.com"}
                }
            }.ToList();
        }
    }
}