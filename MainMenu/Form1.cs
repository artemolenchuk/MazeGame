using GameClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        private PlayerProgress playerProgress;

        public Form1()
        {
            InitializeComponent();
            playerProgress = new PlayerProgress();
            UpdateLevelButtons();
        }

        private void UpdateLevelButtons()
        {
            pictureBoxLevelOne.Enabled = playerProgress.UnlockedLevels >= 1;
            pictureBoxLevelTwo.Enabled = playerProgress.UnlockedLevels >= 2;
            pictureBoxLevelThree.Enabled = playerProgress.UnlockedLevels >= 3;

            pictureBoxLevelOne.Visible = true;
            pictureBoxLevelTwo.Visible = playerProgress.UnlockedLevels >= 2;
            pictureBoxLevelThree.Visible = playerProgress.UnlockedLevels >= 3;
        }

        private void buttonResetProgres_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете скинути прогрес?", "Підтвердження", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                playerProgress.ResetProgress();
                UpdateLevelButtons();
            }
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
            Form0 form0 = new Form0();
            form0.FormClosed += (s, args) => this.Close();
            form0.Show();
            this.Hide();
        }

        private void pictureBoxLevelOne_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void pictureBoxLevelTwo_Click(object sender, EventArgs e)
        {
            if (playerProgress.UnlockedLevels >= 2)
            {
                Form2 form2 = new Form2();
                form2.InitializeLevel2();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();
                this.Hide();
            }
        }

        private void pictureBoxLevelThree_Click(object sender, EventArgs e)
        {
            if (playerProgress.UnlockedLevels >= 3)
            {
                Form2 form2 = new Form2();
                form2.InitializeLevel3();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();
                this.Hide();
            }
        }


    }
}
