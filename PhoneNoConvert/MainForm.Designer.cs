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
            this.PhoneNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoTextBox.Location = new System.Drawing.Point(137, 12);
            this.PhoneNoTextBox.Name = "PhoneNoTextBox";
            this.PhoneNoTextBox.Size = new System.Drawing.Size(179, 26);
            this.PhoneNoTextBox.TabIndex = 1;
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoLabel.Location = new System.Drawing.Point(12, 15);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(119, 20);
            this.PhoneNoLabel.TabIndex = 0;
            this.PhoneNoLabel.Text = "Phone Number:";
            this.PhoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertButton.Image")));
            this.ConvertButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConvertButton.Location = new System.Drawing.Point(338, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 65);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CountryCodeLabel
            // 
            this.CountryCodeLabel.AutoSize = true;
            this.CountryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryCodeLabel.Location = new System.Drawing.Point(21, 54);
            this.CountryCodeLabel.Name = "CountryCodeLabel";
            this.CountryCodeLabel.Size = new System.Drawing.Size(110, 20);
            this.CountryCodeLabel.TabIndex = 2;
            this.CountryCodeLabel.Text = "Country Code:";
            this.CountryCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountryCodeTextBox
            // 
            this.CountryCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryCodeTextBox.Location = new System.Drawing.Point(137, 51);
            this.CountryCodeTextBox.Name = "CountryCodeTextBox";
            this.CountryCodeTextBox.Size = new System.Drawing.Size(179, 26);
            this.CountryCodeTextBox.TabIndex = 3;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLabel.Location = new System.Drawing.Point(12, 89);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(67, 20);
            this.ResultsLabel.TabIndex = 5;
            this.ResultsLabel.Text = "Results:";
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsTextBox.Location = new System.Drawing.Point(16, 112);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(397, 326);
            this.ResultsTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 451);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.CountryCodeLabel);
            this.Controls.Add(this.CountryCodeTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.PhoneNoLabel);
            this.Controls.Add(this.PhoneNoTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 980);
            this.MinimumSize = new System.Drawing.Size(445, 490);
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

