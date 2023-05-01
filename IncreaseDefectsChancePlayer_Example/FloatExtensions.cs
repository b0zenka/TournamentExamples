namespace IncreaseDefectsChancePlayer_Example
{
    internal static class FloatExtensions
    {
        internal static float Clamp(this float value, float minValue, float maxValue)
        {
            return value < minValue ? minValue : value > maxValue ? maxValue : value;
        }

        internal static float Clamp01(this float value)
        {
            return Clamp(value, 0, 1f);
        }
    }
}
