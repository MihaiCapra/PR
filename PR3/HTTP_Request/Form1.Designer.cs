namespace PR3
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
            this.urlBox = new MetroFramework.Controls.MetroTextBox();
            this.urlData = new MetroFramework.Controls.MetroLabel();
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.btnRun = new MetroFramework.Controls.MetroButton();
            this.optionsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.resultRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 55);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 19);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "Url:";
            // 
            // urlBox
            // 
            // 
            // 
            // 
            this.urlBox.CustomButton.Image = null;
            this.urlBox.CustomButton.Location = new System.Drawing.Point(487, 2);
            this.urlBox.CustomButton.Name = "";
            this.urlBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.urlBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlBox.CustomButton.TabIndex = 1;
            this.urlBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlBox.CustomButton.UseSelectable = true;
            this.urlBox.CustomButton.Visible = false;
            this.urlBox.Lines = new string[0];
            this.urlBox.Location = new System.Drawing.Point(42, 53);
            this.urlBox.MaxLength = 32767;
            this.urlBox.Name = "urlBox";
            this.urlBox.PasswordChar = '\0';
            this.urlBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlBox.SelectedText = "";
            this.urlBox.SelectionLength = 0;
            this.urlBox.SelectionStart = 0;
            this.urlBox.ShortcutsEnabled = true;
            this.urlBox.Size = new System.Drawing.Size(505, 20);
            this.urlBox.TabIndex = 1;
            this.urlBox.UseSelectable = true;
            this.urlBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // urlData
            // 
            this.urlData.AutoSize = true;
            this.urlData.Location = new System.Drawing.Point(8, 83);
            this.urlData.Name = "urlData";
            this.urlData.Size = new System.Drawing.Size(34, 19);
            this.urlData.TabIndex = 10;
            this.urlData.Text = "Text:";
            this.urlData.Visible = false;
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(487, 2);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(42, 81);
            this.textBox.MaxLength = 32767;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(505, 20);
            this.textBox.TabIndex = 11;
            this.textBox.UseSelectable = true;
            this.textBox.Visible = false;
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(553, 51);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseSelectable = true;
            this.btnRun.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // optionsComboBox
            // 
            this.optionsComboBox.FormattingEnabled = true;
            this.optionsComboBox.ItemHeight = 23;
            this.optionsComboBox.Items.AddRange(new object[] {
            "GET",
            "HEAD",
            "POST"});
            this.optionsComboBox.Location = new System.Drawing.Point(12, 108);
            this.optionsComboBox.Name = "optionsComboBox";
            this.optionsComboBox.Size = new System.Drawing.Size(121, 29);
            this.optionsComboBox.TabIndex = 13;
            this.optionsComboBox.UseSelectable = true;
            this.optionsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.btnClear.Location = new System.Drawing.Point(553, 79);
            this.btnClear.Name = "buttonClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // resultRTB
            // 
            this.resultRTB.Location = new System.Drawing.Point(12, 144);
            this.resultRTB.Name = "resultRTB";
            this.resultRTB.Size = new System.Drawing.Size(616, 313);
            this.resultRTB.ReadOnly = true;
            this.resultRTB.TabIndex = 16;
            this.resultRTB.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.resultRTB);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.optionsComboBox);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.urlData);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.urlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "HTTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox urlBox;
        private MetroFramework.Controls.MetroLabel urlData;
        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroButton btnRun;
        private MetroFramework.Controls.MetroComboBox optionsComboBox;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel urlLabel;
        private System.Windows.Forms.RichTextBox resultRTB;
    }
}

