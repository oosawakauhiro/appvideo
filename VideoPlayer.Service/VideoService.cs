using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VideoPlayer.Service.Models;

namespace VideoPlayer.Service
{
    public class VideoService
    {
        HttpClient client = new HttpClient();

        public async Task<List<Video>> GetVideoList()
        {
            HttpResponseMessage response = await client.GetAsync("https://demo1321276.mockable.io/videolist");
            if(response.IsSuccessStatusCode)
            {
                var resStr = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Video>>(resStr);
            }
            return null;
        }

        public async Task<byte[]> GetBytesFromUri(string uri)
        {
            byte[] contents = await client.GetByteArrayAsync(uri);
            return contents;
        }
    }
}
