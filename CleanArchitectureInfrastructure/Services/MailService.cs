using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureApplication.Models;
using CleanArchitectureApplication.Repositories.Infrastructure;

namespace CleanArchitectureInfrastructure.Services
{
    public class MailService : IMailService
    {
        public Task<bool> SendMail(Email mail)
        {
            throw new NotImplementedException();
        }
    }
}
