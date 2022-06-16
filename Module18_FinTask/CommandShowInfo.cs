using System;
using YoutubeExplode;

namespace Module18_FinTask
{
    /// <summary>
    /// Class describes command which shows us inrmation about video
    /// </summary>
    class CommandShowInfo : Command
    {
        Reciever reciever;

        public CommandShowInfo(Reciever _reciever)
        {
            reciever = _reciever;
        }

        /// <summary>
        /// Method shows us information
        /// </summary>
        public override async void Run()
        {
            reciever.Operation();

            YoutubeClient f = new YoutubeClient();
            var video = await f.Videos.GetAsync("https://youtu.be/yCb5VnI6Bdo");
            Console.WriteLine($"Имя видео - {video.Title} \nАвтор видео - {video.Author.ChannelTitle} \nДлительность видео - {video.Duration}");
        }
    }
}
