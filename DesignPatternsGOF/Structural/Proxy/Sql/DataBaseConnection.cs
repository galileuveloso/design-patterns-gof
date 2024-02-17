using DesignPatternsGOF.Structural.Proxy.Models;

namespace DesignPatternsGOF.Structural.Proxy.Sql
{
    public class DataBaseConnection
    {
        public void AddLog
        (
            User user
        )
        {
            string sql = @$"INSERT INTO LogVpn(Nome, Password, Date) VALUES ('{user.Name}', '{user.Password}', '{DateTime.Now:yyy-MM-dd HH:mm:ss}')";

            Console.WriteLine("[!] - Adding log...");
            Console.WriteLine(sql);
        }
    }
}
