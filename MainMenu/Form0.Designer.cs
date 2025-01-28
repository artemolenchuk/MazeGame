namespace MainMenu
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxMusicToggle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::MainMenu.Properties.Resources.Без_имени_2;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Location = new System.Drawing.Point(1002, 842);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(327, 129);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::MainMenu.Properties.Resources.Button_exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(632, 842);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(327, 129);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxMusicToggle
            // 
            this.pictureBoxMusicToggle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusicToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMusicToggle.Image = global::MainMenu.Properties.Resources.sound_on;
            this.pictureBoxMusicToggle.Location = new System.Drawing.Point(70, 893);
            this.pictureBoxMusicToggle.Name = "pictureBoxMusicToggle";
            this.pictureBoxMusicToggle.Size = new System.Drawing.Size(80, 78);
            this.pictureBoxMusicToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMusicToggle.TabIndex = 2;
            this.pictureBoxMusicToggle.TabStop = false;
            this.pictureBoxMusicToggle.Click += new System.EventHandler(this.pictureBoxMusicToggle_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1873, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxMusicToggle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form0";
            this.Text = "Лабіринт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicToggle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxMusicToggle;
    }
}

