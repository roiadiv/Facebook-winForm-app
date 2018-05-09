namespace Facebook_app
{
    public partial class FormStartApp
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
            this.pictureBoxLikeGif = new System.Windows.Forms.PictureBox();
            this.pictureBoxWelcomeBackground = new System.Windows.Forms.PictureBox();
            this.buttonEnterToApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikeGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcomeBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLikeGif
            // 
            this.pictureBoxLikeGif.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLikeGif.Image = global::Facebook_app.Properties.Resources.LikeGIF;
            this.pictureBoxLikeGif.Location = new System.Drawing.Point(296, -63);
            this.pictureBoxLikeGif.Name = "pictureBoxLikeGif";
            this.pictureBoxLikeGif.Size = new System.Drawing.Size(347, 352);
            this.pictureBoxLikeGif.TabIndex = 0;
            this.pictureBoxLikeGif.TabStop = false;
            // 
            // pictureBoxWelcomeBackground
            // 
            this.pictureBoxWelcomeBackground.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxWelcomeBackground.Image = global::Facebook_app.Properties.Resources.Welcome;
            this.pictureBoxWelcomeBackground.Location = new System.Drawing.Point(-2, -49);
            this.pictureBoxWelcomeBackground.Name = "pictureBoxWelcomeBackground";
            this.pictureBoxWelcomeBackground.Size = new System.Drawing.Size(354, 367);
            this.pictureBoxWelcomeBackground.TabIndex = 1;
            this.pictureBoxWelcomeBackground.TabStop = false;
            // 
            // buttonEnterToApp
            // 
            this.buttonEnterToApp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEnterToApp.Image = global::Facebook_app.Properties.Resources.EnterButton;
            this.buttonEnterToApp.Location = new System.Drawing.Point(205, 210);
            this.buttonEnterToApp.Name = "buttonEnterToApp";
            this.buttonEnterToApp.Size = new System.Drawing.Size(206, 54);
            this.buttonEnterToApp.TabIndex = 2;
            this.buttonEnterToApp.UseVisualStyleBackColor = false;
            this.buttonEnterToApp.Click += new System.EventHandler(this.buttonEnterToApp_Click);
            // 
            // BackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 289);
            this.Controls.Add(this.buttonEnterToApp);
            this.Controls.Add(this.pictureBoxWelcomeBackground);
            this.Controls.Add(this.pictureBoxLikeGif);
            this.Name = "BackgroundForm";
            this.Text = "BackgroundForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikeGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcomeBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLikeGif;
        private System.Windows.Forms.PictureBox pictureBoxWelcomeBackground;
        private System.Windows.Forms.Button buttonEnterToApp;
    }
}