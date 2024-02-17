namespace DesignPatternsGOF.Structural.Proxy.Models
{
    public class User(string name, string password)
    {
        public string Name { get; private set; } = name;
        public string Password { get; private set; } = password;
    }
}
