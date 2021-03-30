using System.Collections.Generic;

namespace EmailDispatcherApi.Models
{
    public class EmailDto
    {
        public string To { get; set; }
        public string Cc { get; set; }
        public string Body { get; set; }
    }
}