using Player;
using UnityEngine;

public class SpikeDespawner : MonoBehaviour
{
    #region Variables
    /// <summary> Cached Transform for better performance. </summary>
    private Transform cachedTransform;

    /// <summary> Current local position of the transform. </summary>
    private Vector3 currentLocal;

    /// <summary> Has the gameObject been destroyed? </summary>
    private bool hasDestroyed;
    #endregion

    /// <summary> Caches the transform. </summary>
    private void Start() => cachedTransform = transform;

    /// <summary> Moves the spike downwards. </summary>
    private void Update()
    {
        if (cachedTransform.position is {y: <= -5.2f} && !hasDestroyed)
        {
            Destroy(gameObject);
            hasDestroyed = true;
            return;
        }

        if (hasDestroyed || !GPlayer.IsPlayerAlive()) return;
        currentLocal = cachedTransform.localPosition;
        cachedTransform.localPosition = Vector3.Lerp(currentLocal,
            new Vector3(currentLocal.x, currentLocal.y - .5f, currentLocal.z), Time.deltaTime * 5);
    }
}