namespace Praticas.TemplateMethods
{
    public class Mp4Video : VideoPlayer
    {
        public override void DecodeVideo()
        {
            Console.WriteLine("Vídeo sendo processado pelo decoder MP4.");
        }
    }
}
