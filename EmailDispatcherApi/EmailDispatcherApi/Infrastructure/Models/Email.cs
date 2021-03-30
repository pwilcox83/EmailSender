using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace EmailDispatcherApi.Infrastructure.Models
{
    public class Email : Entity
    {
        public List<EmailAddress> To { get; set; }
        public List<EmailAddress> Cc { get; set; }
        public string Body { get; set; }
    }
}