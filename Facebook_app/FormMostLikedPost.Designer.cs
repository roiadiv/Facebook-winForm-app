namespace Facebook_app
{
    public partial class FormMostLikedPost
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
            this.listBoxLikedTheMostLikedPost = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMostLikePostMessage = new System.Windows.Forms.TextBox();
            this.textBoxMostLikedPostDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxMostLikedPost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPost)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLikedTheMostLikedPost
            // 
            this.listBoxLikedTheMostLikedPost.Location = new System.Drawing.Point(371, 23);
            this.listBoxLikedTheMostLikedPost.Name = "listBoxLikedTheMostLikedPost";
            this.listBoxLikedTheMostLikedPost.Size = new System.Drawing.Size(151, 145);
            this.listBoxLikedTheMostLikedPost.TabIndex = 1;
            this.listBoxLikedTheMostLikedPost.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(300, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "liked by:";
            // 
            // textBoxMostLikePostMessage
            // 
            this.textBoxMostLikePostMessage.Location = new System.Drawing.Point(87, 171);
            this.textBoxMostLikePostMessage.Name = "textBoxMostLikePostMessage";
            this.textBoxMostLikePostMessage.Size = new System.Drawing.Size(100, 20);
            this.textBoxMostLikePostMessage.TabIndex = 3;
            // 
            // textBoxMostLikedPostDate
            // 
            this.textBoxMostLikedPostDate.Location = new System.Drawing.Point(87, 208);
            this.textBoxMostLikedPostDate.Name = "textBoxMostLikedPostDate";
            this.textBoxMostLikedPostDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxMostLikedPostDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The Post:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post Date:";
            // 
            // pictureBoxMostLikedPost
            // 
            this.pictureBoxMostLikedPost.Location = new System.Drawing.Point(24, 23);
            this.pictureBoxMostLikedPost.Name = "pictureBoxMostLikedPost";
            this.pictureBoxMostLikedPost.Size = new System.Drawing.Size(163, 121);
            this.pictureBoxMostLikedPost.TabIndex = 0;
            this.pictureBoxMostLikedPost.TabStop = false;
            // 
            // FormMostLikedPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMostLikedPostDate);
            this.Controls.Add(this.textBoxMostLikePostMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLikedTheMostLikedPost);
            this.Controls.Add(this.pictureBoxMostLikedPost);
            this.Name = "FormMostLikedPost";
            this.Text = "MostLikedPostForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostLikedPost;
        private System.Windows.Forms.ListView listBoxLikedTheMostLikedPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMostLikePostMessage;
        private System.Windows.Forms.TextBox textBoxMostLikedPostDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}