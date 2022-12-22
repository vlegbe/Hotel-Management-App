using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HotelManagement.Services.EmailSender;

namespace HotelManagement.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}