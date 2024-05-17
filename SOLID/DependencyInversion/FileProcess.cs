using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface ISender
    {
        void Send();
    }
    partial class FileProcess
    {
        private readonly ISender sender;

        public FileProcess(ISender sender)
        {
            this.sender = sender;
        }

        public void Notify()
        {
            //MailSender mailSender = new MailSender();
            sender.Send();
        }
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile....");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile...");
        }
    }
}
