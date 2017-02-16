---
-api-id: P:Windows.Foundation.Uri.Query
-api-type: winrt property
---

<!-- Property syntax
public string Query { get; }
-->

# Windows.Foundation.Uri.Query

## -description
Gets the query string component of the Uniform Resource Identifier (URI) as stored in this [Uri](uri.md) instance.

## -property-value
The query string.

## -remarks
[Query](uri_query.md) reports the query portion of the Uniform Resource Identifier (URI), and the subdelimiters (&amp; characters) and key-value separators (=) are all reported as-is in that string. [QueryParsed](uri_queryparsed.md) parses this string and creates a map of key-value pairs. This map is returned as a [WwwFormUrlDecoder](wwwformurldecoder.md) object.

## -examples

## -see-also
