using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form0()
        {
            InitializeComponent();


            pictureBoxMusicToggle.Image = musicOnImage;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
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

        private Image musicOnImage = Image.FromFile("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\sound_on.png");
        private Image musicOffImage = Image.FromFile("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\sound_off.png");

        private void pictureBoxMusicToggle_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();

            Sound.ToggleMusic();

            if (Sound.IsMusicEnabled)
            {
                pictureBoxMusicToggle.Image = musicOnImage;
            }
            else
            {
                pictureBoxMusicToggle.Image = musicOffImage;
            }

        }
    }
}
