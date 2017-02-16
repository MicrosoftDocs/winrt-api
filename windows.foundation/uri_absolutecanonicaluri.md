---
-api-id: P:Windows.Foundation.Uri.AbsoluteCanonicalUri
-api-type: winrt property
---

<!-- Property syntax
public string AbsoluteCanonicalUri { get; }
-->

# Windows.Foundation.Uri.AbsoluteCanonicalUri

## -description
Gets a fully canonical RFC-compliant representation of the current URI.

## -property-value
The canonical URI.

## -remarks
The canonical URI has all non-US ASCII characters represented as percent-encoded UTF-8 and as *Punycode* in the hostname.

Use the [DisplayIri](uri_displayiri.md) property instead if you want to decode this string so that it can be presented.

## -examples

## -see-also
[DisplayIri property](uri_displayiri.md), [RFC 3492 (Punycode)](http://tools.ietf.org/html/rfc3492)