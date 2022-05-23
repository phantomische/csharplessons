using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Telegram.Bot;

namespace homework_9._4
{
    public class Program
    {
        static TelegramBotClient bot;
        static void Main(string[] args)
        {
            string token = "5320706394:AAGGNAuArVDSJV3ZEZQ_cv-y8wtHSbS7UdI";

            bot = new TelegramBotClient(token);
            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";

            Console.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");
 

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                Console.WriteLine(e.Message.Document.FileId);
                Console.WriteLine(e.Message.Document.FileName);
                Console.WriteLine(e.Message.Document.FileSize);

                DownLoad(e.Message.Document.FileId, e.Message.Document.FileName);
            }

            if (e.Message.Text == null) return;

            var messageText = e.Message.Text;

            
            bot.SendTextMessageAsync(e.Message.Chat.Id,
                $"{messageText}"
                );
        }

        static async void DownLoad(string fileId, string path)
        {
            var file = await bot.GetFileAsync(fileId);
            FileStream fs = new FileStream("_" + path, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
             
            fs.Dispose();
        }
    }
}
