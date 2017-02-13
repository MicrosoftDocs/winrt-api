---
-api-id: P:Windows.Foundation.Uri.DisplayIri
-api-type: winrt property
---

<!-- Property syntax
public string DisplayIri { get; }
-->

# Windows.Foundation.Uri.DisplayIri

## -description
Gets the decoded unicode characters that make up the current URI.

## -property-value
The decoded unicode characters, when possible. Unsafe values are renamed as percent-encoded UTF-8. Characters in the hostname are decoded if they were encoded using*Punycode*.

## -remarks
The [DisplayIri](uri_displayiri.md) property is an attempted decode of the string as seen in the [AbsoluteCanonicalUri](uri_absolutecanonicaluri.md) property. You might use this string for display to the user, where showing the encodings would be distracting and would make link text that parallels the Uniform Resource Identifier (URI) difficult to read as text. Unsafe values (values that can't be decoded under the user's codepage) are kept as percent-encoded UTF-8.

## -examples

## -see-also
[AbsoluteCanonicalUri](uri_absolutecanonicaluri.md)