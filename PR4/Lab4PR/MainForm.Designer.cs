namespace Lab4PR
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
            this.txtBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtBoxLogin
            // 
            // 
            // 
            // 
            this.txtBoxLogin.CustomButton.Image = null;
            this.txtBoxLogin.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtBoxLogin.CustomButton.Name = "";
            this.txtBoxLogin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBoxLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxLogin.CustomButton.TabIndex = 1;
            this.txtBoxLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxLogin.CustomButton.UseSelectable = true;
            this.txtBoxLogin.CustomButton.Visible = false;
            this.txtBoxLogin.Lines = new string[] {
        "mihai.capra27@gmail.com"};
            this.txtBoxLogin.Location = new System.Drawing.Point(23, 56);
            this.txtBoxLogin.MaxLength = 32767;
            this.txtBoxLogin.MinimumSize = new System.Drawing.Size(4, 25);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.PasswordChar = '\0';
            this.txtBoxLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxLogin.SelectedText = "";
            this.txtBoxLogin.SelectionLength = 0;
            this.txtBoxLogin.SelectionStart = 0;
            this.txtBoxLogin.ShortcutsEnabled = true;
            this.txtBoxLogin.Size = new System.Drawing.Size(300, 25);
            this.txtBoxLogin.TabIndex = 0;
            this.txtBoxLogin.Text = "mihai.capra27@gmail.com";
            this.txtBoxLogin.UseSelectable = true;
            // 
            // txtBoxPassword
            // 
            // 
            // 
            // 
            this.txtBoxPassword.CustomButton.Image = null;
            this.txtBoxPassword.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtBoxPassword.CustomButton.Name = "";
            this.txtBoxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPassword.CustomButton.TabIndex = 1;
            this.txtBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPassword.CustomButton.UseSelectable = true;
            this.txtBoxPassword.CustomButton.Visible = false;
            this.txtBoxPassword.Lines = new string[0];
            this.txtBoxPassword.Location = new System.Drawing.Point(23, 117);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.MinimumSize = new System.Drawing.Size(4, 25);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '\0';
            this.txtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.SelectionLength = 0;
            this.txtBoxPassword.SelectionStart = 0;
            this.txtBoxPassword.ShortcutsEnabled = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(300, 25);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.UseSelectable = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(127, 84);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 30);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Parola";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 148);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(171, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizare Date...";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(56, 208);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 33);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Trimite Email";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Name = "MainForm";
            this.Text = "Gmail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

          }

          #endregion

          private MetroFramework.Controls.MetroTextBox txtBoxLogin;
          private MetroFramework.Controls.MetroTextBox txtBoxPassword;
          private MetroFramework.Controls.MetroLabel passwordLabel;
          private MetroFramework.Controls.MetroButton btnLogin;
          private MetroFramework.Controls.MetroButton btnUpdate;
          private MetroFramework.Controls.MetroButton btnSend;
     }
}

