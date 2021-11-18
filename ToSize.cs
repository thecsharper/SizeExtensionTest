namespace SizeExtensionTest
{
    public static class ToSize
    {
        public static string ToNumSize<T>(this T value) where T : INumber<T>
        {
            return value switch
            {
                <= 1024 => $"{value} B",
                <= 1024 * 1024 => $"{value / Sizes<T>.KB:F2} kB",
                _ => ""
            };
        }
    }

    public class Sizes<T> where T : INumber<T>
    {
        public static T KB
        {
            get => (T)(object)100; // random value
            set { }
        }
    }
}


