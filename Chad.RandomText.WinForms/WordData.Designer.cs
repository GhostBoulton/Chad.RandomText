namespace Chad.RandomText.WinForms
{
    partial class WordData
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sentenceText = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.goButton);
            this.splitContainer1.Panel1.Controls.Add(this.sentenceText);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.consoleText);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 505);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // consoleText
            // 
            this.consoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.consoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.consoleText.Location = new System.Drawing.Point(0, 0);
            this.consoleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(642, 505);
            this.consoleText.TabIndex = 0;
            this.consoleText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "sentence:";
            // 
            // sentenceText
            // 
            this.sentenceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.sentenceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sentenceText.ForeColor = System.Drawing.Color.Silver;
            this.sentenceText.Location = new System.Drawing.Point(17, 61);
            this.sentenceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sentenceText.Name = "sentenceText";
            this.sentenceText.Size = new System.Drawing.Size(538, 31);
            this.sentenceText.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.goButton.Location = new System.Drawing.Point(214, 135);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(121, 63);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // WordData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 505);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WordData";
            this.Text = "WordData";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox sentenceText;
        private System.Windows.Forms.Label label1;
    }
}