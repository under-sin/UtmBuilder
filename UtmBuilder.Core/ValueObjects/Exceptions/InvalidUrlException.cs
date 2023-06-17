using System.Text.RegularExpressions;

namespace UtmBuilder.Core;

public partial class InvalidUrlException : Exception
{
  private const string DefaultErrorMessage = "Invalid URL";

  public InvalidUrlException(string message = DefaultErrorMessage) : base(message) { }

  public static void ThrowIfInvalid(
    string address,
    string message = DefaultErrorMessage)
  {
    if (string.IsNullOrEmpty(address))
      throw new InvalidUrlException(message);

    if (UrlRegex().IsMatch(address))
      throw new InvalidUrlException();
  }

  [GeneratedRegex("/^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$/")]
  private static partial Regex UrlRegex();
}
