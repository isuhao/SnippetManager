# SnippetSerializer\.Deserialize Method

**Containing Type**: [Pihrtsoft.Snippets](../../README.md)\.[SnippetSerializer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Deserialize(Stream)](#Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_IO_Stream_) | Returns enumerable collection of [Snippet](../../Snippet/README.md) contained by a specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Deserialize(String, SearchOption)](#Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_String_System_IO_SearchOption_) | Returns enumerable collection of [Snippet](../../Snippet/README.md) deserialized from snippet files in a specified directory\. |

## Deserialize\(Stream\)<a name="Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_IO_Stream_"></a>

### Summary

Returns enumerable collection of [Snippet](../../Snippet/README.md) contained by a specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public static IEnumerable<Snippet> Deserialize(Stream stream)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| stream | The [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream) that contains snippets to deserialize\. |

#### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.[Snippet](../../Snippet/README.md)>

Enumerable collection of snippets being deserialized\.

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**stream** is `null`\.

## Deserialize\(String, SearchOption\)<a name="Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_String_System_IO_SearchOption_"></a>

### Summary

Returns enumerable collection of [Snippet](../../Snippet/README.md) deserialized from snippet files in a specified directory\.

```csharp
public static IEnumerable<Snippet> Deserialize(string directoryPath, SearchOption searchOption = TopDirectoryOnly)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| directoryPath | The absolute or relative path to the directory to search\. |
| searchOption | A [SearchOption](https://docs.microsoft.com/en-us/dotnet/api/system.io.searchoption) value that specifies whether the search should include all subdirectories or only current directory\. |

#### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.[Snippet](../../Snippet/README.md)>

An enumerable collection [Snippet](../../Snippet/README.md) being deserialized\.