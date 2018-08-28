<a name="_top"></a>

# SnippetSerializer\.Serialize Method

[Home](../../../../README.md#_top)

**Containing Type**: Pihrtsoft\.Snippets\.[SnippetSerializer](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Serialize(SnippetFile)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_) | Serializes the specified [SnippetFile](../../SnippetFile/README.md#_top) to the file\. |
| [Serialize(SnippetFile, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [SnippetFile](../../SnippetFile/README.md#_top) to the file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(Stream, IEnumerable\<Snippet>)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, IEnumerable\<Snippet>, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(Stream, Snippet)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, Snippet, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(String, IEnumerable\<Snippet>)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified snippet file\. |
| [Serialize(String, IEnumerable\<Snippet>, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |
| [Serialize(String, Snippet)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified snippet file\. |
| [Serialize(String, Snippet, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\. |

## Serialize\(SnippetFile\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_"></a>

### Summary

Serializes the specified [SnippetFile](../../SnippetFile/README.md#_top) to the file\.

```csharp
public static void Serialize(SnippetFile snippetFile)
```

### Parameters

**snippetFile**

A snippet file to be serialized\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippetFile** is `null`\.

## Serialize\(SnippetFile, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the specified [SnippetFile](../../SnippetFile/README.md#_top) to the file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static void Serialize(SnippetFile snippetFile, SaveSettings settings)
```

### Parameters

**snippetFile**

A snippet file to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippetFile** is `null`\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**settings** is `null`\.

## Serialize\(Stream, IEnumerable\<Snippet>\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public static void Serialize(Stream stream, IEnumerable<Snippet> snippets)
```

### Parameters

**stream**

The stream to output this [Snippet](../../Snippet/README.md#_top) to\.

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

## Serialize\(Stream, IEnumerable\<Snippet>, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static void Serialize(Stream stream, IEnumerable<Snippet> snippets, SaveSettings settings)
```

### Parameters

**stream**

The stream to output this [Snippet](../../Snippet/README.md#_top) to\.

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**stream** or **snippets** or **settings** is `null`\.

## Serialize\(Stream, Snippet\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public static void Serialize(Stream stream, Snippet snippet)
```

### Parameters

**stream**

The stream to output this [Snippet](../../Snippet/README.md#_top) to\.

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

## Serialize\(Stream, Snippet, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static void Serialize(Stream stream, Snippet snippet, SaveSettings settings)
```

### Parameters

**stream**

The stream to output this [Snippet](../../Snippet/README.md#_top) to\.

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**stream** or **snippet** or **settings** is `null`\.

## Serialize\(String, IEnumerable\<Snippet>\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified snippet file\.

```csharp
public static void Serialize(string filePath, IEnumerable<Snippet> snippets)
```

### Parameters

**filePath**

The absolute or relative path to the file\.

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

## Serialize\(String, IEnumerable\<Snippet>, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes enumerable collection of [Snippet](../../Snippet/README.md#_top) to the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static void Serialize(string filePath, IEnumerable<Snippet> snippets, SaveSettings settings)
```

### Parameters

**filePath**

The absolute or relative path to the file\.

**snippets**

Enumerable collection of [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**filePath** or **snippets** or **settings** is `null`\.

## Serialize\(String, Snippet\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified snippet file\.

```csharp
public static void Serialize(string filePath, Snippet snippet)
```

### Parameters

**filePath**

The absolute or relative path to the file\.

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

## Serialize\(String, Snippet, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the specified [Snippet](../../Snippet/README.md#_top) the the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md#_top) to modify serialization process\.

```csharp
public static void Serialize(string filePath, Snippet snippet, SaveSettings settings)
```

### Parameters

**filePath**

The absolute or relative path to the file\.

**snippet**

A [Snippet](../../Snippet/README.md#_top) to be serialized\.

**settings**

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**filePath** or **snippet** or **settings** is `null`\.

