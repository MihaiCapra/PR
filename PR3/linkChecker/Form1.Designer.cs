namespace linkChecker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlLabel = new MetroFramework.Controls.MetroLabel();
            this.urlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnRun = new MetroFramework.Controls.MetroButton();
            this.resultRTB = new System.Windows.Forms.RichTextBox();
            this.resultLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(23, 53);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 19);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "Url:";
            // 
            // urlTextBox
            // 
            // 
            // 
            // 
            this.urlTextBox.CustomButton.Image = null;
            this.urlTextBox.CustomButton.Location = new System.Drawing.Point(541, 2);
            this.urlTextBox.CustomButton.Name = "";
            this.urlTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.urlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlTextBox.CustomButton.TabIndex = 1;
            this.urlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlTextBox.CustomButton.UseSelectable = true;
            this.urlTextBox.CustomButton.Visible = false;
            this.urlTextBox.Lines = new string[0];
            this.urlTextBox.Location = new System.Drawing.Point(58, 52);
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.ShortcutsEnabled = true;
            this.urlTextBox.Size = new System.Drawing.Size(559, 20);
            this.urlTextBox.TabIndex = 2;
            this.urlTextBox.UseSelectable = true;
            this.urlTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(542, 80);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseSelectable = true;
            this.btnRun.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // resultRTB
            // 
            this.resultRTB.Location = new System.Drawing.Point(23, 109);
            this.resultRTB.Name = "resultRTB";
            this.resultRTB.ReadOnly = true;
            this.resultRTB.Size = new System.Drawing.Size(594, 348);
            this.resultRTB.TabIndex = 4;
            this.resultRTB.Text = "";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 84);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(81, 19);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultRTB);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "LINK Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel urlLabel;
        private MetroFramework.Controls.MetroTextBox urlTextBox;
        private MetroFramework.Controls.MetroButton btnRun;
        private System.Windows.Forms.RichTextBox resultRTB;
        private MetroFramework.Controls.MetroLabel resultLabel;
    }
}

