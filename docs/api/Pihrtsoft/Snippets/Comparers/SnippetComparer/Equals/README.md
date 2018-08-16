# SnippetComparer\.Equals Method

[Home](../../../../../README.md)

**Containing Type**: [Pihrtsoft.Snippets.Comparers](../../README.md)\.[SnippetComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Equals(Object, Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Implements [IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)\) |
| [Equals(Snippet, Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Indicates whether two snippets are equal\. \(Implements [IEqualityComparer\<Snippet>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)\) |

## Equals\(Object, Object\)<a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_"></a>

### Summary

Indicates whether two objects are equal\.

```csharp
public abstract bool Equals(object x, object y)
```

### Parameters

#### x

An object to compare to **y**\.

#### y

An object to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are both the same type of object and those objects are equal; otherwise, `false`\.

### Implements

* [IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)

## Equals\(Snippet, Snippet\)<a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Indicates whether two snippets are equal\.

```csharp
public abstract bool Equals(Snippet x, Snippet y)
```

### Parameters

#### x

A [Snippet](../../../Snippet/README.md) to compare to **y**\.

#### y

A [Snippet](../../../Snippet/README.md) to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are `null`, or **x** and **y** are equal; otherwise, `false`\.

### Implements

* [IEqualityComparer\<Snippet>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)
