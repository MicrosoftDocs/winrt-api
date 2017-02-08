---
-api-id: P:Windows.Foundation.Uri.QueryParsed
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.WwwFormUrlDecoder QueryParsed { get; }
-->

# Windows.Foundation.Uri.QueryParsed

## -description
Gets a parsed Uniform Resource Identifier (URI) query string.

## -property-value
The parsed query, as a new [WwwFormUrlDecoder](wwwformurldecoder.md) object. This is a read-only list of all name-value pairs (the form entries) as found in the query string after parsing.

## -remarks
[Query](uri_query.md) reports the query portion of the Uniform Resource Identifier (URI), and the subdelimiters (&amp; characters) and key-value separators (=) are all reported as-is in that string. [QueryParsed](uri_queryparsed.md) parses this string and creates a read-only list (vector) of name-value pairs. This is returned as a [WwwFormUrlDecoder](wwwformurldecoder.md) object.

## -examples

## -see-also
[WwwFormUrlDecoder](wwwformurldecoder.md)