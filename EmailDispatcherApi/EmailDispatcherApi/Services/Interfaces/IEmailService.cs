using System.Collections.Generic;
using EmailDispatcherApi.Models;

namespace EmailDispatcherApi.Services.Interfaces
{
    public interface IEmailService
    {
        public IEnumerable<Email> GetEmails();
    }
}