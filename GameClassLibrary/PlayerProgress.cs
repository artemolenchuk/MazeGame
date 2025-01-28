using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameClassLibrary
{
    public class PlayerProgress
    {
        private const string ProgressFilePath = ("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\player_progress.txt");


        public int UnlockedLevels { get; private set; }

        public PlayerProgress()
        {
            UnlockedLevels = 1;
            LoadProgress();
        }

        public void UnlockLevel(int level)
        {
            if (level > UnlockedLevels)
            {
                UnlockedLevels = level;
                SaveProgress();
            }
        }

        private void SaveProgress()
        {
            File.WriteAllText(ProgressFilePath, UnlockedLevels.ToString());
        }

        private void LoadProgress()
        {
            if (File.Exists(ProgressFilePath))
            {
                string content = File.ReadAllText(ProgressFilePath);
                if (int.TryParse(content, out int unlockedLevels))
                {
                    UnlockedLevels = unlockedLevels;
                }
            }
        }

        public void ResetProgress()
        {
            UnlockedLevels = 1;
            SaveProgress();
        }
    }
}
