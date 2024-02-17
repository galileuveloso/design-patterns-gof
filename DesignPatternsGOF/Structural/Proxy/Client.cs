using DesignPatternsGOF.Structural.Proxy.Models;

namespace DesignPatternsGOF.Structural.Proxy
{
    public class Client
    {
        public void Execute()
        {
            Console.WriteLine("Username: ");
            var name = Console.ReadLine();

            Console.WriteLine("Passworkd: ");
            var password = Console.ReadLine();

            var user = new User(name, password);

            var proxy = new VpnProxy();
            proxy.ConnectVpn(user);
        }
    }
}
