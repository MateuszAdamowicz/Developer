using System;
using System.IO;
using Developer.Models;
using Developer.Models.ApplicationModels;
using Developer.Models.ViewModels;
using RazorEngine.Templating;

namespace Developer.Services.Home
{
    public class EmailService : IEmailService
    {
        private readonly ITemplateService _templateSercvie;

        public EmailService(ITemplateService templateSercvie)
        {
            _templateSercvie = templateSercvie;
        }

        public Result SendQuestion(ContactEmail contactEmail)
        {
            var body = _templateSercvie.Parse(GetTemplate(), contactEmail, null, null);
            return new Result(true, null ,"");
        }

        public string GetTemplate()
        {
            string template = File.ReadAllText(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "Services/Home/EmailService/Templates/QuestionEmailTemplate.cshtml"));

            return template;
        }
    }
}