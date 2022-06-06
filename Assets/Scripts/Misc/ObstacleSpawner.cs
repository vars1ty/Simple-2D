using System.Collections;
using Player;
using UnityEngine;

[DisallowMultipleComponent]
internal class ObstacleSpawner : MonoBehaviour
{
    #region Variables
    #region Editor
    [SerializeField, Tooltip("Obstacle Sprite GameObject to be spawned.")]
    private GameObject sprite;

    [SerializeField, Tooltip("Parent Transform for all obstacles.")]
    private Transform holder;
    #endregion
    #region Class
    /// <summary> Wait time between spawning obstacles. </summary>
    private readonly WaitForSeconds wait = new(.5f);
    #endregion
    #endregion

    /// <summary> Called whenever the script has been initialized. </summary>
    private void Start() => StartCoroutine(OnLateSpawn());

    /// <summary> Called every 500ms to spawn a new obstacle. </summary>
    private IEnumerator OnLateSpawn()
    {
        while (true)
        {
            if (GPlayer.IsPlayerAlive())
            {
                var t = Instantiate(sprite, holder).transform;
                t.localPosition = new Vector2(Random.Range(-10, 10), 0);
            }

            yield return wait;
        }
    }
}