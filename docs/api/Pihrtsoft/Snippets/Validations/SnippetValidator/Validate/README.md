# SnippetValidator\.Validate Method

**Namespace**: [Pihrtsoft.Snippets.Validations](../../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Validate(Snippet)](#Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Snippet_) | Validates the specified [Snippet](../../../Snippet/README.md) according the the code snippet schema\. |
| [Validate(SnippetValidationContext)](#Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Validations_SnippetValidationContext_) | Validates the specified [Snippet](../../../Snippet/README.md) according the the code snippet schema\. |

## Validate\(Snippet\)<a name="Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Validates the specified [Snippet](../../../Snippet/README.md) according the the code snippet schema\.

```csharp
public IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| snippet | A [Snippet](../../../Snippet/README.md) that is being validated\. |

#### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SnippetValidationResult](../../SnippetValidationResult/README.md)>

A [SnippetValidationContext](../../SnippetValidationContext/README.md) that stores data about the validation\.

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

## Validate\(SnippetValidationContext\)<a name="Pihrtsoft_Snippets_Validations_SnippetValidator_Validate_Pihrtsoft_Snippets_Validations_SnippetValidationContext_"></a>

### Summary

Validates the specified [Snippet](../../../Snippet/README.md) according the the code snippet schema\.

```csharp
protected virtual IEnumerable<SnippetValidationResult> Validate(SnippetValidationContext context)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| context | A [SnippetValidationContext](../../SnippetValidationContext/README.md) that stores data about the validation\. |

#### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SnippetValidationResult](../../SnippetValidationResult/README.md)>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**context** is `null`\.

