<a name="_top"></a>

# Snippet\.Save Method

[Home](../../../../README.md#_top)

**Containing Type**: [Pihrtsoft.Snippets](../../README.md#_top)\.[Snippet](../README.md#_top)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Save(Stream)](#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Save(Stream, SaveSettings)](#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally specifying serialization process\. |
| [Save(String)](#Pihrtsoft_Snippets_Snippet_Save_System_String_) | Serializes the current instance to the specified file\. |
| [Save(String, SaveSettings)](#Pihrtsoft_Snippets_Snippet_Save_System_String_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified file\. |

## Save\(Stream\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_"></a>

### Summary

Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public void Save(Stream stream)
```

### Parameters

#### stream

The stream to output this [Snippet](../README.md#_top) to\.

## Save\(Stream, SaveSettings\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally specifying serialization process\.

```csharp
public void Save(Stream stream, SaveSettings settings)
```

### Parameters

#### stream

The stream to output this [Snippet](../README.md#_top) to\.

#### settings

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.

## Save\(String\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_String_"></a>

### Summary

Serializes the current instance to the specified file\.

```csharp
public void Save(string filePath)
```

### Parameters

#### filePath

The absolute or relative path to the file\.

## Save\(String, SaveSettings\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_String_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the current instance to the specified file\.

```csharp
public void Save(string filePath, SaveSettings settings)
```

### Parameters

#### filePath

The absolute or relative path to the file\.

#### settings

A [SaveSettings](../../SaveSettings/README.md#_top) that modify serialization process\.