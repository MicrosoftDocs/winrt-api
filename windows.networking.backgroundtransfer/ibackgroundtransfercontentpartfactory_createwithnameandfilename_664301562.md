---
-api-id: M:Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPartFactory.CreateWithNameAndFileName(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart CreateWithNameAndFileName(System.String name, System.String fileName)
-->

# Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPartFactory.CreateWithNameAndFileName

## -description
Creates a [BackgroundTransferContentPart](backgroundtransfercontentpart.md) object that identifies the content type and name of the file.

## -parameters
### -param name
Identifies the content type.

### -param fileName
The fully qualified file name; this includes the local path.

## -returns
The resultant [BackgroundTransferContentPart](backgroundtransfercontentpart.md) object.

## -remarks

## -examples

## -see-also
[CreateDownload(Uri, IStorageFile, IStorageFile)](backgrounddownloader_createdownload_1461958690.md), [CreateUploadAsync](/uwp/api/windows.networking.backgroundtransfer.backgrounduploader.createuploadasync)