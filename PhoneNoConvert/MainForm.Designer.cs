namespace PhoneNoConvert
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CountryCodeLabel = new System.Windows.Forms.Label();
            this.CountryCodeTextBox = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PhoneNoTextBox
            // 
            this.PhoneNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNoTextBox.Location = new System.Drawing.Point(183, 18);
            this.PhoneNoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNoTextBox.Name = "PhoneNoTextBox";
            this.PhoneNoTextBox.Size = new System.Drawing.Size(237, 30);
            this.PhoneNoTextBox.TabIndex = 1;
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNoLabel.Location = new System.Drawing.Point(16, 23);
            this.PhoneNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(149, 25);
            this.PhoneNoLabel.TabIndex = 0;
            this.PhoneNoLabel.Text = "Phone Number:";
            this.PhoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConvertButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertButton.Image")));
            this.ConvertButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConvertButton.Location = new System.Drawing.Point(451, 18);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 100);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CountryCodeLabel
            // 
            this.CountryCodeLabel.AutoSize = true;
            this.CountryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryCodeLabel.Location = new System.Drawing.Point(28, 83);
            this.CountryCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountryCodeLabel.Name = "CountryCodeLabel";
            this.CountryCodeLabel.Size = new System.Drawing.Size(140, 25);
            this.CountryCodeLabel.TabIndex = 2;
            this.CountryCodeLabel.Text = "Country Code:";
            this.CountryCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountryCodeTextBox
            // 
            this.CountryCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CountryCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryCodeTextBox.Location = new System.Drawing.Point(183, 78);
            this.CountryCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountryCodeTextBox.MaxLength = 2;
            this.CountryCodeTextBox.Name = "CountryCodeTextBox";
            this.CountryCodeTextBox.Size = new System.Drawing.Size(237, 30);
            this.CountryCodeTextBox.TabIndex = 3;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsLabel.Location = new System.Drawing.Point(16, 137);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(82, 25);
            this.ResultsLabel.TabIndex = 5;
            this.ResultsLabel.Text = "Results:";
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsTextBox.Location = new System.Drawing.Point(21, 172);
            this.ResultsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(528, 499);
            this.ResultsTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 694);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.CountryCodeLabel);
            this.Controls.Add(this.CountryCodeTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.PhoneNoLabel);
            this.Controls.Add(this.PhoneNoTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1181, 1482);
            this.MinimumSize = new System.Drawing.Size(587, 729);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Convert Phone Numbers to E.164";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNoTextBox;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label CountryCodeLabel;
        private System.Windows.Forms.TextBox CountryCodeTextBox;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.TextBox ResultsTextBox;
    }
}

