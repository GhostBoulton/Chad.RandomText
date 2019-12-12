using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chad.RandomText.Lib;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Chad.RandomText.WinForms
{
    public partial class BackupDatamuse : Form
    {
        TaskScheduler uiScheduler;

        public BackupDatamuse()
        {
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            InitializeComponent();
            InitializeMe();
        }

        private void InitializeMe()
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

        private void getResultsButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.WriteArtistLyrics(ArtistId, SetMessage);
        }

        private void SetMessage(string message)
        {
            Task.Factory.StartNew(() =>
            {
                consoleText.Text += $"\r\n { message }";

                consoleText.SelectionStart = consoleText.Text.Length;
                consoleText.ScrollToCaret();

            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private void makeRequestButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.MakeApiRequest(Url, SetMessage);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LyricCatcher lyricCatcher = new LyricCatcher(AccessToken, OutputFile);
            lyricCatcher.Search(SearchFor, SetMessage);
        }
    }
}
