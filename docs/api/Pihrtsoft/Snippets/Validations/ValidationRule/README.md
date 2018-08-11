# ValidationRule Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Validations](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents the rule for a [Snippet](../../Snippet/README.md) validation\. This class is abstract\.

```csharp
public abstract class ValidationRule
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; ValidationRule

### Derived

* Pihrtsoft\.Snippets\.Validations\.[AssemblyReferenceValidationRule](../AssemblyReferenceValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[CodeValidationRule](../CodeValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[DescriptionValidationRule](../DescriptionValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[FormatVersionValidationRule](../FormatVersionValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[LiteralValidationRule](../LiteralValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[NamespaceValidationRule](../NamespaceValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[ShortcutValidationRule](../ShortcutValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[SnippetTypeValidationRule](../SnippetTypeValidationRule/README.md)
* Pihrtsoft\.Snippets\.Validations\.[TitleValidationRule](../TitleValidationRule/README.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ValidationRule()](-ctor/README.md) | Initializes a new instance of the [ValidationRule](./README.md) class\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) | |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) | |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) | |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) | |
| [Validate(Snippet)](Validate/README.md) | Validates a specified snippet and returns enumerable collection of [SnippetValidationResult](../SnippetValidationResult/README.md)\. |

