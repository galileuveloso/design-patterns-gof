using DesignPatternsGOF.Structural.Proxy.Interfaces;
using DesignPatternsGOF.Structural.Proxy.Models;

namespace DesignPatternsGOF.Structural.Proxy
{
    public class Vpn : IProxy
    {
        public void ConnectVpn(User user)
        {
            Console.WriteLine("[+] - Connecting...");
            Thread.Sleep(2000);
            Console.WriteLine(user.Name + " connected!");
        }
    }
}
