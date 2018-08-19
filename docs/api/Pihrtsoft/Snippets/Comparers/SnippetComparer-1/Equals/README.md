<a name="_top"></a>

# SnippetComparer\.Equals Method

[Home](../../../../../README.md#_top)

**Containing Type**: [Pihrtsoft.Snippets.Comparers](../../README.md#_top)\.[SnippetComparer\<T>](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Equals(Object, Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Overrides [SnippetComparer.Equals](../../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_)\) |
| [Equals(Snippet, Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Indicates whether two snippets are equal\. \(Overrides [SnippetComparer.Equals](../../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_)\) |

## Equals\(Object, Object\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_System_Object_System_Object_"></a>

### Summary

Indicates whether two objects are equal\.

```csharp
public override bool Equals(object x, object y)
```

### Parameters

#### x

An object to compare to **y**\.

#### y

An object to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are both the same type of object and those objects are equal; otherwise, `false`\.

## Equals\(Snippet, Snippet\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Indicates whether two snippets are equal\.

```csharp
public override bool Equals(Snippet x, Snippet y)
```

### Parameters

#### x

A [Snippet](../../../Snippet/README.md#_top) to compare to **y**\.

#### y

A [Snippet](../../../Snippet/README.md#_top) to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are `null`, or **x** and **y** are equal; otherwise, `false`\.