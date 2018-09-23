using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memcached.ClientLibrary;
namespace memcache
{
    //在程序中使用memcachae 
    class Program
    {
        static void Main(string[] args)
        {
            //1.架构服务器集群
            string[] ips = new string[]
            {
                "192.168.43.67:11211",
                 "192.168.43.68:11211"
            };
            //通信池的初始化
            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(ips);
            pool.Initialize();

            //创建客户端对象，完成通信
            MemcachedClient client = new MemcachedClient();
            client.EnableCompression = false;
            client.Set("hans","abcdef",600);

            Console.WriteLine("OK");
            Console.ReadKey();

        }
    }
}
