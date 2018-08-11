# LiteralCollection Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents the set of [Literal](../Literal/README.md)s\.

```csharp
public class LiteralCollection : System.Collections.ObjectModel.Collection<Literal>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1) &#x2192; LiteralCollection

### Implements

[ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection) &#x2022; [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)\<[Literal](../Literal/README.md)> &#x2022; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Literal](../Literal/README.md)> &#x2022; [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist) &#x2022; [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)\<[Literal](../Literal/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LiteralCollection()](-ctor/README.md) | Initializes a new instance of the [LiteralCollection](./README.md) class that is empty\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.count) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Item\[Int32\]](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.item) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Item\[String\]](Item/README.md) | Returns first literal with the specified identifier |
| [Items](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.items) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.add) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Clear()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.clear) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [ClearItems()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.clearitems) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Contains(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.contains) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Contains(String)](Contains/README.md) | Determines whether a [Literal](../Literal/README.md) with a specified identifier is in the [LiteralCollection](./README.md)\. |
| [CopyTo(Literal\[\], Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.copyto) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Find(String)](Find/README.md) | Returns first literal with the specified identifier |
| [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.getenumerator) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [IndexOf(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.indexof) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Insert(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.insert) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [InsertItem(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.insertitem) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.remove) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Remove(String)](Remove/README.md) | Removes the first occurrence of a literal with a specific identifier |
| [RemoveAt(Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.removeat) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [RemoveItem(Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.removeitem) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [SetItem(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.setitem) |  \(Inherited from [Collection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1)\) |
| [Sort()](Sort/README.md#Pihrtsoft_Snippets_LiteralCollection_Sort) | Sorts the elements in the entire [LiteralCollection](./README.md) using the [LiteralComparer.Identifier](../Comparers/LiteralComparer/Identifier/README.md) comparer\. |
| [Sort(IComparer\<Literal>)](Sort/README.md#Pihrtsoft_Snippets_LiteralCollection_Sort_System_Collections_Generic_IComparer_Pihrtsoft_Snippets_Literal__) | Sorts the elements in the entire [LiteralCollection](./README.md) using the specified comparer\. |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

