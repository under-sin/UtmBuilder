﻿using UtmBuilder.Core;

namespace UtmBuilder.Tests.ValueObjects;

[TestClass]
public class CampaingTests
{
  [TestMethod]
  [DataRow("", "", "", true)]
  [DataRow("src", "", "", true)]
  [DataRow("src", "med", "", true)]
  [DataRow("src", "med", "nme", false)]
  public void TestCampaign(
    string source,
    string medium,
    string name,
    bool expectException)
  {
    if(expectException)
    {
      try
      {
        new Campaign(source, medium, name);
        Assert.Fail();
      }
      catch (Exception)
      {
        Assert.IsTrue(true);
      }
    }
    else
    {
      new Campaign(source, medium, name);
      Assert.IsTrue(true);
    }
  }
}
