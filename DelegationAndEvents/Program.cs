using System;

namespace DelegationAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();
            //Bind Delegates
            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("The Email has been sent.");
        }
    }
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("The Text Message has been sent.");
        }
    }
}
