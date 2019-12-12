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
    public partial class mainForm : Form
    {
        TaskScheduler uiScheduler;

        public mainForm()
        {
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            InitializeComponent();
            InitializeMe();
        }

        private void InitializeMe()
        {

            var fileTextGenerator = new FileTextGenerator(SetMessage);
            AddControl(fileTextGenerator);

        }


        private void SetMessage(string message)
        {
            Task.Factory.StartNew(() =>
            {
                consoleTextBox.Text += $"\r\n { message }";

                consoleTextBox.SelectionStart = consoleTextBox.Text.Length;
                consoleTextBox.ScrollToCaret();

            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private void AddControl(Control control)
        {
            var newTabPage = new TabPage();
            newTabPage.Text = control.Name;
            // newTabPage.UseVisualStyleBackColor = true;
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPage.Controls.Add(control);
            mainTabControl.TabPages.Add(newTabPage);
        }

        private void FileTextGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileTextGenerator = new FileTextGenerator(SetMessage);
            AddControl(fileTextGenerator);
        }

        private void LyricsCatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lyricsCatcher = new LyricsCatcher(SetMessage);
            AddControl(lyricsCatcher);
        }

        private void FileTypeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDetector = new FileTypeDetector();
            AddControl(fileDetector);
        }
    }
}
