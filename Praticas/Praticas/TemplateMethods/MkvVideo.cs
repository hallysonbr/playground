namespace Praticas.TemplateMethods
{
    public class MkvVideo : VideoPlayer
    {
        public override void DecodeVideo()
        {
            Console.WriteLine("Vídeo sendo processado pelo decoder MKV.");
        }
    }
}
