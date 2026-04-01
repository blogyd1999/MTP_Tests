namespace MtpTests.Utils;

public class StringHelper
{
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        var reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
