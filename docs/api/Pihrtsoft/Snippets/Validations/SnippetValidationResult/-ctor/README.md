# SnippetValidationResult Constructors

[Home](../../../../../README.md#_top)

**Containing Type**: [Pihrtsoft.Snippets.Validations](../../README.md#_top)\.[SnippetValidationResult](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [SnippetValidationResult(Snippet, String, String, ResultImportance)](#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_) | Initializes a new instance of the [SnippetValidationResult](../README.md#_top) class using the specified snippet, code, description a and importance\. |
| [SnippetValidationResult(Snippet, String, String, ResultImportance, Object)](#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_System_Object_) | Initializes a new instance of the [SnippetValidationResult](../README.md#_top) class using the specified snippet, code, description, importance and content\. |

## SnippetValidationResult\(Snippet, String, String, ResultImportance\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_"></a>

### Summary

Initializes a new instance of the [SnippetValidationResult](../README.md#_top) class using the specified snippet, code, description a and importance\.

```csharp
public SnippetValidationResult(Snippet snippet, string code, string description, ResultImportance importance)
```

### Parameters

#### snippet

A snippet\.

#### code

Alphanumeric code the identifies the result\.

#### description

Result description\.

#### importance

Result importance\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

## SnippetValidationResult\(Snippet, String, String, ResultImportance, Object\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_System_Object_"></a>

### Summary

Initializes a new instance of the [SnippetValidationResult](../README.md#_top) class using the specified snippet, code, description, importance and content\.

```csharp
public SnippetValidationResult(Snippet snippet, string code, string description, ResultImportance importance, object content)
```

### Parameters

#### snippet

A snippet\.

#### code

Alphanumeric code the identifies the result\.

#### description

Result description\.

#### importance

Result importance\.

#### content

Additional result content\. The value can be `null`\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

