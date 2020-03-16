using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Util.Email.Interface
{
    public interface IMailer
    {
        void sendEmail(string to, string subject, string body);
    }
}
