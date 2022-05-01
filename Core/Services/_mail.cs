using HSoG.Portal.Data;
using FluentEmail.Core;
using FluentEmail.Core.Models;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HSoG.Portal.Services
{
    public interface IEmailSender
    {
        Task SendValidationEmailAsync(string email, string name, string code);
        Task<SendResponse> SendWelcomeEmailAsync(string email, string name);
        Task<SendResponse> SendResetPasswordEmailAsync(string email, string name, string link);
    }

    //=====================

    public class EmailService : IEmailSender
    {
        private string GetTemplate(string name)
        {
            var wrapper = File.ReadAllText(@"wwwroot\templates\_layout.html");

            wrapper = wrapper.Replace("@RenderBody()", File.ReadAllText($@"wwwroot\templates\{name}.html"));

            wrapper = wrapper.Replace("[site_url]", "https://HSoG.Portal.azurewebsites.net");
            wrapper = wrapper.Replace("[year]", DateTime.Now.Year.ToString());
            wrapper = wrapper.Replace("[company_name]", "First Registrars & Investor Services Limited");
            wrapper = wrapper.Replace("[company_address]", "No. 2, Abebe Village Road, Iganmu, Lagos.");
            wrapper = wrapper.Replace("[company_phone]", "+234-1-27010780");
            wrapper = wrapper.Replace("[company_email]", "info@HSoG.Portalistrarsnigeria.com");

            return wrapper;
        }

        private MailAddress SenderAddress =>
            new("friscomms@HSoG.Portalistrarsnigeria.com", "First Registrars & Investor Services Limited");
        //new("friscomms@HSoG.Portalistrarsnigeria.com", "First Registrars & Investor Services Limited");

        public async Task SendValidationEmailAsync(string email, string name, string code) =>
            await SendEmailAsync(new MailAddress(email, name), "Confirm your Email", "confirm", new { name, code });

        public async Task<SendResponse> SendWelcomeEmailAsync(string email, string name) =>
            await SendEmailAsync(new MailAddress(email, name), "Welcome to First Registrars & Investor Services Limited", "welcome", new { name });

        public async Task<SendResponse> SendResetPasswordEmailAsync(string email, string name, string link) =>
           await SendEmailAsync(new MailAddress(email, name), "Reset Password", "reset", new { name, link });

        public async Task<SendResponse> SendPasswordEmailAsync(string email, string name, string link) =>
           await SendEmailAsync(new MailAddress(email, name), "Password Changed", "newpassword", new { name, link });

        // ================================ >>

        public async Task<SendResponse> SendEmailAsync<T>(MailAddress reci, string subject, string template, T model)
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.office365.com")
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("friscomms@HSoG.Portalistrarsnigeria.com", "Investor1"),
                Port = 587,
            });

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            return await Email
                .From(SenderAddress.Address, SenderAddress.DisplayName)
                .To(reci.Address, reci.DisplayName)
                .ReplyTo(reci.Address, reci.DisplayName)
                .Subject(subject)
                .UsingTemplate(GetTemplate(template), model)
                .SendAsync();
        }
    }
}