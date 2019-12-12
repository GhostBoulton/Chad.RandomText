namespace Chad.RandomText.WinForms
{
    partial class FileTextGenerator
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
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileButton = new System.Windows.Forms.Button();
            this.outputFilecheckBox = new System.Windows.Forms.CheckBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.textLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.sourceFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceFileTextBox.ForeColor = System.Drawing.Color.Silver;
            this.sourceFileTextBox.Location = new System.Drawing.Point(223, 48);
            this.sourceFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(185, 22);
            this.sourceFileTextBox.TabIndex = 5;
            // 
            // sourceFileButton
            // 
            this.sourceFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sourceFileButton.FlatAppearance.BorderSize = 0;
            this.sourceFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourceFileButton.Location = new System.Drawing.Point(67, 45);
            this.sourceFileButton.Name = "sourceFileButton";
            this.sourceFileButton.Size = new System.Drawing.Size(149, 27);
            this.sourceFileButton.TabIndex = 6;
            this.sourceFileButton.Text = "Source File:";
            this.sourceFileButton.UseVisualStyleBackColor = false;
            this.sourceFileButton.Click += new System.EventHandler(this.SourceFileButton_Click);
            // 
            // outputFilecheckBox
            // 
            this.outputFilecheckBox.AutoSize = true;
            this.outputFilecheckBox.Location = new System.Drawing.Point(23, 105);
            this.outputFilecheckBox.Name = "outputFilecheckBox";
            this.outputFilecheckBox.Size = new System.Drawing.Size(38, 21);
            this.outputFilecheckBox.TabIndex = 10;
            this.outputFilecheckBox.Text = "?";
            this.outputFilecheckBox.UseVisualStyleBackColor = true;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.outputFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFileTextBox.ForeColor = System.Drawing.Color.Silver;
            this.outputFileTextBox.Location = new System.Drawing.Point(223, 104);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(209, 22);
            this.outputFileTextBox.TabIndex = 9;
            // 
            // outputFileButton
            // 
            this.outputFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.outputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFileButton.Location = new System.Drawing.Point(67, 105);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(149, 27);
            this.outputFileButton.TabIndex = 8;
            this.outputFileButton.Text = "Output File:";
            this.outputFileButton.UseVisualStyleBackColor = false;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Location = new System.Drawing.Point(23, 270);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(385, 27);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // textLengthTextBox
            // 
            this.textLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.textLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLengthTextBox.ForeColor = System.Drawing.Color.Silver;
            this.textLengthTextBox.Location = new System.Drawing.Point(223, 171);
            this.textLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.textLengthTextBox.Name = "textLengthTextBox";
            this.textLengthTextBox.Size = new System.Drawing.Size(88, 22);
            this.textLengthTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "how much text to parse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Replace \\r\\n with new line:";
            // 
            // replaceLinesCheckBox
            // 
            this.replaceLinesCheckBox.AutoSize = true;
            this.replaceLinesCheckBox.Location = new System.Drawing.Point(223, 213);
            this.replaceLinesCheckBox.Name = "replaceLinesCheckBox";
            this.replaceLinesCheckBox.Size = new System.Drawing.Size(38, 21);
            this.replaceLinesCheckBox.TabIndex = 16;
            this.replaceLinesCheckBox.Text = "?";
            this.replaceLinesCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileTextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.replaceLinesCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLengthTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputFilecheckBox);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.sourceFileButton);
            this.Controls.Add(this.sourceFileTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "FileTextGenerator";
            this.Size = new System.Drawing.Size(455, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.Button sourceFileButton;
        private System.Windows.Forms.CheckBox outputFilecheckBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox textLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox replaceLinesCheckBox;
    }
}
