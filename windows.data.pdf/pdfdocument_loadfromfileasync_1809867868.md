---
-api-id: M:Windows.Data.Pdf.PdfDocument.LoadFromFileAsync(Windows.Storage.IStorageFile,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Data.Pdf.PdfDocument> LoadFromFileAsync(Windows.Storage.IStorageFile file, System.String password)
-->

# Windows.Data.Pdf.PdfDocument.LoadFromFileAsync

## -description
Outputs an asynchronous operation. When the operation completes, a [PdfDocument](pdfdocument.md) object is returned, which represents a Portable Document Format (PDF) document. Use this method if the Portable Document Format (PDF) document is password-protected.

## -parameters
### -param file
The file, which represents a Portable Document Format (PDF) document.

### -param password
The password to open the Portable Document Format (PDF) document, if it requires one.

## -returns
The asynchronous operation.

## -remarks
If the Portable Document Format (PDF) document does not require a password, this method ignores it.

This method returns an **ERROR_WRONG_PASSWORD** error if the wrong password is specified.

## -examples

## -see-also
[LoadFromFileAsync(IStorageFile)](pdfdocument_loadfromfileasync_656173540.md)