using Xunit;
using MtpTests.Utils;

public class StringHelperTests
{
    [Fact]
    public void IsPalindrome_ShouldReturnTrue_ForValidPalindrome()
    {
        var helper = new StringHelper();
        Assert.True(helper.IsPalindrome("madam"));
    }

    [Fact]
    public void IsPalindrome_ShouldReturnFalse_ForNonPalindrome()
    {
        var helper = new StringHelper();
        Assert.False(helper.IsPalindrome("hello"));
    }

    [Fact]
    public void IsPalindrome_ShouldReturnFalse_ForNull()
    {
        var helper = new StringHelper();
        Assert.False(helper.IsPalindrome(null));
    }
}