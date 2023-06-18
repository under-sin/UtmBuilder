using UtmBuilder.Core;

namespace UtmBuilder.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
  private const string InvalidUrl = "Banana";
  private const string ValidUrl = "https://balta.io";

  [TestMethod]
  [ExpectedException(typeof(InvalidUrlException))]
  public void ShouldReturnExeceptionWhenUrlIsInvalid()
  {
    new Url(InvalidUrl);
  }

  [TestMethod]
  public void ShouldReturnExeceptionWhenUrlIsValid()
  {
    new Url(ValidUrl);
    Assert.IsTrue(true);
  }

  [TestMethod]
  [DataRow(" ", true)]
  [DataRow("http", true)]
  [DataRow("banana", true)]
  [DataRow("https://balta.io", false)]
  public void TestUrl(
    string link,
    bool expectException
  )
  {
    if (expectException)
    {
      try
      {
        new Url(link);
        Assert.Fail();
      }
      catch (InvalidUrlException)
      {
        Assert.IsTrue(true);
      }
    }
    else
    {
      new Url(link);
      Assert.IsTrue(true);
    }
  }
}
