<a name="_top"></a>

# SnippetUtility Class

[Home](../../../README.md#_top) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Provides a set of static methods that are related to [Snippet](../Snippet/README.md#_top)\.

```csharp
public static class SnippetUtility
```

## Methods

| Method | Summary |
| ------ | ------- |
| [FindDuplicateShortcuts(IEnumerable\<Snippet>)](FindDuplicateShortcuts/README.md#_top) | Returns enumerable groups of [Snippet](../Snippet/README.md#_top)s that have same shortcut\. [SnippetComparer.Shortcut](../Comparers/SnippetComparer/Shortcut/README.md#_top) is used to compare shortcuts\. |
| [RemoveUnusedLiterals(Snippet)](RemoveUnusedLiterals/README.md#_top) | Removes all literals that do not have corresponding placeholder \(placeholder with same identifier\)\. |
| [RemoveUnusedPlaceholders(Snippet)](RemoveUnusedPlaceholders/README.md#_top) | Removes all placeholders that do not have corresponding literal \(literal with same identifier\)\. |

