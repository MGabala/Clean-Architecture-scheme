using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureApplication.Models;

namespace CleanArchitectureApplication.Repositories.Infrastructure
{
    public interface IMailService
    {
        Task<bool> SendMail(Email mail);
    }
}
