namespace Facebook_app
{
    public partial class FormMostAttendedEvent
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
            this.pictureBoxMostAttendingEvent = new System.Windows.Forms.PictureBox();
            this.textBoxNumOfAttending = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEventsMostAttendedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostAttendingEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMostAttendingEvent
            // 
            this.pictureBoxMostAttendingEvent.Location = new System.Drawing.Point(26, 33);
            this.pictureBoxMostAttendingEvent.Name = "pictureBoxMostAttendingEvent";
            this.pictureBoxMostAttendingEvent.Size = new System.Drawing.Size(239, 195);
            this.pictureBoxMostAttendingEvent.TabIndex = 0;
            this.pictureBoxMostAttendingEvent.TabStop = false;
            // 
            // textBoxNumOfAttending
            // 
            this.textBoxNumOfAttending.Location = new System.Drawing.Point(381, 86);
            this.textBoxNumOfAttending.Name = "textBoxNumOfAttending";
            this.textBoxNumOfAttending.Size = new System.Drawing.Size(114, 20);
            this.textBoxNumOfAttending.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num Of Attending:";
            // 
            // textBoxEventsMostAttendedName
            // 
            this.textBoxEventsMostAttendedName.Location = new System.Drawing.Point(381, 60);
            this.textBoxEventsMostAttendedName.Name = "textBoxEventsMostAttendedName";
            this.textBoxEventsMostAttendedName.Size = new System.Drawing.Size(114, 20);
            this.textBoxEventsMostAttendedName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event\'s Name:";
            // 
            // MostAttendedEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEventsMostAttendedName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumOfAttending);
            this.Controls.Add(this.pictureBoxMostAttendingEvent);
            this.Name = "MostAttendedEventForm";
            this.Text = "MostAttendingEvent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostAttendingEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostAttendingEvent;
        private System.Windows.Forms.TextBox textBoxNumOfAttending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEventsMostAttendedName;
        private System.Windows.Forms.Label label2;
    }
}