namespace MainMenu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelNumberOfLavel = new System.Windows.Forms.Label();
            this.pictureBoxButtonHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxEndGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonMainMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumberOfLavel
            // 
            this.labelNumberOfLavel.AutoSize = true;
            this.labelNumberOfLavel.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberOfLavel.Font = new System.Drawing.Font("Pacifico", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfLavel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumberOfLavel.Location = new System.Drawing.Point(862, -53);
            this.labelNumberOfLavel.Name = "labelNumberOfLavel";
            this.labelNumberOfLavel.Size = new System.Drawing.Size(0, 186);
            this.labelNumberOfLavel.TabIndex = 0;
            // 
            // pictureBoxButtonHome
            // 
            this.pictureBoxButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonHome.BackgroundImage = global::MainMenu.Properties.Resources.Home;
            this.pictureBoxButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonHome.ErrorImage = null;
            this.pictureBoxButtonHome.Location = new System.Drawing.Point(900, 948);
            this.pictureBoxButtonHome.Name = "pictureBoxButtonHome";
            this.pictureBoxButtonHome.Size = new System.Drawing.Size(97, 89);
            this.pictureBoxButtonHome.TabIndex = 1;
            this.pictureBoxButtonHome.TabStop = false;
            this.pictureBoxButtonHome.Tag = "";
            this.pictureBoxButtonHome.Click += new System.EventHandler(this.pictureBoxButtonHome_Click);
            // 
            // pictureBoxEndGame
            // 
            this.pictureBoxEndGame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEndGame.BackgroundImage = global::MainMenu.Properties.Resources.EndGame;
            this.pictureBoxEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEndGame.Location = new System.Drawing.Point(593, 236);
            this.pictureBoxEndGame.Name = "pictureBoxEndGame";
            this.pictureBoxEndGame.Size = new System.Drawing.Size(702, 501);
            this.pictureBoxEndGame.TabIndex = 2;
            this.pictureBoxEndGame.TabStop = false;
            this.pictureBoxEndGame.Visible = false;
            // 
            // pictureBoxButtonMainMenu
            // 
            this.pictureBoxButtonMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonMainMenu.BackgroundImage = global::MainMenu.Properties.Resources.main_menu;
            this.pictureBoxButtonMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonMainMenu.Location = new System.Drawing.Point(832, 560);
            this.pictureBoxButtonMainMenu.Name = "pictureBoxButtonMainMenu";
            this.pictureBoxButtonMainMenu.Size = new System.Drawing.Size(237, 106);
            this.pictureBoxButtonMainMenu.TabIndex = 3;
            this.pictureBoxButtonMainMenu.TabStop = false;
            this.pictureBoxButtonMainMenu.Visible = false;
            this.pictureBoxButtonMainMenu.Click += new System.EventHandler(this.pictureBoxButtonMainMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1958, 1062);
            this.Controls.Add(this.pictureBoxButtonMainMenu);
            this.Controls.Add(this.pictureBoxEndGame);
            this.Controls.Add(this.pictureBoxButtonHome);
            this.Controls.Add(this.labelNumberOfLavel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Лабіринт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfLavel;
        private System.Windows.Forms.PictureBox pictureBoxButtonHome;
        private System.Windows.Forms.PictureBox pictureBoxEndGame;
        private System.Windows.Forms.PictureBox pictureBoxButtonMainMenu;
    }
}