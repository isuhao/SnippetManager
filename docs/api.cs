﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets
{
    public class AssemblyReference : ICloneable
    {
        public AssemblyReference();

        public string AssemblyName { get; set; }
        public Uri Url { get; set; }

        public object Clone();
    }

    public class DuplicateShortcutInfo
    {
        public string Shortcut { get; }
        public IEnumerable<Snippet> Snippets { get; }
    }

    public class KeywordCollection : Collection<string>
    {
        public KeywordCollection();

        public void Sort();
        public void Sort(IComparer<string> comparer);
    }

    public class Literal : ICloneable
    {
        public Literal(string identifier, string toolTip = null, string defaultValue = "");

        public string DefaultValue { get; set; }
        public string Function { get; set; }
        public string Identifier { get; set; }
        public bool IsEditable { get; set; }
        public string ToolTip { get; set; }
        public string TypeName { get; set; }

        public object Clone();
        public static Literal CreateClassNameLiteral(string identifier, string toolTip = null, string defaultValue = "");
        public static Literal CreateSwitchCasesLiteral(string identifier, string expressionIdentifier, string toolTip = null, string defaultValue = "default:");
    }

    public class LiteralCollection : Collection<Literal>
    {
        public LiteralCollection();

        public Literal this[string identifier] { get; }

        public bool Contains(string identifier);
        public Literal Find(string identifier);
        public bool Remove(string identifier);
        public void Sort();
        public void Sort(IComparer<Literal> comparer);
    }

    public static class LiteralRenamer
    {
        public static void Rename(Snippet snippet, string oldIdentifier, string newIdentifier);
    }

    public class NamespaceCollection : Collection<string>
    {
        public NamespaceCollection();

        public void Sort();
        public void Sort(IComparer<string> comparer);
    }

    public class Placeholder
    {
        public const string EndIdentifier = "end";
        public const string SelectedIdentifier = "selected";

        public char Delimiter { get; }
        public int EndIndex { get; }
        public int FullLength { get; }
        public string Identifier { get; }
        public int Index { get; }
        public bool IsEndPlaceholder { get; }
        public bool IsSelectedPlaceholder { get; }
        public bool IsSystemPlaceholder { get; }
        public int Length { get; }
    }

    public class PlaceholderCollection : ReadOnlyCollection<Placeholder>
    {
        public PlaceholderCollection(IList<Placeholder> list);

        public Placeholder this[string identifier] { get; }

        public bool Contains(string identifier);
        public bool ContainsEnd();
        public bool ContainsSelected();
        public Placeholder Find(string identifier);
        public IEnumerable<Placeholder> FindAll(string identifier);
    }

    public sealed class SaveSettings
    {
        public SaveSettings();

        public string Comment { get; set; }
        public string IndentChars { get; set; }
        public bool OmitCodeSnippetsElement { get; set; }
        public bool OmitDefaultDelimiter { get; set; }
        public bool OmitXmlDeclaration { get; set; }
        public bool SetDefaultFormat { get; set; }
    }

    public class ShortcutCollection : Collection<string>
    {
        public ShortcutCollection();

        public void Sort();
        public void Sort(IComparer<string> comparer);
    }

    public class Snippet : ICloneable
    {
        public const char DefaultDelimiter = '$';

        public static readonly Version DefaultFormatVersion;

        public Snippet();

        public event EventHandler TextChanged;

        public ShortcutCollection AlternativeShortcuts { get; }
        public Collection<AssemblyReference> AssemblyReferences { get; }
        public string Author { get; set; }
        public SnippetCode Code { get; }
        public string CodeText { get; set; }
        public ContextKind ContextKind { get; set; }
        public char Delimiter { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public Version FormatVersion { get; set; }
        public bool HasAlternativeShortcuts { get; }
        public bool HasDefaultDelimiter { get; }
        public Uri HelpUrl { get; set; }
        public int Index { get; set; }
        public bool IsExpansion { get; set; }
        public bool IsRefactoring { get; set; }
        public bool IsSurroundsWith { get; set; }
        public KeywordCollection Keywords { get; }
        public Language Language { get; set; }
        public LiteralCollection Literals { get; }
        public NamespaceCollection Namespaces { get; }
        public PlaceholderCollection Placeholders { get; }
        public string Shortcut { get; set; }
        public SnippetTypes SnippetTypes { get; set; }
        public string Title { get; set; }

        public object Clone();
        protected virtual void OnTextChanged(EventArgs e);
        public void Save(Stream stream);
        public void Save(Stream stream, SaveSettings settings);
        public void Save(string filePath);
        public void Save(string filePath, SaveSettings settings);
        public IEnumerable<string> Shortcuts();
    }

    public class SnippetCode
    {
        public SnippetCode(Snippet snippet);

        public bool ContainsUnclosedDelimiter { get; }
        public char Delimiter { get; }
        public Placeholder EndPlaceholder { get; }
        public PlaceholderCollection Placeholders { get; }
        public Placeholder SelectedPlaceholder { get; }
        public Snippet Snippet { get; }
        public string Text { get; }
        public string TextWithDefaultValues { get; }

        public string RemoveAllPlaceholders();
        public string RenamePlaceholder(string oldIdentifier, string newIdentifier);
        public string ReplacePlaceholders(string identifier, string replacement);
    }

    public class SnippetCollection : Collection<Snippet>
    {
        public SnippetCollection();
        public SnippetCollection(IList<Snippet> list);
    }

    public class SnippetFile
    {
        public const string Extension = "snippet";

        public SnippetFile();
        public SnippetFile(string fullName);

        public string FullName { get; set; }
        public SnippetCollection Snippets { get; }
    }

    public static class SnippetFileSearcher
    {
        public const string Pattern = "*.snippet";

        public static IEnumerable<string> EnumerateSnippetFiles(IEnumerable<string> directoryPaths);
        public static IEnumerable<string> EnumerateSnippetFiles(IEnumerable<string> directoryPaths, SearchOption searchOption);
        public static IEnumerable<string> EnumerateSnippetFiles(string directoryPath);
        public static IEnumerable<string> EnumerateSnippetFiles(string directoryPath, SearchOption searchOption);
    }

    public static class SnippetSerializer
    {
        public const string DefaultNamespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet";

        public static string CreateXml(IEnumerable<Snippet> snippets);
        public static string CreateXml(IEnumerable<Snippet> snippets, SaveSettings settings);
        public static string CreateXml(Snippet snippet);
        public static string CreateXml(Snippet snippet, SaveSettings settings);
        public static IEnumerable<Snippet> Deserialize(Stream stream);
        public static IEnumerable<Snippet> Deserialize(string directoryPath, SearchOption searchOption = SearchOption.TopDirectoryOnly);
        public static SnippetFile DeserializeFile(string filePath);
        public static IEnumerable<SnippetFile> DeserializeFiles(string directoryPath, SearchOption searchOption = SearchOption.TopDirectoryOnly);
        public static void Serialize(SnippetFile snippetFile);
        public static void Serialize(SnippetFile snippetFile, SaveSettings settings);
        public static void Serialize(Stream stream, IEnumerable<Snippet> snippets);
        public static void Serialize(Stream stream, IEnumerable<Snippet> snippets, SaveSettings settings);
        public static void Serialize(Stream stream, Snippet snippet);
        public static void Serialize(Stream stream, Snippet snippet, SaveSettings settings);
        public static void Serialize(string filePath, IEnumerable<Snippet> snippets);
        public static void Serialize(string filePath, IEnumerable<Snippet> snippets, SaveSettings settings);
        public static void Serialize(string filePath, Snippet snippet);
        public static void Serialize(string filePath, Snippet snippet, SaveSettings settings);
    }

    public static class SnippetUtility
    {
        public static IEnumerable<DuplicateShortcutInfo> FindDuplicateShortcuts(IEnumerable<Snippet> snippets);
        public static void RemoveUnusedLiterals(Snippet snippet);
        public static void RemoveUnusedPlaceholders(Snippet snippet);
    }

    public enum ContextKind
    {
        None = 0,
        Any = 1,
        File = 2,
        MethodBody = 3,
        MethodDeclaration = 4,
        TypeDeclaration = 5,
    }

    public enum Language
    {
        None = 0,
        VisualBasic = 1,
        CSharp = 2,
        Cpp = 3,
        CPlusPlus = 3,
        Xml = 4,
        Xaml = 5,
        JavaScript = 6,
        Sql = 7,
        Html = 8,
        Css = 9,
        CoffeeScript = 10,
        C = 11,
        FSharp = 12,
        Go = 13,
        Groovy = 14,
        Java = 15,
        Json = 16,
        Less = 17,
        Markdown = 18,
        ObjectiveC = 19,
        ObjectiveCpp = 20,
        Perl = 21,
        Php = 22,
        PowerShell = 23,
        Python = 24,
        R = 25,
        Razor = 26,
        Ruby = 27,
        Rust = 28,
        Sass = 29,
        Swift = 30,
        TypeScript = 31,
        Xsl = 32,
        Yaml = 33,
    }

    [Flags]
    public enum SnippetTypes
    {
        None = 0,
        Expansion = 1,
        SurroundsWith = 2,
        Refactoring = 4,
    }
}

namespace Pihrtsoft.Snippets.Comparers
{
    public class AssemblyReferenceDeepEqualityComparer : EqualityComparer<AssemblyReference>
    {
        public AssemblyReferenceDeepEqualityComparer();

        public override bool Equals(AssemblyReference x, AssemblyReference y);
        public override int GetHashCode(AssemblyReference obj);
    }

    public abstract class LiteralComparer : IComparer, IEqualityComparer, IComparer<Literal>, IEqualityComparer<Literal>
    {
        protected LiteralComparer();

        public static LiteralComparer Identifier { get; }

        public int Compare(Literal x, Literal y);
        public int Compare(object x, object y);
        public bool Equals(Literal x, Literal y);
        public bool Equals(object x, object y);
        public int GetHashCode(Literal obj);
        public int GetHashCode(object obj);
        protected abstract string GetValue(Literal literal);
    }

    public class LiteralDeepEqualityComparer : EqualityComparer<Literal>
    {
        public LiteralDeepEqualityComparer();

        public override bool Equals(Literal x, Literal y);
        public override int GetHashCode(Literal obj);
    }

    public abstract class SnippetComparer : IComparer, IEqualityComparer, IComparer<Snippet>, IEqualityComparer<Snippet>
    {
        protected SnippetComparer();

        public static SnippetComparer<string> Shortcut { get; }
        public static SnippetComparer<string> Title { get; }

        public abstract int Compare(Snippet x, Snippet y);
        public abstract int Compare(object x, object y);
        public abstract bool Equals(Snippet x, Snippet y);
        public abstract bool Equals(object x, object y);
        public abstract int GetHashCode(Snippet obj);
        public abstract int GetHashCode(object obj);
    }

    public abstract class SnippetComparer<T> : SnippetComparer
    {
        protected SnippetComparer();

        public override int Compare(Snippet x, Snippet y);
        public override int Compare(object x, object y);
        public override bool Equals(Snippet x, Snippet y);
        public override bool Equals(object x, object y);
        public override int GetHashCode(Snippet obj);
        public override int GetHashCode(object obj);
        protected abstract T GetValue(Snippet snippet);
    }

    public class SnippetDeepEqualityComparer : EqualityComparer<Snippet>
    {
        public SnippetDeepEqualityComparer();

        public override bool Equals(Snippet x, Snippet y);
        public override int GetHashCode(Snippet obj);
    }
}

namespace Pihrtsoft.Snippets.Validations
{
    public class AssemblyReferenceValidationRule : ValidationRule
    {
        public AssemblyReferenceValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class CodeValidationRule : ValidationRule
    {
        public CodeValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class DescriptionValidationRule : ValidationRule
    {
        public DescriptionValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class FormatVersionValidationRule : ValidationRule
    {
        public FormatVersionValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class LiteralValidationRule : ValidationRule
    {
        public LiteralValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class NamespaceValidationRule : ValidationRule
    {
        public NamespaceValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class ShortcutValidationRule : ValidationRule
    {
        public ShortcutValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class SnippetTypeValidationRule : ValidationRule
    {
        public SnippetTypeValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public class SnippetValidationContext
    {
        public Snippet Snippet { get; }
    }

    public class SnippetValidationResult
    {
        public SnippetValidationResult(Snippet snippet, string code, string description, ResultImportance importance);
        public SnippetValidationResult(Snippet snippet, string code, string description, ResultImportance importance, object content);

        public string Code { get; }
        public object Content { get; }
        public string Description { get; }
        public ResultImportance Importance { get; }
        public Snippet Snippet { get; }
    }

    public class SnippetValidator
    {
        public SnippetValidator();

        public Collection<ValidationRule> ValidationRules { get; }

        public static SnippetValidator CreateDefaultValidator();
        public IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
        protected virtual IEnumerable<SnippetValidationResult> Validate(SnippetValidationContext context);
    }

    public class TitleValidationRule : ValidationRule
    {
        public TitleValidationRule();

        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public abstract class ValidationRule
    {
        protected ValidationRule();

        public abstract IEnumerable<SnippetValidationResult> Validate(Snippet snippet);
    }

    public enum ResultImportance
    {
        Information = 0,
        Warning = 1,
        Error = 2,
    }
}

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    public sealed class CodeElement : IXmlSerializable
    {
        public CodeElement();

        public string Code { get; set; }
        public string Delimiter { get; set; }
        public string Kind { get; set; }
        public string Language { get; set; }

        public XmlSchema GetSchema();
        public void ReadXml(XmlReader reader);
        public void WriteXml(XmlWriter writer);
    }

    [XmlRoot("CodeSnippet")]
    public sealed class CodeSnippetElement
    {
        public CodeSnippetElement();

        [XmlAttribute]
        public string Format { get; set; }
        public HeaderElement Header { get; set; }
        public SnippetElement Snippet { get; set; }
    }

    [XmlRoot("CodeSnippets")]
    public sealed class CodeSnippetsElement
    {
        public CodeSnippetsElement();

        [XmlElement("CodeSnippet")]
        public CodeSnippetElement[] Snippets { get; set; }
    }

    public sealed class DeclarationsElement
    {
        public DeclarationsElement();

        [XmlElement("Literal")]
        public LiteralElement[] Literals { get; set; }
        [XmlElement("Object")]
        public ObjectElement[] Objects { get; set; }
    }

    public sealed class HeaderElement
    {
        public HeaderElement();

        [XmlArrayItem("Shortcut")]
        public string[] AlternativeShortcuts { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string HelpUrl { get; set; }
        [XmlArrayItem("Keyword")]
        public string[] Keywords { get; set; }
        public string Shortcut { get; set; }
        [XmlArrayItem("SnippetType")]
        public string[] SnippetTypes { get; set; }
        public string Title { get; set; }
    }

    public sealed class ImportElement
    {
        public ImportElement();

        public string Namespace { get; set; }
    }

    public class LiteralElement
    {
        public LiteralElement();

        public string Default { get; set; }
        [DefaultValue(true)]
        [XmlAttribute]
        public bool Editable { get; set; }
        public string Function { get; set; }
        public string ID { get; set; }
        public string ToolTip { get; set; }
    }

    public sealed class ObjectElement : LiteralElement
    {
        public ObjectElement();

        public string Type { get; set; }
    }

    public sealed class ReferenceElement
    {
        public ReferenceElement();

        public string Assembly { get; set; }
        public string Url { get; set; }
    }

    public sealed class SnippetElement
    {
        public SnippetElement();

        public CodeElement Code { get; set; }
        public DeclarationsElement Declarations { get; set; }
        [XmlArrayItem("Import")]
        public ImportElement[] Imports { get; set; }
        [XmlArrayItem("Reference")]
        public ReferenceElement[] References { get; set; }
    }
}

