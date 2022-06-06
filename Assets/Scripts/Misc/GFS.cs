using System.IO;
using Cysharp.Text;
using UnityEngine;

namespace Misc
{
    /// <summary>
    /// Game File System.
    /// </summary>
    internal readonly struct GFS
    {
        #region Variables
        /// <summary>
        /// Score file name.
        /// </summary>
        private const string scoreName = "/score.dat";
        #endregion

        /// <summary>
        /// Saves the score.
        /// </summary>
        public static void SaveScore()
        {
            var path = ZString.Concat(Application.persistentDataPath, scoreName);
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                File.WriteAllText(path, "0");
            }

            if (GTimer.currentSeconds > int.Parse(File.ReadAllText(path)))
                File.WriteAllText(path, GTimer.currentSeconds.ToString());
        }

        /// <summary>
        /// Get the saved score.
        /// </summary>
        /// <returns></returns>
        public static int GetSavedScore()
        {
            var path = ZString.Concat(Application.persistentDataPath, scoreName);
            return File.Exists(path) ? int.Parse(File.ReadAllText(path)) : 0;
        }
    }
}