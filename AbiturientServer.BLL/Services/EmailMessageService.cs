using AbiturientServer.BLL.Interfaces;
using AbiturientServer.DAL.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.BLL.Services
{
    public class EmailMessageService : IMessageService
    {
        private readonly MailSettings _mailSettings;
        public EmailMessageService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendMessageAsync(string toEmail, string subject, string body)
        {
            MimeMessage emailMessage = new MimeMessage();
            Debug.WriteLine(_mailSettings.DisplayName);
            MailboxAddress from = new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Mail);
            //emailMessage.From.Add(MailboxAddress.Parse(_mailSettings.Mail));
            emailMessage.From.Add(from);
            emailMessage.To.Add(MailboxAddress.Parse(toEmail));
            emailMessage.Subject = subject;
            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = body;
            emailMessage.Body = builder.ToMessageBody();

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Connect(_mailSettings.Host, _mailSettings.Port);
                smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(emailMessage);
                smtp.Disconnect(true);
            }
        }
    }
}
