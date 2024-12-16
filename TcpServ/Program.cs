using System.IO;
using GameServer.Data;
using Microsoft.EntityFrameworkCore;
namespace GameServer;

class Program
{
    private static Server _server; 
    static void Main(string[] args)
    {
        
        

//#if RELEASE
        string path = Path.Combine(Directory.GetCurrentDirectory(),"../.env");
//#endif

        DotEnv.Load(path);

        string connectionString = Environment.GetEnvironmentVariable("DB__CONNECTION__STRING");
        
        using var db = new GameContext(connectionString);

        _server = new Server();

        _server.Start();
    }
}
