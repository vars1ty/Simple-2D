using System.Collections;
using Cysharp.Text;
using Player;
using TMPro;
using UnityEngine;

namespace Misc
{
    [DisallowMultipleComponent]
    internal class GTimer : MonoBehaviour
    {
        #region Variables
        #region Editor
        [SerializeField, Tooltip("Header Text Component.")]
        private TextMeshProUGUI header;
        #endregion
        #region Class
        /// <summary>
        /// Constant strings.
        /// </summary>
        private const string header_timer = "Current Time: {0}\nBest: {1}",
            header_dead = "Game Over\nPress 'E' to restart";

        /// <summary>
        /// Wait for 1s in <see cref="OnCustomUpdate"/>.
        /// </summary>
        private readonly WaitForSeconds wait = new(1);

        /// <summary>
        /// Scores.
        /// </summary>
        public static int currentSeconds, bestScore;
        #endregion
        #endregion

        /// <summary>
        /// Starts <see cref="OnCustomUpdate"/>.
        /// </summary>
        private void Start() => StartCoroutine(OnCustomUpdate());

        /// <summary>
        /// Updates the value of <see cref="currentSeconds"/>.
        /// </summary>
        private IEnumerator OnCustomUpdate()
        {
            while (true)
            {
                if (GPlayer.IsPlayerAlive())
                {
                    currentSeconds++;
                    header.SetTextFormat(header_timer, currentSeconds, bestScore);
                }
                else header.text = header_dead;

                yield return wait;
            }
        }
    }
}