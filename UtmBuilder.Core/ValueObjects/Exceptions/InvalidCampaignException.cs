namespace UtmBuilder.Core;

public class InvalidCampaignException : Exception
{
  private const string DefaultErrorMessage = "Invalid URL parameters";

  public InvalidCampaignException(string message) : base(message) { }

  public static void ThrowIfNull(
    string? item,
    string message = DefaultErrorMessage)
  {
    if (string.IsNullOrEmpty(item))
      throw new InvalidCampaignException(message);
  }
}
