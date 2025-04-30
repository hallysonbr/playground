namespace Praticas.Proxies
{
    /// <summary>
    /// The RealSubject class
    /// </summary>
    public class SharedFolder : ISharedFolder
    {
        public void ReadAndWrite()
        {
            Console.WriteLine("Read and Write operation in this shared folder.");
        }
    }
}
