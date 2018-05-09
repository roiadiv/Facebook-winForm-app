using System;

namespace Facebook_app
{
    public partial class FormNavigateToEvent
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
            this.panelEvents = new System.Windows.Forms.Panel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.richTextBoxEventDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFocusEvent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowserEvent = new System.Windows.Forms.WebBrowser();
            this.labelAttending = new System.Windows.Forms.Label();
            this.labelMaybe = new System.Windows.Forms.Label();
            this.labelDecline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.panelFocusEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEvents
            // 
            this.panelEvents.AutoScroll = true;
            this.panelEvents.Location = new System.Drawing.Point(1, 0);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(983, 69);
            this.panelEvents.TabIndex = 11;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(181, 106);
            this.pictureBoxEvent.TabIndex = 12;
            this.pictureBoxEvent.TabStop = false;
            // 
            // richTextBoxEvent
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(3, 112);
            this.richTextBoxEventDescription.Name = "richTextBoxEvent";
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(181, 219);
            this.richTextBoxEventDescription.TabIndex = 14;
            this.richTextBoxEventDescription.Text = string.Empty;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Attending:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Maybe:";
            // 
            // panelFocusEvent
            // 
            this.panelFocusEvent.Controls.Add(this.labelDecline);
            this.panelFocusEvent.Controls.Add(this.labelMaybe);
            this.panelFocusEvent.Controls.Add(this.labelAttending);
            this.panelFocusEvent.Controls.Add(this.label3);
            this.panelFocusEvent.Controls.Add(this.pictureBoxEvent);
            this.panelFocusEvent.Controls.Add(this.label2);
            this.panelFocusEvent.Controls.Add(this.richTextBoxEventDescription);
            this.panelFocusEvent.Controls.Add(this.label1);
            this.panelFocusEvent.Location = new System.Drawing.Point(1, 76);
            this.panelFocusEvent.Name = "panelFocusEvent";
            this.panelFocusEvent.Size = new System.Drawing.Size(200, 435);
            this.panelFocusEvent.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Decline:";
            // 
            // webBrowserEvent
            // 
            this.webBrowserEvent.Location = new System.Drawing.Point(199, 76);
            this.webBrowserEvent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserEvent.Name = "webBrowserEvent";
            this.webBrowserEvent.Size = new System.Drawing.Size(777, 435);
            this.webBrowserEvent.TabIndex = 18;
            // 
            // labelAttending
            // 
            this.labelAttending.AutoSize = true;
            this.labelAttending.Location = new System.Drawing.Point(64, 344);
            this.labelAttending.Name = "labelAttending";
            this.labelAttending.Size = new System.Drawing.Size(0, 13);
            this.labelAttending.TabIndex = 18;
            // 
            // labelMaybe
            // 
            this.labelMaybe.AutoSize = true;
            this.labelMaybe.Location = new System.Drawing.Point(64, 372);
            this.labelMaybe.Name = "labelMaybe";
            this.labelMaybe.Size = new System.Drawing.Size(0, 13);
            this.labelMaybe.TabIndex = 19;
            // 
            // labelDecline
            // 
            this.labelDecline.AutoSize = true;
            this.labelDecline.Location = new System.Drawing.Point(64, 404);
            this.labelDecline.Name = "labelDecline";
            this.labelDecline.Size = new System.Drawing.Size(0, 13);
            this.labelDecline.TabIndex = 20;
            // 
            // FormNavigateToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 523);
            this.Controls.Add(this.webBrowserEvent);
            this.Controls.Add(this.panelFocusEvent);
            this.Controls.Add(this.panelEvents);
            this.Name = "FormNavigateToEvent";
            this.Text = "FormNavigateToEvent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.panelFocusEvent.ResumeLayout(false);
            this.panelFocusEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.RichTextBox richTextBoxEventDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFocusEvent;
        private System.Windows.Forms.Label labelDecline;
        private System.Windows.Forms.Label labelMaybe;
        private System.Windows.Forms.Label labelAttending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowserEvent;
    }
}