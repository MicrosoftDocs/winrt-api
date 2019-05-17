---
-api-id: P:Windows.Web.Http.Headers.HttpContentDispositionHeaderValue.DispositionType
-api-type: winrt property
---

<!-- Property syntax
public string DispositionType { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentDispositionHeaderValue.DispositionType

## -description
Gets or sets the value of the **disposition-type** information in the **Content-Disposition** HTTP header.

## -property-value
The value of the **disposition-type** characteristic in the **Content-Disposition** HTTP header.

## -remarks
The DispositionType property represents the disposition type for a content body part.

A body part should be marked with a DispositionType property of "inline" if it is intended to be displayed automatically upon display of the message. A body part can be designated with a DispositionType property of "attachment" to indicate that they are separate from the main body of the HTTP request or response.

## -examples

## -see-also
