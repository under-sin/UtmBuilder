namespace UtmBuilder.Core;

public static class ListExttensions
{
  public static void AddIfNotNull(
    this List<string> list,
    string key,
    string? value)
  {
    if (!string.IsNullOrEmpty(value))
      list.Add($"{key}={value}");
  }
}
