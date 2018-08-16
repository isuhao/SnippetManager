# AssemblyReferenceValidationRule\.Validate\(Snippet\) Method

[Home](../../../../../README.md)

**Containing Type**: [Pihrtsoft.Snippets.Validations](../../README.md)\.[AssemblyReferenceValidationRule](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Validates assembly references of the specified [Snippet](../../../Snippet/README.md)\.

```csharp
public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
```

### Parameters

#### snippet

A snippet to be validated\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../../SnippetValidationResult/README.md)>

Enumerable collection of validation results\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

