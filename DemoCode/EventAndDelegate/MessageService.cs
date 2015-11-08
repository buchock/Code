using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs args)
        {
            Console.WriteLine("Message Service: Sending an text message.....");
        }
    }
}
