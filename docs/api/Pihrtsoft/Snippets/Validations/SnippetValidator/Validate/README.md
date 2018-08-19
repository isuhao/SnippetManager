<a name="_top"></a>

# SnippetValidator\.Validate Method

[Home](../../../../../README.md#_top)

**Containing Type**: [Pihrtsoft.Snippets.Validations](../../README.md#_top)\.[SnippetValidator](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Validate(Snippet)](#Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Snippet_) | Validates the specified [Snippet](../../../Snippet/README.md#_top) according the the code snippet schema\. |
| [Validate(SnippetValidationContext)](#Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Validations_SnippetValidationContext_) | Validates the specified [Snippet](../../../Snippet/README.md#_top) according the the code snippet schema\. |

## Validate\(Snippet\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Validates the specified [Snippet](../../../Snippet/README.md#_top) according the the code snippet schema\.

```csharp
public IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
```

### Parameters

#### snippet

A [Snippet](../../../Snippet/README.md#_top) that is being validated\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../../SnippetValidationResult/README.md#_top)>

A [SnippetValidationContext](../../SnippetValidationContext/README.md#_top) that stores data about the validation\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

## Validate\(SnippetValidationContext\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Validations_SnippetValidationContext_"></a>

### Summary

Validates the specified [Snippet](../../../Snippet/README.md#_top) according the the code snippet schema\.

```csharp
protected virtual IEnumerable<SnippetValidationResult> Validate(SnippetValidationContext context)
```

### Parameters

#### context

A [SnippetValidationContext](../../SnippetValidationContext/README.md#_top) that stores data about the validation\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../../SnippetValidationResult/README.md#_top)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**context** is `null`\.

