namespace Facebook_app
{
    public partial class FormMostLikedPhoto
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxLikedTheMostLikedPhoto = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMostLikedPhotoDate = new System.Windows.Forms.TextBox();
            this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(229, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "liked by:";
            // 
            // listBoxLikedTheMostLikedPhoto
            // 
            this.listBoxLikedTheMostLikedPhoto.Location = new System.Drawing.Point(281, 29);
            this.listBoxLikedTheMostLikedPhoto.Name = "listBoxLikedTheMostLikedPhoto";
            this.listBoxLikedTheMostLikedPhoto.Size = new System.Drawing.Size(151, 152);
            this.listBoxLikedTheMostLikedPhoto.TabIndex = 4;
            this.listBoxLikedTheMostLikedPhoto.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upload Date:";
            // 
            // textBoxMostLikedPhotoDate
            // 
            this.textBoxMostLikedPhotoDate.Location = new System.Drawing.Point(105, 222);
            this.textBoxMostLikedPhotoDate.Name = "textBoxMostLikedPhotoDate";
            this.textBoxMostLikedPhotoDate.Size = new System.Drawing.Size(110, 20);
            this.textBoxMostLikedPhotoDate.TabIndex = 8;
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(23, 29);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(163, 152);
            this.pictureBoxMostLikedPhoto.TabIndex = 1;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            // 
            // FormMostLikedPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 328);
            this.Controls.Add(this.textBoxMostLikedPhotoDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxLikedTheMostLikedPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMostLikedPhoto);
            this.Name = "FormMostLikedPhoto";
            this.Text = "MostLikedPhotoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listBoxLikedTheMostLikedPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMostLikedPhotoDate;
    }
}