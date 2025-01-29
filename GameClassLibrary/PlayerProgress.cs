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
        private const int InitialLevel = 1;
        private readonly string progressFilePath;

        public int UnlockedLevels { get; private set; }

        public PlayerProgress()
        {
            progressFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "player_progress.txt");
            UnlockedLevels = InitialLevel;
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
            try
            {
                File.WriteAllText(progressFilePath, UnlockedLevels.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving progress: {ex.Message}");
            }
        }

        private void LoadProgress()
        {
            try
            {
                if (File.Exists(progressFilePath))
                {
                    string content = File.ReadAllText(progressFilePath);
                    if (int.TryParse(content, out int unlockedLevels))
                    {
                        UnlockedLevels = unlockedLevels;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading progress: {ex.Message}");
            }
        }

        public void ResetProgress()
        {
            UnlockedLevels = InitialLevel;
            SaveProgress();
        }
    }
}
