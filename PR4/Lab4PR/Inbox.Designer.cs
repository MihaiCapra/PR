﻿namespace Lab4PR
{
     partial class Inbox
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelAttachments = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panelContent.SuspendLayout();
            this.panelAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Controls.Add(this.webBrowser1);
            this.panelContent.Location = new System.Drawing.Point(278, 63);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(707, 400);
            this.panelContent.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(701, 397);
            this.webBrowser1.TabIndex = 0;
            // 
            // panelAttachments
            // 
            this.panelAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttachments.Controls.Add(this.label1);
            this.panelAttachments.Controls.Add(this.listView2);
            this.panelAttachments.Location = new System.Drawing.Point(991, 63);
            this.panelAttachments.Name = "panelAttachments";
            this.panelAttachments.Size = new System.Drawing.Size(94, 400);
            this.panelAttachments.TabIndex = 2;
            this.panelAttachments.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attachments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(94, 396);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.panelAttachments);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.listView1);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.ShowAllMailsForm_Load);
            this.panelContent.ResumeLayout(false);
            this.panelAttachments.ResumeLayout(false);
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panelAttachments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
    }
}