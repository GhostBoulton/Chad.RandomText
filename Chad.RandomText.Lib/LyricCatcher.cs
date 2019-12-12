using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Chad.RandomText.Lib
{
    public class LyricCatcher
    {
        public LyricCatcher(string accessToken, string outputFile)
        {
            _accessToken = accessToken;
            _outputFile = outputFile;
        }

        private const string ApiUrl = "https://api.genius.com";
        private readonly string _accessToken;
        private const string SaveFolder = "C:/logs";
        private readonly string _outputFile;

        public void WriteArtistLyrics(string artistId,  Action<string> setMessage)
        {
            Task.Factory.StartNew(
                () =>
                {
                    var songLyrics = new List<string>();

                    int page = 1;
                    int perPage = 25;

                    while (true)
                    {
                        var url = $"{ApiUrl}/artists/{artistId}/songs?per_page={perPage}&page={page}";
                        setMessage($"Requesting data from {url}");
                        var results = WebGet(url, _accessToken);

                        setMessage($"Now grabbing song urls..");

                        var songUrls = GetLyricsPageUrls(results);

                        // setMessage(BeautifyJson(results));

                        if (!songUrls.Any())
                        {
                            //we are done. get out.
                            setMessage($"no more songs found.");
                            break;
                        }

                        foreach (var songUrl in songUrls)
                        {
                            setMessage($"scraping {songUrl}");
                            songLyrics.Add(ScrapePageForLyrics(songUrl));
                        }

                        setMessage($"scraped {songUrls.Count} urls for lyrics.");

                        page++;
                        // break;
                    }

                    setMessage($"processed {page} pages of {perPage} songs per page.");

                    var fullOutput = SaveTextToFile(_outputFile, string.Join("\r\n", songLyrics));
                    setMessage($"Saved lyrics to {fullOutput}");

                });

        }

        public void MakeApiRequest(string url, Action<string> setMessage)
        {
            Task.Factory.StartNew(
                () =>
                {
                    setMessage($"Making request to: {url}");
                    var responseJson = WebGet(url, _accessToken);

                    setMessage($"{BeautifyJson(responseJson)}");
                });
        }

        public void Search(string searchFor, Action<string> setMessage)
        {
            Task.Factory.StartNew(
                () =>
                {
                    var url = $"{ApiUrl}/search?q={searchFor}";

                    setMessage($"Making request to: {url}");
                    var responseJson = WebGet(url, _accessToken);

                    setMessage($"{BeautifyJson(responseJson)}");
                });
        }

        private string WebGet(string Url, string AccessToken)
        {
            var myWebRequest = System.Net.WebRequest.Create(Url);
            var myHttpWebRequest = (System.Net.HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);
            var myWebResponse = (System.Net.HttpWebResponse)myHttpWebRequest.GetResponse();

            var json = string.Empty;

            var responseStream = myWebResponse.GetResponseStream();
            if (responseStream != null)
            {
                var myStreamReader = new StreamReader(responseStream, Encoding.Default);
                json = myStreamReader.ReadToEnd();

                responseStream.Close();
            }

            myWebResponse.Close();
            return json;
        }

        private string BeautifyJson(string json)
        {
            var parsedJson = JToken.Parse(json);
            return parsedJson.ToString(Formatting.Indented);
        }

        private List<string> GetLyricsPageUrls(string artistSongsJson)
        {
            var songUrls = new List<string>();

            try
            {
                dynamic data = JObject.Parse(artistSongsJson);

                foreach (var song in data.response.songs)
                {
                    songUrls.Add((string)song.url);
                }
            }
            catch (Exception doh)
            {
                return new List<string>();
            }

            return songUrls;
        }

        private string ScrapePageForLyrics(string pageUrl)
        {
            var web = new HtmlWeb();
            var doc = web.Load(pageUrl);
            var lyricDiv = doc.DocumentNode.SelectSingleNode("//div[@class='lyrics']");

            return lyricDiv.InnerText.Trim();
        }

        private string SaveTextToFile(string fileName, string contents)
        {
            var path = $"{SaveFolder}/{fileName}";

            if (!File.Exists(path))
            {
                using (var sw = File.CreateText(path))
                {
                    sw.Write(contents.Replace("\n", "\r\n"));
                }
            }
            else
            {
                using (var sw = File.AppendText(path))
                {
                    sw.Write(contents.Replace("\n", "\r\n"));
                }
            }

            return path;
        }
    }
}
