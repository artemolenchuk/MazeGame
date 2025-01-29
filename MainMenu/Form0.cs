using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameClassLibrary;
using NAudio.Wave;

namespace MainMenu
{
    public partial class Form0 : Form
    {
        private readonly Image musicOnImage;
        private readonly Image musicOffImage;

        public Form0()
        {
            InitializeComponent();

            musicOnImage = LoadImage("sound_on.png");
            musicOffImage = LoadImage("sound_off.png");

            UpdateMusicIcon();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            Sound.PlayMenuTheme();
        }

        private void pictureBoxMusicToggle_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            Sound.ToggleMusic();
            UpdateMusicIcon();
        }

        private void PlayClickSound()
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
        }

        private void UpdateMusicIcon()
        {
            pictureBoxMusicToggle.Image = Sound.IsMusicEnabled ? musicOnImage : musicOffImage;
        }

        private Image LoadImage(string fileName)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Resources", fileName);
                return File.Exists(path) ? Image.FromFile(path) : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image {fileName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
