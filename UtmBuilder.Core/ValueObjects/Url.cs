namespace UtmBuilder.Core;

public class Url : ValueObjects
{

  /// <summary>
  /// Create a new URL
  /// </summary>
  /// <param name="address">Address of URL (Website link)</param>
  public Url(string address)
  {
    Address = address;
    InvalidUrlException.ThrowIfInvalid(Address);
  }
  /// <summary>
  /// Address of URL (Wrbsite link)
  /// </summary>
  public string Address { get; }
}
