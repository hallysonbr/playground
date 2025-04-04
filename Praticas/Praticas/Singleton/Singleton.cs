namespace Praticas.Singleton
{
    public class Singleton
    {
        private static Singleton? instance;
        private static object lockObj = new object();
        private int counter = 0;

        private Singleton() 
        { 
            counter++;
            Console.WriteLine($"Número de instancias: {counter}");
        }

        /// <summary>
        /// Esse formato de implementação do Singleton não funciona bem em ambientes multithreaded
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                return instance ??= new Singleton();
            }
        }

        /// <summary>
        /// Esse formato de implementação do Singleton funciona bem em ambientes multithreaded
        /// </summary>
        public static Singleton InstanceTheadSafe
        {
            get
            {
                if (instance is null)
                {
                    lock (lockObj)
                    {
                        instance ??= new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
