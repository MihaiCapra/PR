namespace Lab4PR
{
     partial class fSendMail
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
            this.toTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.toLabel = new MetroFramework.Controls.MetroLabel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.titleTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.msgLabel = new MetroFramework.Controls.MetroLabel();
            this.msgTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.attachementsLabel = new MetroFramework.Controls.MetroLabel();
            this.attachButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // toTxtBox
            // 
            // 
            // 
            // 
            this.toTxtBox.CustomButton.Image = null;
            this.toTxtBox.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.toTxtBox.CustomButton.Name = "";
            this.toTxtBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.toTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.toTxtBox.CustomButton.TabIndex = 1;
            this.toTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toTxtBox.CustomButton.UseSelectable = true;
            this.toTxtBox.CustomButton.Visible = false;
            this.toTxtBox.Lines = new string[] {
        "mihai.capra27@gmail.com"};
            this.toTxtBox.Location = new System.Drawing.Point(110, 66);
            this.toTxtBox.MaxLength = 32767;
            this.toTxtBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.PasswordChar = '\0';
            this.toTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.toTxtBox.SelectedText = "";
            this.toTxtBox.SelectionLength = 0;
            this.toTxtBox.SelectionStart = 0;
            this.toTxtBox.ShortcutsEnabled = true;
            this.toTxtBox.Size = new System.Drawing.Size(287, 25);
            this.toTxtBox.TabIndex = 1;
            this.toTxtBox.Text = "mihai.capra27@gmail.com";
            this.toTxtBox.UseSelectable = true;
            this.toTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.toTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Green;
            this.btnSend.Location = new System.Drawing.Point(311, 257);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 32);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Trimite";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // toLabel
            // 
            this.toLabel.Location = new System.Drawing.Point(12, 66);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(92, 23);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "Catre";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(12, 97);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 23);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Subiect";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTxtBox
            // 
            // 
            // 
            // 
            this.titleTxtBox.CustomButton.Image = null;
            this.titleTxtBox.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.titleTxtBox.CustomButton.Name = "";
            this.titleTxtBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.titleTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleTxtBox.CustomButton.TabIndex = 1;
            this.titleTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTxtBox.CustomButton.UseSelectable = true;
            this.titleTxtBox.CustomButton.Visible = false;
            this.titleTxtBox.Lines = new string[0];
            this.titleTxtBox.Location = new System.Drawing.Point(110, 97);
            this.titleTxtBox.MaxLength = 32767;
            this.titleTxtBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.PasswordChar = '\0';
            this.titleTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleTxtBox.SelectedText = "";
            this.titleTxtBox.SelectionLength = 0;
            this.titleTxtBox.SelectionStart = 0;
            this.titleTxtBox.ShortcutsEnabled = true;
            this.titleTxtBox.Size = new System.Drawing.Size(287, 25);
            this.titleTxtBox.TabIndex = 4;
            this.titleTxtBox.UseSelectable = true;
            this.titleTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // msgLabel
            // 
            this.msgLabel.Location = new System.Drawing.Point(12, 128);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(92, 23);
            this.msgLabel.TabIndex = 7;
            this.msgLabel.Text = "Mesajul";
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgTxtBox
            // 
            // 
            // 
            // 
            this.msgTxtBox.CustomButton.Image = null;
            this.msgTxtBox.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.msgTxtBox.CustomButton.Name = "";
            this.msgTxtBox.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.msgTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.msgTxtBox.CustomButton.TabIndex = 1;
            this.msgTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.msgTxtBox.CustomButton.UseSelectable = true;
            this.msgTxtBox.CustomButton.Visible = false;
            this.msgTxtBox.Lines = new string[0];
            this.msgTxtBox.Location = new System.Drawing.Point(110, 128);
            this.msgTxtBox.MaxLength = 32767;
            this.msgTxtBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.msgTxtBox.Multiline = true;
            this.msgTxtBox.Name = "msgTxtBox";
            this.msgTxtBox.PasswordChar = '\0';
            this.msgTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.msgTxtBox.SelectedText = "";
            this.msgTxtBox.SelectionLength = 0;
            this.msgTxtBox.SelectionStart = 0;
            this.msgTxtBox.ShortcutsEnabled = true;
            this.msgTxtBox.Size = new System.Drawing.Size(287, 121);
            this.msgTxtBox.TabIndex = 6;
            this.msgTxtBox.UseSelectable = true;
            this.msgTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msgTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // attachementsLabel
            // 
            this.attachementsLabel.Location = new System.Drawing.Point(12, 252);
            this.attachementsLabel.Name = "attachementsLabel";
            this.attachementsLabel.Size = new System.Drawing.Size(118, 37);
            this.attachementsLabel.TabIndex = 8;
            this.attachementsLabel.Text = "Ataseaza fisier";
            this.attachementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(219, 257);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(86, 32);
            this.attachButton.TabIndex = 9;
            this.attachButton.Text = "Ataseaza";
            this.attachButton.UseSelectable = true;
            this.attachButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // fSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 368);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.attachementsLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.msgTxtBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.toTxtBox);
            this.Name = "fSendMail";
            this.Text = "Send e-mail";
            this.ResumeLayout(false);

          }

          #endregion
          private MetroFramework.Controls.MetroTextBox toTxtBox;
          private MetroFramework.Controls.MetroButton btnSend;
          private MetroFramework.Controls.MetroLabel toLabel;
          private MetroFramework.Controls.MetroLabel titleLabel;
          private MetroFramework.Controls.MetroTextBox titleTxtBox;
          private MetroFramework.Controls.MetroLabel msgLabel;
          private MetroFramework.Controls.MetroTextBox msgTxtBox;
          private MetroFramework.Controls.MetroLabel attachementsLabel;
          private MetroFramework.Controls.MetroButton attachButton;
     }
}