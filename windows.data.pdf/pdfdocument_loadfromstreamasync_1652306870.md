---
-api-id: M:Windows.Data.Pdf.PdfDocument.LoadFromStreamAsync(Windows.Storage.Streams.IRandomAccessStream,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Data.Pdf.PdfDocument> LoadFromStreamAsync(Windows.Storage.Streams.IRandomAccessStream inputStream, System.String password)
-->

# Windows.Data.Pdf.PdfDocument.LoadFromStreamAsync

## -description
Creates a [PdfDocument](pdfdocument.md) object, representing a Portable Document Format (PDF) document, from a stream of data that represents a Portable Document Format (PDF) document in the file system. Use this method if the Portable Document Format (PDF) document is password-protected.

## -parameters
### -param inputStream
The stream of data, which represents a Portable Document Format (PDF) document.

### -param password
The password to open the Portable Document Format (PDF) document, if it requires one.

## -returns
The asynchronous operation.

## -remarks
If the Portable Document Format (PDF) document does not require a password, this method ignores it.

This method returns an **ERROR_WRONG_PASSWORD** error if the wrong password is specified.

## -examples

## -see-also
[LoadFromStreamAsync(IRandomAccessStream)](pdfdocument_loadfromstreamasync_780156426.md)