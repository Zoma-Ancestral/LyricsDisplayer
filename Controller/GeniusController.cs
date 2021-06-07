using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace LyricsDisplayer.Controller
{
    class GeniusController
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseUri = "https://api.genius.com";

        public static async Task<string?> GetLyrics(string searchText)
        {
            string? id = null;
            string? lyrics = null;
            try
            {
                id = await GetSongId(searchText);
                if (id != null)
                {
                    lyrics = await GetSongLyrics(id);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }

            return lyrics;
        }

        private static async Task<string?> GetSongLyrics(string songId)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Settings.Default.ClientToken);

            //var response = await client.GetStringAsync($"{baseUri}/search?q={HttpUtility.HtmlEncode(searchText)}");

            return "";
        }

        private static async Task<string?> GetSongId(string searchText)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Settings.Default.ClientToken);

            var response = await client.GetStringAsync($"{baseUri}/search?q={HttpUtility.HtmlEncode(searchText)}");

            RequestResponse json = JsonSerializer.Deserialize<RequestResponse>(response);

            if (json.Meta.Status < 400)
            {
                if (json.Response.Hits.Length > 0)
                {
                    return json.Response.Hits[0].Result.Id.ToString();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new HttpRequestException($"{json.Meta.Status} - {json.Meta.Message}");
            }
        }
    }
}
