using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chad.RandomText.Lib
{
    public class RandomTextGenerator
    {
        public string SourcePath { get; set; }
        public string OutputPath { get; set; }

        public string ReplaceCarriageNewLines { get; set; }
        public string OutputMessage { get; set; }

        readonly List<WordBlob<string>> _stringBlobs = new List<WordBlob<string>>();
        readonly List<WordBlob<char>> _charBlobs = new List<WordBlob<char>>();

        public void Parse(int textLength)
        {
            string text = System.IO.File.ReadAllText(SourcePath);

            if (text.Length < textLength)
            {
                textLength = text.Length;
            }

            text = textLength == 0 ? text : text.Substring(0, textLength);
            text = text.Replace("\r\n\r\n", "<!CaNLCaNL!> ");
            text = text.Replace("\r\n", "<!ca!>");
            // text = text.Replace("\n", "<!-- newline --!>");

            var words = text.Split();

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];

                if (string.IsNullOrEmpty(word)) continue;

                var blob = _stringBlobs.FirstOrDefault(b => b.Blob == word);

                var newBlob = blob == null;
                if (newBlob)
                {
                    blob = new WordBlob<string>(word);
                }

                if (i < words.Length - 2) // 2 because we will try twice. hack
                {
                    var nWord = words[i + 1]; // NEXT word.

                    nWord = string.IsNullOrEmpty(nWord) ? words[i + 2] : nWord;
                    blob.AddNextBlob(new WordBlob<string>(nWord));
                }
                if (newBlob) _stringBlobs.Add(blob);
            }
            OutputMessage = $"Success from {SourcePath} to {OutputPath}, words analyzed: {_stringBlobs.Count}";
        }

        public void ParseChar(int textLength)
        {
            string text = System.IO.File.ReadAllText(SourcePath);

            if (text.Length < textLength)
            {
                textLength = text.Length;
            }

            //text = text.Substring(0, textLength);

            var chars = text.ToCharArray();
            Console.WriteLine(chars.Length);

            for (var i = 0; i < chars.Length; i++)
            {
                var chr = chars[i];

                // if (char.chr == null) continue;

                var blob = _charBlobs.FirstOrDefault(b => b.Blob == chr);

                var newBlob = blob == null;
                if (newBlob)
                {
                    blob = new WordBlob<char>(chr);
                }

                if (i < chars.Length - 2) // 2 because we will try twice. hack
                {
                    var nWord = chars[i + 1]; // NEXT word.

                    // nWord = string.IsNullOrEmpty(nWord) ? chars[i + 2] : nWord;
                    blob.AddNextBlob(new WordBlob<char>(nWord));
                }
                if (newBlob) _charBlobs.Add(blob);
            }
            OutputMessage = $"Success from {SourcePath} to {OutputPath}, chars analyzed: {_charBlobs.Count}";
        }
        public string View()
        {
            var sb = new StringBuilder();
            foreach (var sBlob in _stringBlobs.OrderBy(b => b.Blob))
            {
                sb.AppendLine($"'{sBlob.Blob}' <-- {sBlob._nextBlobs?.Count}");
            }
            return sb.ToString();
        }

        public string ViewChar()
        {
            var sb = new StringBuilder();
            foreach (var sBlob in _charBlobs) //.OrderBy(b => b.Blob))
            {
                sb.AppendLine($"'{sBlob.Blob.ToString()}' <-- {sBlob._nextBlobs?.Count}");
            }
            return sb.ToString();
        }

        public string Print(int maxWords)
        {
            var outBlobs = new List<string>();
            var rando = new Random(DateTime.Now.Minute);

            var firstBlob = _stringBlobs[rando.Next(_stringBlobs.Count - 1)];

            //var aFirstWord = _stringBlobs.Where(sb => sb.)

            var blob = firstBlob;
            var limit = 0;

            while (limit < maxWords)
            {
                outBlobs.Add(blob.Blob);

                WordBlob<string> nextBlob;

                if (blob._nextBlobs != null && blob._nextBlobs.Any())
                {
                    nextBlob = blob._nextBlobs[rando.Next(blob._nextBlobs.Count)];
                }
                else
                {
                    // Console.Write($"Next blobs not found for: {blob}");
                    nextBlob = _stringBlobs[rando.Next(_stringBlobs.Count)];
                }

                blob = nextBlob;
                limit++;
            }

            var resultText = string.Join(" ", outBlobs);
            resultText = resultText.Replace("<!CaNLCaNL!> ","\r\n\r\n");
            resultText = resultText.Replace("<!ca!>", ReplaceCarriageNewLines);

            return resultText;

        }

        public string PrintChar(int maxWords)
        {
            var outBlobs = new List<char>();
            var rando = new Random(DateTime.Now.Minute);

            var firstBlob = _charBlobs[rando.Next(_charBlobs.Count - 1)];

            var blob = firstBlob;
            var limit = 0;

            while (limit < maxWords)
            {
                outBlobs.Add(blob.Blob);

                WordBlob<char> nextBlob;

                if (blob._nextBlobs != null && blob._nextBlobs.Any())
                {
                    var sorted = blob._nextBlobs.OrderByDescending(b => b.Occurrences);
                    var howMany = (int)Math.Round(blob._nextBlobs.Count / 4D, MidpointRounding.AwayFromZero);
                    
                    nextBlob = sorted.Skip(rando.Next(howMany)).First();
                    // nextBlob = blob._nextBlobs[rando.Next(blob._nextBlobs.Count)];
                }
                else
                {
                    // Console.Write($"Next blobs not found for: {blob}");
                    nextBlob = _charBlobs[rando.Next(_charBlobs.Count)];
                }

                blob = nextBlob;
                limit++;
            }

            return string.Join("", outBlobs);
        }
    }

    public class WordBlob<T>
    {
        public WordBlob(T blob)
        {
            Blob = blob;
        }
        public T Blob { get; }

        public int Occurrences = 1;

        public List<WordBlob<T>> _nextBlobs;
        public void AddNextBlob(WordBlob<T> wordBlob)
        {
            // if (wordBlob == null || string.IsNullOrEmpty(wordBlob.Blob)) return;
            if (wordBlob == null) return;

            if (_nextBlobs == null) _nextBlobs = new List<WordBlob<T>>();

            var existingBlob = _nextBlobs.FirstOrDefault(b => b.Blob.Equals(wordBlob.Blob));

            if (existingBlob == null)
            {
                _nextBlobs.Add(wordBlob);
            }
            else
            {
                existingBlob.Occurrences++;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (_nextBlobs == null) return sb.ToString();

            foreach (var bBlob in _nextBlobs)
            {
                // var star = string.IsNullOrWhiteSpace(bBlob.Blob) ? "*" : string.Empty;
                sb.AppendLine($"{ this.Blob } ---> { bBlob.Blob } ({ bBlob.Occurrences })");
            }

            return sb.ToString();
        }
    }
}
