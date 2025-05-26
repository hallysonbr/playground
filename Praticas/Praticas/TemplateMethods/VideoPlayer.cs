namespace Praticas.TemplateMethods
{
    public abstract class VideoPlayer
    {
        public void PlayVideo()
        {
            LoadVideo();
            DecodeVideo();
            StartExecution();
        }

        public void LoadVideo()
        {
            Console.WriteLine("Vídeo sendo carregado...");
        }

        public abstract void DecodeVideo();

        public void StartExecution()
        {
            Console.WriteLine("O vídeo foi iniciado...");
        }
    }
}
