namespace Chad.RandomText.WinForms
{
    partial class LyricsCatcher
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.makeRequestButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.artistIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requestUrlTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getResultsButton = new System.Windows.Forms.Button();
            this.accessTokenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(443, 182);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 37);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchTextBox.Location = new System.Drawing.Point(129, 186);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(296, 22);
            this.searchTextBox.TabIndex = 24;
            // 
            // makeRequestButton
            // 
            this.makeRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.makeRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeRequestButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeRequestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.makeRequestButton.Location = new System.Drawing.Point(129, 342);
            this.makeRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.makeRequestButton.Name = "makeRequestButton";
            this.makeRequestButton.Size = new System.Drawing.Size(406, 46);
            this.makeRequestButton.TabIndex = 23;
            this.makeRequestButton.Text = "make request";
            this.makeRequestButton.UseVisualStyleBackColor = false;
            this.makeRequestButton.Click += new System.EventHandler(this.MakeRequestButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "artistid";
            // 
            // artistIdTextBox
            // 
            this.artistIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.artistIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.artistIdTextBox.Location = new System.Drawing.Point(125, 556);
            this.artistIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.artistIdTextBox.Name = "artistIdTextBox";
            this.artistIdTextBox.Size = new System.Drawing.Size(129, 22);
            this.artistIdTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "access token:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "output file:";
            // 
            // requestUrlTextBox
            // 
            this.requestUrlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.requestUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestUrlTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.requestUrlTextBox.Location = new System.Drawing.Point(129, 289);
            this.requestUrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.requestUrlTextBox.Name = "requestUrlTextBox";
            this.requestUrlTextBox.Size = new System.Drawing.Size(406, 22);
            this.requestUrlTextBox.TabIndex = 14;
            // 
            // outputFileTextbox
            // 
            this.outputFileTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.outputFileTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFileTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.outputFileTextbox.Location = new System.Drawing.Point(126, 475);
            this.outputFileTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.outputFileTextbox.Name = "outputFileTextbox";
            this.outputFileTextbox.Size = new System.Drawing.Size(405, 22);
            this.outputFileTextbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "url";
            // 
            // getResultsButton
            // 
            this.getResultsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.getResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getResultsButton.Font = new System.Drawing.Font("Dank Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getResultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.getResultsButton.Location = new System.Drawing.Point(278, 550);
            this.getResultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.getResultsButton.Name = "getResultsButton";
            this.getResultsButton.Size = new System.Drawing.Size(256, 46);
            this.getResultsButton.TabIndex = 16;
            this.getResultsButton.Text = "Write Artist Lyrics";
            this.getResultsButton.UseVisualStyleBackColor = false;
            this.getResultsButton.Click += new System.EventHandler(this.GetResultsButton_Click);
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.accessTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accessTokenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accessTokenTextBox.Location = new System.Drawing.Point(126, 112);
            this.accessTokenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.Size = new System.Drawing.Size(406, 22);
            this.accessTokenTextBox.TabIndex = 17;
            // 
            // LyricsCatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.makeRequestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.artistIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.requestUrlTextBox);
            this.Controls.Add(this.outputFileTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getResultsButton);
            this.Controls.Add(this.accessTokenTextBox);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "LyricsCatcher";
            this.Size = new System.Drawing.Size(656, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button makeRequestButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox artistIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox requestUrlTextBox;
        private System.Windows.Forms.TextBox outputFileTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getResultsButton;
        private System.Windows.Forms.TextBox accessTokenTextBox;
    }
}
