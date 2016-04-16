using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    static class Viktorin
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 0;
        static public int musicDuration = 0;
        static public bool randomStart = false;
        static public string lastFolser = "";
        static public bool allDir = false;

        static public void ReadMus()
        {
            string[] mus_list = Directory.GetFiles(lastFolser, "*.mp3", allDir ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(mus_list);
        }

        static string regKeyName = "Software\\MyCompani\\GuessMelody";

        public static void WriteParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolser", lastFolser);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDir",allDir);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk != null)
                {

                    lastFolser = (string)rk.GetValue("LastFolser");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    musicDuration= (int)rk.GetValue("MusicDuration");
                    allDir= Convert.ToBoolean(rk.GetValue("AllDir", false));
                }
                
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

    }
}
