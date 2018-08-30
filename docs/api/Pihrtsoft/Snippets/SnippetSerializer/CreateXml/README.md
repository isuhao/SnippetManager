<a name="_top"></a>

# SnippetSerializer\.CreateXml Method

[Home](../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.[SnippetSerializer](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [CreateXml(IEnumerable\<Snippet>)](#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to text\. |
| [CreateXml(IEnumerable\<Snippet>, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to text, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |
| [CreateXml(Snippet)](#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_) | Serializes a specified [Snippet](../../Snippet/README.md#_top) to xml text\. |
| [CreateXml(Snippet, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes a specified [Snippet](../../Snippet/README.md#_top) to xml text, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |

## CreateXml\(IEnumerable\<Snippet>\) <a name="Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to text\.

```csharp
public static string CreateXml(IEnumerable<Snippet> snippets)
```

### Parameters

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

XML text that represents a specified collection of [Snippet](../../Snippet/README.md#_top)\.

## CreateXml\(IEnumerable\<Snippet>, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_CreateXml_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to text, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static string CreateXml(IEnumerable<Snippet> snippets, SaveSettings settings)
```

### Parameters

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

XML text that represents a specified collection of [Snippet](../../Snippet/README.md#_top)\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippets** or **settings** is `null`\.

## CreateXml\(Snippet\) <a name="Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Serializes a specified [Snippet](../../Snippet/README.md#_top) to xml text\.

```csharp
public static string CreateXml(Snippet snippet)
```

### Parameters

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

XML text that represents a specified [Snippet](../../Snippet/README.md#_top)\.

## CreateXml\(Snippet, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_CreateXml_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes a specified [Snippet](../../Snippet/README.md#_top) to xml text, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static string CreateXml(Snippet snippet, SaveSettings settings)
```

### Parameters

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

XML text that represents a specified [Snippet](../../Snippet/README.md#_top)\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** or **settings** is `null`\.
