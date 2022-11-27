using System;
using System.Web;
using static System.Console;

namespace LinkvertiseBypasser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Clear();
            Title = "Linkvertise Bypass | Bypass.vip API | By Vestige";

            Write("Enter URL: ");
            string str = Console.ReadLine();

            try
            {
                var httpRequest = new Leaf.xNet.HttpRequest();
                var Data = "url=" + HttpUtility.UrlEncode(str);

                httpRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                httpRequest.AddHeader("Content-Length", Data.Length.ToString());

                var Post = httpRequest.Post("https://api.bypass.vip/", Data, "application/x-www-form-urlencoded").ToString();

                Console.Clear();
                var Content = Post.Split('"')[9];
                WriteLine("Content:\n" + Content);
            }
            catch
            {
                WriteLine("Didn't Work :(");
            }

            ReadKey();
        }
    }
}