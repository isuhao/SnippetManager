<a name="_top"></a>

# SnippetSerializer Class

[Home](../../../README.md#_top) &#x2022; [Fields](#fields) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Manages code snippet serialization and deserialization\.

```csharp
public static class SnippetSerializer
```

## Fields

| Field | Summary |
| ----- | ------- |
| [DefaultNamespace](DefaultNamespace/README.md#_top) | Represents code snippet default xml namespace\. This field is a constant\. \(Value = "http://schemas\.microsoft\.com/VisualStudio/2005/CodeSnippet"\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [CreateXml(IEnumerable\<Snippet>)](CreateXml/README.md#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to text\. |
| [CreateXml(IEnumerable\<Snippet>, SaveSettings)](CreateXml/README.md#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to text, optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [CreateXml(Snippet)](CreateXml/README.md#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_) | Serializes a specified [Snippet](../Snippet/README.md#_top) to xml text\. |
| [CreateXml(Snippet, SaveSettings)](CreateXml/README.md#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes a specified [Snippet](../Snippet/README.md#_top) to xml text, optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [Deserialize(Stream)](Deserialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_IO_Stream_) | Returns enumerable collection of [Snippet](../Snippet/README.md#_top) contained by a specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Deserialize(String, SearchOption)](Deserialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Deserialize_System_String_System_IO_SearchOption_) | Returns enumerable collection of [Snippet](../Snippet/README.md#_top) deserialized from snippet files in a specified directory\. |
| [DeserializeFile(String)](DeserializeFile/README.md#_top) | Returns enumerable collection of [Snippet](../Snippet/README.md#_top) deserialized from a specified snippet file\. |
| [DeserializeFiles(String, SearchOption)](DeserializeFiles/README.md#_top) | Returns enumerable collection of [SnippetFile](../SnippetFile/README.md#_top) deserialized from snippet files in a specified directory\. |
| [Serialize(SnippetFile)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_) | Serializes the specified [SnippetFile](../SnippetFile/README.md#_top) to the file\. |
| [Serialize(SnippetFile, SaveSettings)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [SnippetFile](../SnippetFile/README.md#_top) to the file, optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(Stream, IEnumerable\<Snippet>)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, IEnumerable\<Snippet>, SaveSettings)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(Stream, Snippet)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, Snippet, SaveSettings)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(String, IEnumerable\<Snippet>)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to the specified snippet file\. |
| [Serialize(String, IEnumerable\<Snippet>, SaveSettings)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../Snippet/README.md#_top) to the specified snippet file, optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(String, Snippet)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../Snippet/README.md#_top) the the specified snippet file\. |
| [Serialize(String, Snippet, SaveSettings)](Serialize/README.md#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../Snippet/README.md#_top) the the specified snippet file, optionally using [SaveSettings](../SaveSettings/README.md#_top) to modify serialization process\. |

