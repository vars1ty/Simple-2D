using System.Collections;
using Player;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    #region Variables
    [SerializeField, Tooltip("Obstacle Sprite GameObject to be spawned.")]
    private GameObject sprite;

    [SerializeField, Tooltip("Parent Transform for all obstacles.")]
    private Transform holder;
    #endregion

    /// <summary> Called whenever the script has been intiailized. </summary>
    private void Start() => StartCoroutine(OnLateSpawn());

    /// <summary> Called every 500ms to spawn a new obstacle. </summary>
    private IEnumerator OnLateSpawn()
    {
        while (GPlayer.IsPlayerAlive())
        {
            var t = Instantiate(sprite, holder).transform;
            t.localPosition = new Vector2(Random.Range(-10, 10), 0);
            yield return new WaitForSeconds(.5f);
        }
    }
}