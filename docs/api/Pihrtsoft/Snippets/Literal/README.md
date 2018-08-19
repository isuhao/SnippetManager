<a name="_top"></a>

# Literal Class

[Home](../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a code snippet literal\.

```csharp
public class Literal : System.ICloneable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; Literal

### Implements

* System\.[ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Literal(String, String, String)](-ctor/README.md#_top) | Initializes a new instance of the [Literal](#_top) class with a specified identifier, tooltip and default value\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [DefaultValue](DefaultValue/README.md#_top) | Gets or sets literal default value\. |
| [Function](Function/README.md#_top) | Gets or sets literal function name\. |
| [Identifier](Identifier/README.md#_top) | Gets or sets literal identifier\. |
| [IsEditable](IsEditable/README.md#_top) | Gets or sets a value indicating whether literal can be edited by a user when inserting a snippet into code\. |
| [ToolTip](ToolTip/README.md#_top) | Gets or sets literal tooltip\. |
| [TypeName](TypeName/README.md#_top) | Gets or sets the type name of the object\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Clone()](Clone/README.md#_top) | Creates a new [Literal](#_top) that is a deep copy of the current instance\. \(Implements [ICloneable.Clone](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone)\) |
| [CreateClassNameLiteral(String, String, String)](CreateClassNameLiteral/README.md#_top) | Create new [Literal](#_top) with function that returns containing type name\. |
| [CreateSwitchCasesLiteral(String, String, String, String)](CreateSwitchCasesLiteral/README.md#_top) | Create new [Literal](#_top) with function generates switch cases\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

