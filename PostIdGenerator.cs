namespace BlueTinTonic
{
    public class PostIdGenerator
    {
        private static readonly Random _rand = new();
        private const byte _idLength = 10;
        private static readonly int[] _charRange = 
            [.. Enumerable.Range(48, 57), .. Enumerable.Range(65, 90), .. Enumerable.Range(97, 122)];

        public static string NewRandom()
        {
            return string.Join("", _rand.GetItems(_charRange, _idLength).Select(asciiCode => (char)asciiCode));
        }
    }
}
