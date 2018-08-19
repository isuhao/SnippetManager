<a name="_top"></a>

# PlaceholderCollection Class

[Home](../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Indexers](#indexers) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents the set of [Placeholder](../Placeholder/README.md#_top)s\. This collection is read\-only\.

```csharp
public class PlaceholderCollection : System.Collections.ObjectModel.ReadOnlyCollection<Placeholder>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1) &#x2192; PlaceholderCollection

### Implements

* System\.Collections\.[ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection)
* System\.Collections\.[IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist)
* System\.Collections\.Generic\.[ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)\<[Placeholder](../Placeholder/README.md#_top)>
* System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Placeholder](../Placeholder/README.md#_top)>
* System\.Collections\.Generic\.[IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)\<[Placeholder](../Placeholder/README.md#_top)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [PlaceholderCollection(IList\<Placeholder>)](-ctor/README.md#_top) | Initializes a new instance of the [PlaceholderCollection](#_top) class that is a read\-only wrapper around the specified list\. |

## Indexers

| Indexer | Summary |
| ------- | ------- |
| [Item\[Int32\]](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.item) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Item\[String\]](Item/README.md#_top) | Returns first placeholder with the specified identifier |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.count) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Items](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.items) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Contains(Placeholder)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.contains) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Contains(String)](Contains/README.md#_top) | Determines whether the [PlaceholderCollection](#_top) contains an item with a specified **identifier**\. |
| [ContainsEnd()](ContainsEnd/README.md#_top) | Determines whether the [PlaceholderCollection](#_top) contains an item with identifier equal to [Placeholder.EndIdentifier](../Placeholder/EndIdentifier/README.md#_top)\. |
| [ContainsSelected()](ContainsSelected/README.md#_top) | Determines whether the [PlaceholderCollection](#_top) contains an item with identifier equal to [Placeholder.SelectedIdentifier](../Placeholder/SelectedIdentifier/README.md#_top)\. |
| [CopyTo(Placeholder\[\], Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.copyto) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Find(String)](Find/README.md#_top) | Returns first placeholder with the specified identifier |
| [FindAll(String)](FindAll/README.md#_top) | Returns all placeholders with the specified identifier |
| [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.getenumerator) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [IndexOf(Placeholder)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.indexof) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

