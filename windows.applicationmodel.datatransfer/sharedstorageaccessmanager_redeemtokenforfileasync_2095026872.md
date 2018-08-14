---
-api-id: M:Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager.RedeemTokenForFileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> RedeemTokenForFileAsync(System.String token)
-->

# Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager.RedeemTokenForFileAsync

## -description
Gets a file shared by another app by providing the sharing token received from the source app.

## -parameters
### -param token
The sharing token for the shared file.

## -returns
A wrapper object that contains the shared file.

## -remarks
When a source app shares a file with a target app, the target app calls the [RedeemTokenForFileAsync](sharedstorageaccessmanager_redeemtokenforfileasync_2095026872.md) method to get the shared file.

For a code sample, see [SharedStorageAccessManager](sharedstorageaccessmanager.md).

## -examples

## -see-also
