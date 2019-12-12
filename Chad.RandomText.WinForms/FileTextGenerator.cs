using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chad.RandomText.Lib;

namespace Chad.RandomText.WinForms
{
    public partial class FileTextGenerator : UserControl
    {
        private Action<string> SetMessage;
        public FileTextGenerator(Action<string> setMessage)
        {
            InitializeComponent();
            SetMessage = setMessage;
            SetDefaultValues();
        }
        private string SourceFile => sourceFileTextBox.Text;
        private int TextLength => (int.Parse(textLengthTextBox.Text));

        private bool ReplaceBreaksWithLine => replaceLinesCheckBox.Checked;

        private void SetDefaultValues()
        {
            sourceFileTextBox.Text = "C:\\logs\\source.txt";
            textLengthTextBox.Text = "100000"; //int.MaxValue.ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SetMessage(SourceFile);

            var generator = new RandomTextGenerator
            {
                SourcePath = SourceFile,
                OutputPath = $"c:/logs/output_{DateTime.Now.Minute}.txt",
                ReplaceCarriageNewLines = ReplaceBreaksWithLine ? Environment.NewLine : string.Empty
            };
            generator.Parse(TextLength);

            SetMessage(generator.OutputMessage);

            SetMessage(generator.Print(500));
        }

        private void SourceFileButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\logs\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFileTextBox.Text = fileDialog.FileName;
            }

        }
    }
}
