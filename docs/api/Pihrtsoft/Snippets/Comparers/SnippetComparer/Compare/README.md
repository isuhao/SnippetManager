<a name="_top"></a>

# SnippetComparer\.Compare Method

[Home](../../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.Comparers\.[SnippetComparer](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Compare(Object, Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Implements [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)\) |
| [Compare(Snippet, Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Compares two snippets and returns an indication of their relative sort order\. \(Implements [IComparer\<Snippet>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)\) |

## Compare\(Object, Object\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_System_Object_System_Object_"></a>

### Summary

Compares two objects and returns an indication of their relative sort order\.

```csharp
public abstract int Compare(object x, object y)
```

### Parameters

**x**

An object to compare to **y**\.

**y**

An object to compare to **x**\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)

## Compare\(Snippet, Snippet\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Compares two snippets and returns an indication of their relative sort order\.

```csharp
public abstract int Compare(Snippet x, Snippet y)
```

### Parameters

**x**

A [Snippet](../../../Snippet/README.md#_top) to compare to **y**\.

**y**

A [Snippet](../../../Snippet/README.md#_top) to compare to **x**\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* [IComparer\<Snippet>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)