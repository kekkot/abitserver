using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.BLL.Interfaces
{
    public interface IMessageService
    {
        Task SendMessageAsync(string toEmail, string subject, string body);
    }
}
