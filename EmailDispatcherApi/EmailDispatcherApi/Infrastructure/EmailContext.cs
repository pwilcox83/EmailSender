using EmailDispatcherApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailDispatcherApi.Infrastructure
{
    public class EmailContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailAddress> EmailsAddresses { get; set; }
        
        public EmailContext(DbContextOptions<EmailContext> options) : base(options)
        {
        }
    }
}