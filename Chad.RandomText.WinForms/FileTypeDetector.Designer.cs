namespace Chad.RandomText.WinForms
{
    partial class FileTypeDetector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.dectectbutton = new System.Windows.Forms.Button();
            this.outTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(595, 155);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(96, 37);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "choose";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(249, 160);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(340, 26);
            this.filePathText.TabIndex = 1;
            // 
            // dectectbutton
            // 
            this.dectectbutton.Location = new System.Drawing.Point(249, 244);
            this.dectectbutton.Name = "dectectbutton";
            this.dectectbutton.Size = new System.Drawing.Size(442, 57);
            this.dectectbutton.TabIndex = 2;
            this.dectectbutton.Text = "detect";
            this.dectectbutton.UseVisualStyleBackColor = true;
            this.dectectbutton.Click += new System.EventHandler(this.Dectectbutton_Click);
            // 
            // outTextBox1
            // 
            this.outTextBox1.Location = new System.Drawing.Point(249, 353);
            this.outTextBox1.Name = "outTextBox1";
            this.outTextBox1.Size = new System.Drawing.Size(442, 352);
            this.outTextBox1.TabIndex = 3;
            this.outTextBox1.Text = "";
            // 
            // FileTypeDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outTextBox1);
            this.Controls.Add(this.dectectbutton);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "FileTypeDetector";
            this.Size = new System.Drawing.Size(908, 952);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button dectectbutton;
        private System.Windows.Forms.RichTextBox outTextBox1;
    }
}
