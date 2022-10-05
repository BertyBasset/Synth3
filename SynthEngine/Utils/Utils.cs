
namespace Synth.Utils {
    internal class Misc {
        // Return max or min value if value exceeds min or max constraint

        // ** LEMONS Redo this with attributes on the properties
        internal static T Constrain<T>(T value, T min, T max) where T : IComparable<T> {
            if (value.CompareTo(min) < 0)
                return min;
            else if (value.CompareTo(max) > 0)
                return max;
            else
                return value;
        }
    }
}
