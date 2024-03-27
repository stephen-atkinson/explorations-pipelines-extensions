namespace Explorations.Pipelines.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? source) => source ?? Array.Empty<T>();
}