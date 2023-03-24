using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private const string RESULT = "https://balta.io/?utm_source=src&utm_medium=medium&utm_campaign=name&utm_id=id&utm_term=term&utm_content=content";
    private readonly Url _url = new("https://balta.io/");
    private readonly Campaign _campaign = new(
        "src",
        "medium",
        "name",
        "id",
        "term",
        "content"
    );

    [TestMethod]
    public void should_return_url_from_utm()
    {
        var utm = new Utm(_url, _campaign);

        Assert.AreEqual(RESULT, utm.ToString());
        Assert.AreEqual(RESULT, (string)utm);
    }

    [TestMethod]
    public void should_return_utm_from_url()
    {
        Utm utm = RESULT;

        Assert.AreEqual("src", utm.Campaign.Source);
        Assert.AreEqual("medium", utm.Campaign.Medium);
        Assert.AreEqual("name", utm.Campaign.Name);
        Assert.AreEqual("id", utm.Campaign.Id);
        Assert.AreEqual("term", utm.Campaign.Term);
        Assert.AreEqual("content", utm.Campaign.Content);
    }
}
