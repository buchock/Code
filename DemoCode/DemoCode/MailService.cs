using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, EventArgs args)
        {
            Console.WriteLine("Mail Service: Sending an email.....");
        }
    }
}
