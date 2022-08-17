using CrawlYoutubeChannel.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel
{
    public class YoutubeAPI_V3
    {
        private static HttpClient _httpClient;
        private static readonly string _baseUri = "https://www.googleapis.com/youtube/v3/";
        private static string _apiKey = "AIzaSyDdazKbAUf_xdH4z5yHjQvQuHgM2XaRFDk";
        private static string _channelId = "UCI6ofrQ7avhyDoN4KXmeJVg";

        private static List<VideosResult> videosResults = new List<VideosResult>();
        private static VideosResult videosResult;

        public YoutubeAPI_V3()
        {

        }

        // get All Videos with pageToken
        public async Task<YoutubeSearch> GettAllVideos(int maxResult, string? pageToken)
        {
            using (_httpClient = new HttpClient())
            {
                try
                {
                    string url = "";
                    if (pageToken == null)
                    {
                        url = $"{_baseUri}search?key={_apiKey}&channelId={_channelId}&part=snippet&order=date&maxResults={maxResult}";
                    }
                    else
                    {
                        url = $"{_baseUri}search?key={_apiKey}&channelId={_channelId}&part=snippet&order=date&maxResults={maxResult}&pageToken={pageToken}";
                    }

                    var response = await _httpClient.GetAsync(url);
                    String result = await response.Content.ReadAsStringAsync();
                    // convert to json object
                    var data = JsonConvert.DeserializeObject<YoutubeSearch>(result);
                    if (data == null)
                    {
                        Console.WriteLine("Api error");
                        return null;
                    }
                    return data;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }


        // get by VideosId
        public async Task<YoutubeVideos> GetVideos(string videosId)
        {
            using (_httpClient = new HttpClient())
            {
                var url = $"{_baseUri}videos?part=snippet,statistics,contentDetails&id={videosId}&key={_apiKey}";
                var response = await _httpClient.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                try
                {
                    var data = JsonConvert.DeserializeObject<YoutubeVideos>(result);
                    return data;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task SaveChanges(YoutubeSearch data)
        {
            var data01 = data.Items.ToList();
            YoutubeVideos youtubeVideos = new YoutubeVideos();
            foreach (Items item in data01)
            {
                youtubeVideos = null;
                youtubeVideos = await GetVideos(item.Id.VideoId);

                videosResult = new VideosResult()
                {
                    VideoId = item.Id.VideoId,
                    Title = item.Snippet.Title,
                    Description = item.Snippet.Description,
                    PublishedAt = item.Snippet.PublishedAt,
                    Thumbnail = item.Snippet.Thumbnails.Medium.Url,
                    ChannelTitle = item.Snippet.ChannelTitle,
                    ChannelId = item.Snippet.ChannelId,
                    Tags = youtubeVideos.Items[0].Snippet.Tags,
                    View = youtubeVideos.Items[0].Statistics.ViewCount,
                    Duration = youtubeVideos.Items[0].ContentDetails.Duration,
                    Relution = youtubeVideos.Items[0].ContentDetails.Definition
                };
                videosResults.AddRange(new List<VideosResult> { videosResult });

            }
        }



        public void SaveFile()
        {
            try
            {
                // write to file json
                var json = JsonConvert.SerializeObject(videosResults, Formatting.Indented);
                string currentDirectory = Environment.CurrentDirectory;
                string path = currentDirectory + @"\Videos.json";
                File.WriteAllText(path, json);
                Console.WriteLine("Save file success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
        public async void ShowData(YoutubeSearch youtubeSearch)
        {
            Console.WriteLine(" ============================== List Videos ================================= ");
            Console.WriteLine($"Total Results: {youtubeSearch.PageInfo.TotalResults} \n NextPageToken: {youtubeSearch.NextPageToken} \n PrevPageToken: {youtubeSearch.PrevPageToken}");

            if (videosResults == null)
            {
                Console.WriteLine("Data null");
                return;
            }

            int i = 1;
            foreach (var item in videosResults)
            {
                Console.WriteLine($"{i} - {item.VideoId} - {item.Title}");
                i++;
            }
        }

    }
}
