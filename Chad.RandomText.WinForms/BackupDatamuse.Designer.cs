namespace Chad.RandomText.WinForms
{
    partial class BackupDatamuse
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
            this.requestUrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getResultsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accessTokenTextBox = new System.Windows.Forms.TextBox();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFileTextbox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.artistIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.makeRequestButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestUrlTextBox
            // 
            this.requestUrlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.requestUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestUrlTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.requestUrlTextBox.Location = new System.Drawing.Point(61, 237);
            this.requestUrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.requestUrlTextBox.Name = "requestUrlTextBox";
            this.requestUrlTextBox.Size = new System.Drawing.Size(406, 31);
            this.requestUrlTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "url";
            // 
            // getResultsButton
            // 
            this.getResultsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.getResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getResultsButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getResultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.getResultsButton.Location = new System.Drawing.Point(210, 498);
            this.getResultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.getResultsButton.Name = "getResultsButton";
            this.getResultsButton.Size = new System.Drawing.Size(256, 46);
            this.getResultsButton.TabIndex = 2;
            this.getResultsButton.Text = "Write Artist Lyrics";
            this.getResultsButton.UseVisualStyleBackColor = false;
            this.getResultsButton.Click += new System.EventHandler(this.getResultsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "access token:";
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.accessTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accessTokenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accessTokenTextBox.Location = new System.Drawing.Point(58, 60);
            this.accessTokenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.Size = new System.Drawing.Size(406, 31);
            this.accessTokenTextBox.TabIndex = 3;
            // 
            // consoleText
            // 
            this.consoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.consoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleText.Font = new System.Drawing.Font("Dank Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.consoleText.Location = new System.Drawing.Point(0, 0);
            this.consoleText.Margin = new System.Windows.Forms.Padding(4);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(759, 600);
            this.consoleText.TabIndex = 5;
            this.consoleText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "output file:";
            // 
            // outputFileTextbox
            // 
            this.outputFileTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.outputFileTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFileTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.outputFileTextbox.Location = new System.Drawing.Point(58, 423);
            this.outputFileTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.outputFileTextbox.Name = "outputFileTextbox";
            this.outputFileTextbox.Size = new System.Drawing.Size(405, 31);
            this.outputFileTextbox.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.makeRequestButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.artistIdTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.requestUrlTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.outputFileTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.getResultsButton);
            this.splitContainer1.Panel1.Controls.Add(this.accessTokenTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.consoleText);
            this.splitContainer1.Size = new System.Drawing.Size(1270, 600);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 8;
            // 
            // artistIdTextBox
            // 
            this.artistIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.artistIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.artistIdTextBox.Location = new System.Drawing.Point(57, 504);
            this.artistIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.artistIdTextBox.Name = "artistIdTextBox";
            this.artistIdTextBox.Size = new System.Drawing.Size(129, 31);
            this.artistIdTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "artistid";
            // 
            // makeRequestButton
            // 
            this.makeRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.makeRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeRequestButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeRequestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.makeRequestButton.Location = new System.Drawing.Point(61, 290);
            this.makeRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.makeRequestButton.Name = "makeRequestButton";
            this.makeRequestButton.Size = new System.Drawing.Size(406, 46);
            this.makeRequestButton.TabIndex = 10;
            this.makeRequestButton.Text = "make request";
            this.makeRequestButton.UseVisualStyleBackColor = false;
            this.makeRequestButton.Click += new System.EventHandler(this.makeRequestButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(375, 130);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 37);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchTextBox.Location = new System.Drawing.Point(61, 134);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(296, 31);
            this.searchTextBox.TabIndex = 11;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1270, 600);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Chad.Random";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox requestUrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getResultsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accessTokenTextBox;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputFileTextbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox artistIdTextBox;
        private System.Windows.Forms.Button makeRequestButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

