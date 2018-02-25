using System;
using System.Threading;

namespace DelegationAndEvents
{
    class VideoEncoder
    {
        public delegate void VideoEncodedHandler(object source, EventArgs args);
        public event VideoEncodedHandler videoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoded.");
            Thread.Sleep(5000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded != null)
                videoEncoded(this, EventArgs.Empty);
        }
    }
}
