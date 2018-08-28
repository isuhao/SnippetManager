<a name="_top"></a>

# CodeValidationRule\.Validate\(Snippet\) Method

[Home](../../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.Validations\.[CodeValidationRule](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Validates a code of the specified [Snippet](../../../Snippet/README.md#_top)\.

```csharp
public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
```

### Parameters

**snippet**

A snippet to be validated\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../../SnippetValidationResult/README.md#_top)>

Enumerable collection of validation results\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

