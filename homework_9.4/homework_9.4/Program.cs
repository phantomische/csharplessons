using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Enums;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Requests;
using System.IO;
using System.Linq;

namespace homework_9._4
{
    public static class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("hidden");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            var message = update.Message;

            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
            }
            else if (message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                DownLoad(message.Document.FileId, message.Document.FileName);
                await botClient.SendTextMessageAsync(message.Chat, "документ закачан");
                return;
            }
            else if (message.Type == Telegram.Bot.Types.Enums.MessageType.Photo)
            {
                DownLoad(message.Photo[message.Photo.Count() - 1].FileId,
                    message.Photo[message.Photo.Count() - 1].FileUniqueId + ".jpg");
                await botClient.SendTextMessageAsync(message.Chat, "Фотка загружена");
                return;
            }
            else if (message.Type == Telegram.Bot.Types.Enums.MessageType.Audio)
            {
                DownLoad(message.Audio.FileId, message.Audio.FileName);
                await botClient.SendTextMessageAsync(message.Chat, "аудио файл загружен");
                return;
            }
            else if (message.Type == Telegram.Bot.Types.Enums.MessageType.Video)
            {
                DownLoad(message.Video.FileId, message.Video.FileName);
                await botClient.SendTextMessageAsync(message.Chat, "классное видно, скачивание...");
                return;
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        static async void DownLoad(string fileId, string path)
        {
            if (!System.IO.Directory.Exists("disk"))
            {
                System.IO.Directory.CreateDirectory("disk");
            }
            var file = await bot.GetFileAsync(fileId);
            FileStream fs = new FileStream("disk\\" + path, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
            fs.Dispose();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}
