namespace Praticas.Proxies
{
    /// <summary>
    /// The Proxy class
    /// </summary>
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _sharedFolder;
        private readonly User _user;

        public SharedFolderProxy(User user)
        {
            _user = user;
        }

        public void ReadAndWrite()
        {
            if (_user.Profile.ToLower() == "admin")
            {
                Console.WriteLine("Proxy invoking the shared folder. Read and Write operation.");

                _sharedFolder = new SharedFolder();
                _sharedFolder.ReadAndWrite();
            }
            else
                Console.WriteLine("You don't have permission to access this shared folder.");
        }
    }
}
