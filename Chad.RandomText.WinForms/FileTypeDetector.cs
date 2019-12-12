using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chad.RandomText.WinForms
{
    public partial class FileTypeDetector : UserControl
    {
        public FileTypeDetector()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                //Filter = "txt files (*.txt)|*.txt",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathText.Text = fileDialog.FileName;
            }
        }

        private void Dectectbutton_Click(object sender, EventArgs e)
        {
            var bytes = System.IO.File.ReadAllBytes(filePathText.Text);

            outTextBox1.Text = GetMimeFromBytes(bytes);
        }

        public static int MimeSampleSize = 256;

        public static string DefaultMimeType = "application/octet-stream";

        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        private extern static uint FindMimeFromData(
            uint pBC,
            [MarshalAs(UnmanagedType.LPStr)] string pwzUrl,
            [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
            uint cbSize,
            [MarshalAs(UnmanagedType.LPStr)] string pwzMimeProposed,
            uint dwMimeFlags,
            out uint ppwzMimeOut,
            uint dwReserverd
        );

        public static string GetMimeFromBytes(byte[] data)
        {
            try
            {
                uint mimeType;
                FindMimeFromData(0, null, data, (uint)MimeSampleSize, null, 0, out mimeType, 0);

                var mimePointer = new IntPtr(mimeType);
                var mime = Marshal.PtrToStringUni(mimePointer);
                Marshal.FreeCoTaskMem(mimePointer);

                return mime ?? DefaultMimeType;
            }
            catch
            {
                return DefaultMimeType;
            }
        }

        
    }
}
