using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Telegram.Bot;

namespace homework_10._5
{
    public class TelegramMessageClient
    {
        private MainWindow w;

        private TelegramBotClient bot;
        public ObservableCollection<MessageLog> BotMessageLog { get; set; }

        private void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine("---");
            Debug.WriteLine("+++---");

            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";

            Debug.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");

            if (e.Message.Text == null) return;

            var messageText = e.Message.Text;

            w.Dispatcher.Invoke(() =>
            {
                BotMessageLog.Add(
                new MessageLog(
                    DateTime.Now.ToLongTimeString(), messageText, e.Message.Chat.FirstName, e.Message.Chat.Id));
            });
        }

        public TelegramMessageClient(MainWindow W, string PathToken = "hidden")
        {
            this.BotMessageLog = new ObservableCollection<MessageLog>();
            this.w = W;

            bot = new TelegramBotClient(PathToken);

            bot.OnMessage += MessageListener;

            bot.StartReceiving();
        }

        public void SendMessage(string Text, string Id)
        {
            long id = Convert.ToInt64(Id);
            bot.SendTextMessageAsync(id, Text);
        }
    }
}
