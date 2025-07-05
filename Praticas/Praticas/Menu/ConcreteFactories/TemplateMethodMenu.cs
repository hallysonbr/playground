using Praticas.Menu.Abstractions;
using Praticas.TemplateMethods;

namespace Praticas.Menu.ConcreteFactories
{
    public class TemplateMethodMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Executar Template Method");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine("-----Video Player - Video MP4 ---------");

                VideoPlayer videoPlayer = new Mp4Video();

                videoPlayer.PlayVideo();

                Console.WriteLine("\n");

                Console.WriteLine("-----Video Player - Video MKV ---------");

                videoPlayer = new MkvVideo();

                videoPlayer.PlayVideo();

                Console.ReadKey();
            });
        }
    }
}
