using System;
using System.Collections.Generic;
using System.Linq;
using EmailDispatcherApi.Infrastructure;
using EmailDispatcherApi.Models;
using EmailDispatcherApi.Services.Interfaces;
using Mapster;

namespace EmailDispatcherApi.Services
{
    public class EmailService : IEmailService
    {

        private readonly EmailContext _emailContext;

        public EmailService(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

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

        public bool CreateEmail(Email email)
        {
            try
            {
                var dbEmail = email.Adapt<Infrastructure.Models.Email>();


                _emailContext.Emails.AddAsync(dbEmail);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex);
            }

            return true;
        }
    }
}