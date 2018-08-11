# SnippetCode\.RenamePlaceholder\(String, String\) Method

**Namespace**: [Pihrtsoft.Snippets](../../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns a new string in which all occurrences of a specified identifier in the current instance are replaced with another specified identifier\.

```csharp
public string RenamePlaceholder(string oldIdentifier, string newIdentifier)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| oldIdentifier | The identifier to be replaced\. |
| newIdentifier | The idenfier to replace all occurrences of **oldIdentifier**\. |

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A string where all occurrences of **oldIdentifier** are replaced with **newIdentifier**\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**oldIdentifier** is `null`\.

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**oldIdentifier** is the empty string or **newIdentifier** is invalid\.

