namespace Utils
{
    /// <summary>
    /// Custom Math Utils which skips unnecessary casting of certain values, unlike Unity's own Mathf.
    /// </summary>
    public readonly struct MathUtils
    {
        public static float Clamp(float value, float min, float max) => value < min ? min : value > max ? max : value;
    }
}