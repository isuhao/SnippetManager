<a name="_top"></a>

# CodeElement Class

[Home](../../../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Xml.Serialization](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents Code element in a serialized [Snippet](../../../Snippet/README.md#_top)\. This class cannot be inherited\.

```csharp
public sealed class CodeElement : System.Xml.Serialization.IXmlSerializable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; CodeElement

### Implements

* System\.Xml\.Serialization\.[IXmlSerializable](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [CodeElement()](-ctor/README.md#_top) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Code](Code/README.md#_top) | Gets or sets Code element value\. |
| [Delimiter](Delimiter/README.md#_top) | Gets or sets Delimiter attribute value\. |
| [Kind](Kind/README.md#_top) | Gets or sets Kind attribute value\. |
| [Language](Language/README.md#_top) | Gets or sets Language attribute value\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetSchema()](GetSchema/README.md#_top) | This method is reserved and should not be used\. \(Implements [IXmlSerializable.GetSchema](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.getschema)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ReadXml(XmlReader)](ReadXml/README.md#_top) | Generates an object from its XML representation\. \(Implements [IXmlSerializable.ReadXml](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteXml(XmlWriter)](WriteXml/README.md#_top) | Converts an object into its XML representation\. \(Implements [IXmlSerializable.WriteXml](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml)\) |

