using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel
{

    public class Menu
    {
        YoutubeAPI_V3 youtubeAPI = new YoutubeAPI_V3();
        public Menu()
        {

        }

        public void Loading()
        {
            Console.WriteLine("Loading");
            for (int i = 0; i < 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(5);
            }
            Console.WriteLine("\n============================== API YOUTUBE V3 =================================");
        }
        public  async Task ShowMenu()
        {
            Console.WriteLine("1. Get All Videos");
            Console.WriteLine("2. Get Videos By Id");
            Console.WriteLine("3. Get Videos By Id");
            Console.WriteLine("4. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                   await  GetVideos();
                    break;
                case "2":
                    Console.WriteLine("===> Get Videos By Id");
                    break;
                case "3":
                    Console.WriteLine("===> Save To File");
                    youtubeAPI.SaveFile();
                    break;
                case "4":
                    Console.WriteLine("===> Exit");
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }

        private async Task GetVideos()
        {
            while (true)
            {
                Console.WriteLine("==> Get Videos With Pagination");
                Console.WriteLine("Enter So luong can lay: ");
                int maxResult = Convert.ToInt32(Console.ReadLine());
                Console.Write("PageToken (Null): ");
                string pageToken = Console.ReadLine();
                var data = await youtubeAPI.GettAllVideos(maxResult, pageToken);
                await youtubeAPI.SaveChanges(data);
                youtubeAPI.ShowData(data);

                Console.WriteLine("Press any key to continue, or press 0 to exit.");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }

        }

    }
}
