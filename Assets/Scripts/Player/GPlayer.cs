using Misc;
using UnityEngine;

namespace Player
{
    [DisallowMultipleComponent, AddComponentMenu("Simple-2D/Player/GPlayer")]
    internal class GPlayer : MonoBehaviour
    {
        #region Variables
        #region Class
        /// <summary>
        /// Is the player alive?
        /// </summary>
        private static bool isPlayerAlive = true;

        /// <summary>
        /// Player movement speed.
        /// </summary>
        private const float speed = .004f;

        /// <summary>
        /// This transform but cached so we can skip C# -> C++ -> C# calls.
        /// </summary>
        private Transform cachedTransform;

        /// <summary>
        /// Player instance.
        /// </summary>
        private static GPlayer instance;

        /// <summary>
        /// Player position.
        /// </summary>
        private Vector3 position;
        #endregion
        #endregion

        /// <summary>
        /// Cache the <c>transform</c> and <see cref="instance"/>.
        /// </summary>
        private void Start()
        {
            cachedTransform = transform;
            instance = this;
        }

        /// <summary>
        /// Respawns the player.
        /// </summary>
        private void RespawnPlayer()
        {
            GTimer.currentSeconds = 0;
            GTimer.bestScore = GFS.GetSavedScore();
            isPlayerAlive = true;
            instance.cachedTransform.position = new Vector3(0, -2, 0);
        }

        /// <summary>
        /// Kills the player.
        /// </summary>
        private void KillPlayer()
        {
            isPlayerAlive = false;
            GFS.SaveScore();
        }

        /// <summary>
        /// Is the player alive?
        /// </summary>
        /// <returns></returns>
        public static bool IsPlayerAlive() => isPlayerAlive;

        /// <summary>
        /// Listens for player input and moves the player accordingly.
        /// </summary>
        private void LateUpdate()
        {
            if (!isPlayerAlive)
            {
                if (Input.GetKeyDown(KeyCode.E)) RespawnPlayer();
                return;
            }

            OnHandleInput();
            OnCheckCanvas();
        }

        /// <summary>
        /// Handles the player input.
        /// </summary>
        private void OnHandleInput()
        {
            position = cachedTransform.position;
            if (Input.GetKey(KeyCode.W)) position.y += speed;
            if (Input.GetKey(KeyCode.S)) position.y -= speed;
            if (Input.GetKey(KeyCode.A)) position.x -= speed;
            if (Input.GetKey(KeyCode.D)) position.x += speed;
            cachedTransform.position = position;
        }

        /// <summary>
        /// Called whenever the player collides with something.
        /// </summary>
        private void OnCollisionEnter2D() => KillPlayer();

        /// <summary>
        /// Makes sure the player is always in view and never outside the canvas.
        /// </summary>
        private void OnCheckCanvas()
        {
            if (position is {x: >= 8.1f or <= -8.1f}) position.x = Mathf.Clamp(position.x, -8.1f, 8.1f);
            if (position is {y: >= 4.8f or <= -4.8f}) position.y = Mathf.Clamp(position.y, -4.8f, 4.8f);
        }
    }
}