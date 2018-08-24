---
-api-id: T:Windows.Storage.Provider.FileUpdateStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Provider.FileUpdateStatus : int
-->

# FileUpdateStatus

## -description
Describes the status of a file update request.

## -enum-fields
### -field Incomplete:0
The file update was not fully completed and should be retried.

### -field Complete:1
The file update was completed successfully.

### -field UserInputNeeded:2
User input (like credentials) is needed to update the file.

### -field CurrentlyUnavailable:3
The remote version of the file was not updated because the storage location wasn't available. The file remains valid and subsequent updates to the file may succeed.

### -field Failed:4
The file is now invalid and can't be updated now or in the future. For example, this could occur if the remote version of the file was deleted.

### -field CompleteAndRenamed:5
The file update was completed successfully and the file has been renamed. For example, this could occur if the user chose to save their changes under a different file name because of conflicting changes made to the remote version of the file.


## -remarks
If your app participates in the Cached File Updater contract, you use this enumeration to communicate the status of a file update request to another app that initiated the update (for example, by calling [CachedFileManager.CompleteUpdatesAsync](../windows.storage/cachedfilemanager_completeupdatesasync_1507988567.md)).

## -examples

## -see-also