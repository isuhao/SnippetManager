# SnippetUtility\.FindDuplicateShortcuts\(IEnumerable\<Snippet>\) Method

**Containing Type**: [Pihrtsoft.Snippets](../../README.md)\.[SnippetUtility](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns enumerable groups of [Snippet](../../Snippet/README.md)s that have same shortcut\. [SnippetComparer.Shortcut](../../Comparers/SnippetComparer/Shortcut/README.md) is used to compare shortcuts\.

```csharp
public static IEnumerable<DuplicateShortcutInfo> FindDuplicateShortcuts(IEnumerable<Snippet> snippets)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| snippets | Collection of [Snippet](../../Snippet/README.md)s\. |

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.[DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md)>

Enumerable collection of [DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md) where each element contains shortcut and snippets with that shortcut\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippets** is `null`\.

