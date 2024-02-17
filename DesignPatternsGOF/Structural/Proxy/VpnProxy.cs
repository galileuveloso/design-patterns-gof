using DesignPatternsGOF.Structural.Proxy.Interfaces;
using DesignPatternsGOF.Structural.Proxy.Models;
using DesignPatternsGOF.Structural.Proxy.Sql;

namespace DesignPatternsGOF.Structural.Proxy
{
    public class VpnProxy : IProxy
    {
        public void ConnectVpn(User user)
        {
            DataBaseConnection connection = new();
            connection.AddLog(user);

            Console.WriteLine(new String('-', 40));

            Vpn vpn = new();
            vpn.ConnectVpn(user);
        }
    }
}
