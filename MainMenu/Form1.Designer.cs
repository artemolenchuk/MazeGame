namespace MainMenu
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
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.pictureBoxLevelOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxLevelTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLevelThree = new System.Windows.Forms.PictureBox();
            this.buttonResetProgres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelThree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackToMenu.BackgroundImage = global::MainMenu.Properties.Resources.main_menu;
            this.buttonBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMenu.Location = new System.Drawing.Point(1612, 901);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(243, 95);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // pictureBoxLevelOne
            // 
            this.pictureBoxLevelOne.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLevelOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLevelOne.BackgroundImage")));
            this.pictureBoxLevelOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLevelOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLevelOne.Location = new System.Drawing.Point(126, 106);
            this.pictureBoxLevelOne.Name = "pictureBoxLevelOne";
            this.pictureBoxLevelOne.Size = new System.Drawing.Size(253, 214);
            this.pictureBoxLevelOne.TabIndex = 1;
            this.pictureBoxLevelOne.TabStop = false;
            this.pictureBoxLevelOne.Click += new System.EventHandler(this.pictureBoxLevelOne_Click);
            // 
            // pictureBoxLevelTwo
            // 
            this.pictureBoxLevelTwo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLevelTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLevelTwo.BackgroundImage")));
            this.pictureBoxLevelTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLevelTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLevelTwo.Location = new System.Drawing.Point(385, 106);
            this.pictureBoxLevelTwo.Name = "pictureBoxLevelTwo";
            this.pictureBoxLevelTwo.Size = new System.Drawing.Size(253, 214);
            this.pictureBoxLevelTwo.TabIndex = 2;
            this.pictureBoxLevelTwo.TabStop = false;
            this.pictureBoxLevelTwo.Click += new System.EventHandler(this.pictureBoxLevelTwo_Click);
            // 
            // pictureBoxLevelThree
            // 
            this.pictureBoxLevelThree.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLevelThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLevelThree.BackgroundImage")));
            this.pictureBoxLevelThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLevelThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLevelThree.Location = new System.Drawing.Point(644, 106);
            this.pictureBoxLevelThree.Name = "pictureBoxLevelThree";
            this.pictureBoxLevelThree.Size = new System.Drawing.Size(253, 214);
            this.pictureBoxLevelThree.TabIndex = 3;
            this.pictureBoxLevelThree.TabStop = false;
            this.pictureBoxLevelThree.Click += new System.EventHandler(this.pictureBoxLevelThree_Click);
            // 
            // buttonResetProgres
            // 
            this.buttonResetProgres.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetProgres.BackgroundImage = global::MainMenu.Properties.Resources.ResetProgres;
            this.buttonResetProgres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResetProgres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetProgres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetProgres.Location = new System.Drawing.Point(1298, 901);
            this.buttonResetProgres.Name = "buttonResetProgres";
            this.buttonResetProgres.Size = new System.Drawing.Size(243, 95);
            this.buttonResetProgres.TabIndex = 4;
            this.buttonResetProgres.UseVisualStyleBackColor = false;
            this.buttonResetProgres.Click += new System.EventHandler(this.buttonResetProgres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainMenu.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1031);
            this.Controls.Add(this.buttonResetProgres);
            this.Controls.Add(this.pictureBoxLevelThree);
            this.Controls.Add(this.pictureBoxLevelTwo);
            this.Controls.Add(this.pictureBoxLevelOne);
            this.Controls.Add(this.buttonBackToMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Лабіринт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.PictureBox pictureBoxLevelOne;
        private System.Windows.Forms.PictureBox pictureBoxLevelTwo;
        private System.Windows.Forms.PictureBox pictureBoxLevelThree;
        private System.Windows.Forms.Button buttonResetProgres;
    }
}