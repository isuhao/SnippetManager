# SnippetSerializer\.DeserializeFiles\(String, SearchOption\) Method

**Containing Type**: [Pihrtsoft.Snippets](../../README.md)\.[SnippetSerializer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns enumerable collection of [SnippetFile](../../SnippetFile/README.md) deserialized from snippet files in a specified directory\.

```csharp
public static IEnumerable<SnippetFile> DeserializeFiles(string directoryPath, SearchOption searchOption = TopDirectoryOnly)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| directoryPath | The absolute or relative path to the directory to search\. |
| searchOption | A [SearchOption](https://docs.microsoft.com/en-us/dotnet/api/system.io.searchoption) value that specifies whether the search should include all subdirectories or only current directory\. |

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.[SnippetFile](../../SnippetFile/README.md)>

An enumerable collection [SnippetFile](../../SnippetFile/README.md) being deserialized\.