---
-api-id: M:Windows.Storage.ApplicationData.ClearPublisherCacheFolderAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ClearPublisherCacheFolderAsync(System.String folderName)
-->

# Windows.Storage.ApplicationData.ClearPublisherCacheFolderAsync

## -description
Clears the files and subfolders from the specified subfolder of the shared storage folder for the publisher of the current app.

## -parameters
### -param folderName
The subfolder of the shared storage folder for the publisher of the current app from which to clear the files and subfolders.

## -returns
Represents an asynchronous action that does not return a result and does not have progress notifications. You can use this value to get the results of the operation, or to specify a method to run when the operation completes - for example, to repopulate the shared storage folder with new data.

## -remarks
For more info about how to share files and folders among apps from the same publisher, see [GetPublisherCacheFolder](applicationdata_getpublishercachefolder_572269963.md).

## -examples

## -see-also
[GetPublisherCacheFolder](applicationdata_getpublishercachefolder_572269963.md)