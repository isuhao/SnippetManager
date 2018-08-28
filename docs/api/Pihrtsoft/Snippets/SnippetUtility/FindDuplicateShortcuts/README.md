<a name="_top"></a>

# SnippetUtility\.FindDuplicateShortcuts\(IEnumerable\<Snippet>\) Method

[Home](../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.[SnippetUtility](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns enumerable groups of [Snippet](../../Snippet/README.md#_top)s that have same shortcut\. [SnippetComparer.Shortcut](../../Comparers/SnippetComparer/Shortcut/README.md#_top) is used to compare shortcuts\.

```csharp
public static IEnumerable<DuplicateShortcutInfo> FindDuplicateShortcuts(IEnumerable<Snippet> snippets)
```

### Parameters

**snippets**

Collection of [Snippet](../../Snippet/README.md#_top)s\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.[DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md#_top)>

Enumerable collection of [DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md#_top) where each element contains shortcut and snippets with that shortcut\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippets** is `null`\.

