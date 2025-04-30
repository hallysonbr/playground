namespace Praticas.Proxies
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Profile { get; set; }

        public User(string name, string password, string profile)
        {
            Name = name;
            Password = password;
            Profile = profile;
        }
    }
}
