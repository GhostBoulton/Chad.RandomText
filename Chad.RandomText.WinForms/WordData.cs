using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Chad.RandomText.WinForms
{
    public partial class WordData : Form
    {
        private Random random;
        public WordData()
        {
            InitializeComponent();
            InitializeMe();
            random = new Random();
        }

        private void InitializeMe()
        {
            sentenceText.Text = "Can you wait for the sidewalk, can it wait for you?";
        }
        private string Sentence => sentenceText.Text;

        private void GoButton_Click(object sender, EventArgs e)
        {
            var words = Sentence.Split();

            var gotFirst = false;
            var rhymesWith = "Bad";

            var outPutSentence = new List<string>();

            foreach (var word in words)
            {
                var nextWord = GetRhymesWithRelatedTo(rhymesWith, word);
                outPutSentence.Add(nextWord);
            }

            consoleText.Text = string.Join(" ", outPutSentence);
        }

        private string GetRhymesWithRelatedTo(string rhymesWith, string relatedTo)
        {
            //nry approx rhyme  rhy perfect rhyme
            var url = $"https://api.datamuse.com/words?ml={relatedTo}&rel_rhy={rhymesWith}";

            var wordsJson = WebGet(url);

            var randomResultWord = GrabRandomWord(wordsJson);

            return string.IsNullOrEmpty(randomResultWord) ? relatedTo : randomResultWord;
        }

        private string GetSpelledSimilarlyTo(string similarlyTo)
        {
            var url = $"https://api.datamuse.com/words?sp={similarlyTo}";

            //words that are spelled similarly to 
            var wordsJson = WebGet(url);

            var randomResultWord = GrabRandomWord(wordsJson);

            return string.IsNullOrEmpty(randomResultWord) ? similarlyTo : randomResultWord;
        }

        private string GetMeansTheSame(string sameAs)
        {
            // /words?ml=ringing+in+the+ears
            var url = $"https://api.datamuse.com/words?ml={sameAs}";

            //words with a meaning similar to 
            var wordsJson = WebGet(url);

            var randomResultWord = GrabRandomWord(wordsJson);

            return string.IsNullOrEmpty(randomResultWord) ? sameAs : randomResultWord;
        }

        private string GrabRandomWord(string jsonResults)
        {
            dynamic wordsArray = JArray.Parse(jsonResults);

            var allTheWords = new List<string>();
            foreach (var word in wordsArray)
            {
                dynamic data = JObject.Parse(word.ToString());
                allTheWords.Add(data.word.Value);
            }

            int maxValue = allTheWords.Count;

            if (maxValue < 1)
            {
                return string.Empty;
            }
            else
            {
                var rand = random.Next(maxValue - 1);
                var returnWord = allTheWords[rand];

                return returnWord;
            }
        }

        private string WebGet(string url)
        {
            var myWebRequest = System.Net.WebRequest.Create(url);
            var myHttpWebRequest = (System.Net.HttpWebRequest)myWebRequest;
            // myHttpWebRequest.PreAuthenticate = true;
            // myHttpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);
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
    }
}
