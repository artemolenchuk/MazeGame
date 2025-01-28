using NAudio.Wave;

namespace GameClassLibrary
{
    public static class Sound
    {
        public static bool IsMusicEnabled { get; private set; } = true;

        private static IWavePlayer menuPlayer;
        private static AudioFileReader menuAudio;

        private static IWavePlayer levelPlayer;
        private static AudioFileReader levelAudio;

        private static IWavePlayer finishPlayer;
        private static AudioFileReader finishAudio;

        private static IWavePlayer clickPlayer;
        private static AudioFileReader clickAudio;

        static Sound()
        {
            menuPlayer = new WaveOutEvent();
            menuAudio = new AudioFileReader("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\main_menu_theme.wav");
            menuPlayer.Init(menuAudio);

            levelPlayer = new WaveOutEvent();
            levelAudio = new AudioFileReader("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\level_theme.wav");
            levelPlayer.Init(levelAudio);

            finishPlayer = new WaveOutEvent();
            finishAudio = new AudioFileReader("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\finish_sound.wav");
            finishPlayer.Init(finishAudio);

            clickPlayer = new WaveOutEvent();
            clickAudio = new AudioFileReader("E:\\univer\\vs\\Курсовий проект 1\\Maze Game\\MainMenu\\Resources\\click_sound.wav");
            clickPlayer.Init(clickAudio);
        }

        public static void PlayMenuTheme()
        {
            menuPlayer.Play();
        }

        public static void PlayLevelTheme()
        {
            levelPlayer.Play();
        }

        public static void PlayFinishSound()
        {
            finishPlayer.Play();
        }

        public static void PlayClickSound()
        {
            clickPlayer.Play();
        }

        public static void StopMenuTheme()
        {
            menuPlayer.Stop();
            menuAudio.Position = 0;
        }

        public static void StopLevelTheme()
        {
            levelPlayer.Stop();
            levelAudio.Position = 0;
        }

        public static void StopFinishSound()
        {
            finishPlayer.Stop();
            finishAudio.Position = 0;
        }

        public static void StopClickSound()
        {
            clickPlayer.Stop();
            clickAudio.Position = 0;
        }

        public static void ToggleMusic()
        {
            IsMusicEnabled = !IsMusicEnabled;

            if (IsMusicEnabled)
            {
                PlayMenuTheme();
            }
            else
            {
                StopMenuTheme();
                StopLevelTheme();
            }
        }

    }
}
