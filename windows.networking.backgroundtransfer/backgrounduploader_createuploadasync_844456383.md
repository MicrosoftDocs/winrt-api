---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundUploader.CreateUploadAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.BackgroundTransfer.UploadOperation> CreateUploadAsync(Windows.Foundation.Uri uri, Windows.Foundation.Collections.IIterable<Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart> parts, System.String subType)
-->

# Windows.Networking.BackgroundTransfer.BackgroundUploader.CreateUploadAsync

## -description
Returns an asynchronous operation that, on completion, returns an [UploadOperation](uploadoperation.md) with the specified URI, one or more [BackgroundTransferContentPart](backgroundtransfercontentpart.md) objects, and the multipart subtype.

## -parameters
### -param uri
The location for the upload.

### -param parts
One or more [BackgroundTransferContentPart](backgroundtransfercontentpart.md) objects.

### -param subType
The multipart subtype. For example, "related" for content of type "multipart/**related** ".

## -returns
The resultant asynchronous [UploadOperation](uploadoperation.md).

## -remarks

## -examples

## -see-also
[CreateUploadAsync(Uri, IIterable(BackgroundTransferContentPart))](backgrounduploader_createuploadasync_1414694207.md), [CreateUploadAsync(Uri, IIterable(BackgroundTransferContentPart), String, String)](backgrounduploader_createuploadasync_27612993.md)