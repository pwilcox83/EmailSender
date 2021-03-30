using System.Collections.Generic;
using Mapster;

namespace EmailDispatcherApi.Models
{
    [AdaptTo("Infrastructure.Models.Email"), GenerateMapper]
    public class Email
    {
        public List<string> To { get; set; }
        public List<string> Cc { get; set; }
        public string Body { get; set; }
    }
}