---
-api-id: P:Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.Parameters
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpNameValueHeaderValue> Parameters { get; }
-->

# Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.Parameters

## -description
Gets a set of parameters included in the **Content-Type** HTTP header.

## -property-value
A set of parameters.

## -remarks
The Parameters property contains a set of zero or more name/value pairs associated with the [MediaType](httpmediatypeheadervalue_mediatype.md).

The [CharSet](httpmediatypeheadervalue_charset.md) property is one name/value pair. The [CharSet](httpmediatypeheadervalue_charset.md) property is a shortcut to access the value of the entry in the Parameters list whose name is **charset**.

## -examples

## -see-also
