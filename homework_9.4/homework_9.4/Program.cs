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

namespace homework_9._4
{
    public static class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("5320706394:AAGGNAuArVDSJV3ZEZQ_cv-y8wtHSbS7UdI");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
            }
        }

        public static async Task<Message> SendDocumentAsync(
        this ITelegramBotClient botClient,
        ChatId chatId,
        InputOnlineFile document,
        InputMedia? thumb = default,
        string? caption = default,
        ParseMode? parseMode = default,
        IEnumerable<MessageEntity>? captionEntities = default,
        bool? disableContentTypeDetection = default,
        bool? disableNotification = default,
        bool? protectContent = default,
        int? replyToMessageId = default,
        bool? allowSendingWithoutReply = default,
        IReplyMarkup? replyMarkup = default,
        CancellationToken cancellationToken = default
    ) =>
        await botClient.ThrowIfNull(nameof(botClient))
            .MakeRequestAsync(
                request: new SendDocumentRequest(chatId, document)
                {
                    Thumb = thumb,
                    Caption = caption,
                    ParseMode = parseMode,
                    CaptionEntities = captionEntities,
                    DisableContentTypeDetection = disableContentTypeDetection,
                    DisableNotification = disableNotification,
                    ReplyToMessageId = replyToMessageId,
                    AllowSendingWithoutReply = allowSendingWithoutReply,
                    ReplyMarkup = replyMarkup
                },
                cancellationToken
            )
            .ConfigureAwait(false);


        public static async Task<File> GetFileAsync(
        this ITelegramBotClient botClient,
        string fileId,
        CancellationToken cancellationToken = default
    ) =>
        await botClient.ThrowIfNull(nameof(botClient))
            .MakeRequestAsync(
                request: new GetFileRequest(fileId),
                cancellationToken: cancellationToken
            )
            .ConfigureAwait(false);

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
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
