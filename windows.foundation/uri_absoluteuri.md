---
-api-id: P:Windows.Foundation.Uri.AbsoluteUri
-api-type: winrt property
---

<!-- Property syntax
public string AbsoluteUri { get; }
-->

# Windows.Foundation.Uri.AbsoluteUri

## -description
Gets the entire, non-canonical URI (It is non-canonical because it might actually be an IRI, per the [Windows.Foundation.Uri](uri.md) encoding behavior; see Remarks.).

## -property-value
The entire, non-canonical URI.

## -remarks
This property is not always strictly a URI, per either RFC 3986 or RFC 3987. If you want a strict Uniform Resource Identifier (URI), use the [AbsoluteCanonicalUri](uri_absolutecanonicaluri.md) value instead.

## -examples

## -see-also
[AbsoluteCanonicalUri](uri_absolutecanonicaluri.md)