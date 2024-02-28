namespace IMS.Framework
{
    public class Validation
    {
        public static bool IsStringInvalid(string value) // ?
        {
            return !string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value);
        }

        public static bool IsIntValid(string value)
        {
            return Int32.TryParse(value, out _);
        }

        public static bool IsFloatValid(string value)
        {
            return float.TryParse(value, out _);
        }
    }
}
