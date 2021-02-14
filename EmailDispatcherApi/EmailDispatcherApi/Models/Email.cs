using System.Collections.Generic;

namespace EmailDispatcherApi.Models
{
    public class Email
    {
        public List<string> To { get; set; }
        public List<string> Cc { get; set; }
        public string Body { get; set; }
    }
}