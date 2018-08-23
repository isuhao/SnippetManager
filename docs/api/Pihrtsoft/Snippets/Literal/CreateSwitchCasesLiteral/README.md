<a name="_top"></a>

# Literal\.CreateSwitchCasesLiteral\(String, String, String, String\) Method

[Home](../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.[Literal](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Create new [Literal](../README.md#_top) with function generates switch cases\.

```csharp
public static Literal CreateSwitchCasesLiteral(string identifier, string expressionIdentifier, string toolTip = null, string defaultValue = "default:")
```

### Parameters

#### identifier

The [Literal](../README.md#_top) identifier\.

#### expressionIdentifier

Identifier of the literal that represent switch expression\.

#### toolTip

The [Literal](../README.md#_top) description\.

#### defaultValue

The [Literal](../README.md#_top)default value\.

### Returns

Pihrtsoft\.Snippets\.[Literal](../README.md#_top)

[Literal](../README.md#_top) with function that generates switch cases\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**identifier** is `null`\.

