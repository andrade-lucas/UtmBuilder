using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    const string INVALID_URL = "banana";
    const string VALID_URL = "https://balta.io";
    
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void should_return_exception_when_url_is_invalid()
    {
        new Url(INVALID_URL);
    }

    [TestMethod]
    public void should_not_return_exception_when_url_is_invalid()
    {
        var url = new Url(VALID_URL);

        Assert.AreEqual(VALID_URL, url.Address);
    }
}
