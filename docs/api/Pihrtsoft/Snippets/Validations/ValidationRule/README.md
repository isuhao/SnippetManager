<a name="_top"></a>

# ValidationRule Class

[Home](../../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Validations](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents the rule for a [Snippet](../../Snippet/README.md#_top) validation\. This class is abstract\.

```csharp
public abstract class ValidationRule
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; ValidationRule

### Derived

* Pihrtsoft\.Snippets\.Validations\.[AssemblyReferenceValidationRule](../AssemblyReferenceValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[CodeValidationRule](../CodeValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[DescriptionValidationRule](../DescriptionValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[FormatVersionValidationRule](../FormatVersionValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[LiteralValidationRule](../LiteralValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[NamespaceValidationRule](../NamespaceValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[ShortcutValidationRule](../ShortcutValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[SnippetTypeValidationRule](../SnippetTypeValidationRule/README.md#_top)
* Pihrtsoft\.Snippets\.Validations\.[TitleValidationRule](../TitleValidationRule/README.md#_top)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ValidationRule()](-ctor/README.md#_top) | Initializes a new instance of the [ValidationRule](#_top) class\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Validate(Snippet)](Validate/README.md#_top) | Validates a specified snippet and returns enumerable collection of [SnippetValidationResult](../SnippetValidationResult/README.md#_top)\. |

