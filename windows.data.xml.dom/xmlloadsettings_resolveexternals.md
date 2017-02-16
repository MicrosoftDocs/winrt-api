---
-api-id: P:Windows.Data.Xml.Dom.XmlLoadSettings.ResolveExternals
-api-type: winrt property
---

<!-- Property syntax
public bool ResolveExternals { get;  set; }
-->

# Windows.Data.Xml.Dom.XmlLoadSettings.ResolveExternals

## -description
Gets or sets a value that specifies whether external definitions, resolvable namespaces, external subsets of document type definitions (DTDs), and external entity references are to be resolved at the time the document is parsed.

## -property-value
True if external definitions, resolvable namespaces, external subsets of DTDs, and external entity references are resolved at the time the document is parsed; otherwise false. The default value is false.

## -remarks
When this property is true, external definitions are resolved at parse time. This allows default attributes and data types to be defined on elements from the schema and allows use of the DTD as a file inclusion mechanism.

This setting is independent of whether validation is to be performed, as indicated by the value of the [ValidateOnParse](xmlloadsettings_validateonparse.md) property. If externals cannot be resolved during validation, a validation error occurs. When the value of **ResolveExternals** is false, externals are not resolved and validation is not performed.

A resolvable namespace is indicated by a namespace Universal Resource Identifier (URI) that begins with "x-schema:" as its prefix.

## -examples

## -see-also
