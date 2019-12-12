using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chad.RandomText.Lib;

namespace Chad.RandomText.WinForms
{
    public partial class LyricsCatcher : UserControl
    {
        TaskScheduler uiScheduler;
        private Action<string> SetMessage;
        public LyricsCatcher(Action<string> setMessage)
        {
            InitializeComponent();
            SetupDefaultValues();
            SetMessage = setMessage;
        }

        private void SetupDefaultValues()
        {
            accessTokenTextBox.Text = "n-yvKuKpQ5_8-gzgm2TJ3U0EVXQmKgo02xPAkhPDMH2kSgxbKpTcU_ReZcv7Gw8Q";
            requestUrlTextBox.Text = "https://api.genius.com/artists/18892/songs?per_page=50";
            outputFileTextbox.Text = $"artist_lyrics_{DateTime.Now.ToString("MM-dd-yy")}.txt";
            artistIdTextBox.Text = "18892";
            searchTextBox.Text = "radiohead";
        }


        private string Url => requestUrlTextBox.Text;
        private string OutputFile => outputFileTextbox.Text;
        private string AccessToken => accessTokenTextBox.Text;
        private string ArtistId => artistIdTextBox.Text;
        private string SearchFor => searchTextBox.Text;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.Search(SearchFor, SetMessage);
        }

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.MakeApiRequest(Url, SetMessage);
        }

        private void GetResultsButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.WriteArtistLyrics(ArtistId, SetMessage);
        }
    }
}
