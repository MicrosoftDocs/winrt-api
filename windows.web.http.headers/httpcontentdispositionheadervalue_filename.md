---
-api-id: P:Windows.Web.Http.Headers.HttpContentDispositionHeaderValue.FileName
-api-type: winrt property
---

<!-- Property syntax
public string FileName { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentDispositionHeaderValue.FileName

## -description
Gets or sets the value of the **filename-parm** information in the **Content-Disposition** HTTP header for a single file.

## -property-value
A suggested filename.

## -remarks
The [FileName](httpcontentdispositionheadervalue_filename.md) property is a suggestion for how to construct a filename for storing the message payload to be used if the entity is detached and stored in a separate file.

The [FileName](httpcontentdispositionheadervalue_filename.md) property uses MIME encoding for non-ascii characters.

## -examples

## -see-also
