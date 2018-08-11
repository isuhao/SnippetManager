# SaveSettings Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Specifies a set of options that enables to modify code snippet serialization process\.

```csharp
public sealed class SaveSettings
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SaveSettings

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SaveSettings()](-ctor/README.md) | Initializes a new instance of the [SaveSettings](./README.md) class\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [Comment](Comment/README.md) | Gets or sets an XML comment that will be added to the snippet file\. |
| [IndentChars](IndentChars/README.md) | Gets or sets the string to use when indenting\. |
| [OmitCodeSnippetsElement](OmitCodeSnippetsElement/README.md) | Gets or sets a value indicating whether to write 'CodeSnippets' XML element\. This option is relevant only if a single snippet is saved to a file\. |
| [OmitDefaultDelimiter](OmitDefaultDelimiter/README.md) | Gets or sets a value indicating whether Delimiter attribute with value equal to [Snippet.DefaultDelimiter](../Snippet/DefaultDelimiter/README.md) will be omitted\. Default value is `true`\. |
| [OmitXmlDeclaration](OmitXmlDeclaration/README.md) | Gets or sets a value indicating whether to write an XML declaration\. |
| [SetDefaultFormat](SetDefaultFormat/README.md) | Gets or sets a value indicating whether default format version set is when [Snippet.FormatVersion](../Snippet/FormatVersion/README.md) value is `null`\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) | |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) | |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) | |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) | |

