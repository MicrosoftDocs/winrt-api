---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundTransferGroup.CreateGroup(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.BackgroundTransfer.BackgroundTransferGroup CreateGroup(System.String name)
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferGroup.CreateGroup

## -description
Creates a transfer group using the provided group name.



## -parameters
### -param name
The name of the group. If a group with the this name already exists, this method will return a reference to the existing group object.

## -returns
The new [BackgroundTransferGroup](backgroundtransfergroup.md).

## -remarks
A [BackgroundTransferGroup](backgroundtransfergroup.md) object can persist to support transfer operations that span app sessions. New methods have been introduced to [BackgroundDownloader](backgrounddownloader.md), [BackgroundUploader](backgrounduploader.md), [DownloadOperation](downloadoperation.md), and [UploadOperation](uploadoperation.md) to simplify accessing groups created in a previous app session.

> [!NOTE]
> Windows 8.1 and Windows Server 2012 R2 support a maximum of 50 unique transfer groups for the entire system. So an app should reuse a unique ID or a small number of unique IDs for all transfer groups created by the app. If more than 50 transfer groups are created on the system, the app will get in an unrecoverable state.

## -examples

## -see-also
