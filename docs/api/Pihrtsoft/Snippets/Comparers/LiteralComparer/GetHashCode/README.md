# LiteralComparer\.GetHashCode Method

[Home](../../../../../README.md)

**Containing Type**: [Pihrtsoft.Snippets.Comparers](../../README.md)\.[LiteralComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetHashCode(Literal)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_Pihrtsoft_Snippets_Literal_) | Gets the hash code for the specified [Literal](../../../Literal/README.md)\. \(Implements [IEqualityComparer\<Literal>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)\) |
| [GetHashCode(Object)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_System_Object_) | Gets the hash code for the specified literal\. \(Implements [IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)\) |

## GetHashCode\(Literal\)<a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_Pihrtsoft_Snippets_Literal_"></a>

### Summary

Gets the hash code for the specified [Literal](../../../Literal/README.md)\.

```csharp
public int GetHashCode(Literal obj)
```

### Parameters

#### obj

A literal\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.

### Implements

* [IEqualityComparer\<Literal>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)

## GetHashCode\(Object\)<a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_System_Object_"></a>

### Summary

Gets the hash code for the specified literal\.

```csharp
public int GetHashCode(object obj)
```

### Parameters

#### obj

An object\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.

### Implements

* [IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)
