# Literal\.CreateSwitchCasesLiteral\(String, String, String, String\) Method

[Home](../../../../README.md)

**Containing Type**: [Pihrtsoft.Snippets](../../README.md)\.[Literal](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Create new [Literal](../README.md) with function generates switch cases\.

```csharp
public static Literal CreateSwitchCasesLiteral(string identifier, string expressionIdentifier, string toolTip = null, string defaultValue = "default:")
```

### Parameters

#### identifier

The [Literal](../README.md) identifier\.

#### expressionIdentifier

Identifier of the literal that represent switch expression\.

#### toolTip

The [Literal](../README.md) description\.

#### defaultValue

The [Literal](../README.md)default value\.

### Returns

Pihrtsoft\.Snippets\.[Literal](../README.md)

[Literal](../README.md) with function that generates switch cases\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**identifier** is `null`\.

