using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending an text message....." + args.Video.Title);
        }
    }
}
