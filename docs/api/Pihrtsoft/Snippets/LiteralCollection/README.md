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

[ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection), [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)\<[Literal](../Literal/README.md)>, [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Literal](../Literal/README.md)>, [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist), [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)\<[Literal](../Literal/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LiteralCollection()](-ctor/README.md) | Initializes a new instance of the [LiteralCollection](./README.md) class that is empty\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.count) | |
| [Item\[Int32\]](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.item) | |
| [Item\[String\]](Item/README.md) | Returns first literal with the specified identifier |
| [Items](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.items) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.add) | |
| [Clear()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.clear) | |
| [ClearItems()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.clearitems) | |
| [Contains(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.contains) | |
| [Contains(String)](Contains/README.md) | Determines whether a [Literal](../Literal/README.md) with a specified identifier is in the [LiteralCollection](./README.md)\. |
| [CopyTo(Literal\[\], Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.copyto) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) | |
| [Find(String)](Find/README.md) | Returns first literal with the specified identifier |
| [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.getenumerator) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) | |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) | |
| [IndexOf(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.indexof) | |
| [Insert(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.insert) | |
| [InsertItem(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.insertitem) | |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) | |
| [Remove(Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.remove) | |
| [Remove(String)](Remove/README.md) | Removes the first occurrence of a literal with a specific identifier |
| [RemoveAt(Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.removeat) | |
| [RemoveItem(Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.removeitem) | |
| [SetItem(Int32, Literal)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.setitem) | |
| [Sort()](Sort/README.md#Pihrtsoft_Snippets_LiteralCollection_Sort) | Sorts the elements in the entire [LiteralCollection](./README.md) using the [LiteralComparer.Identifier](../Comparers/LiteralComparer/Identifier/README.md) comparer\. |
| [Sort(IComparer\<Literal>)](Sort/README.md#Pihrtsoft_Snippets_LiteralCollection_Sort_System_Collections_Generic_IComparer_Pihrtsoft_Snippets_Literal__) | Sorts the elements in the entire [LiteralCollection](./README.md) using the specified comparer\. |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) | |

