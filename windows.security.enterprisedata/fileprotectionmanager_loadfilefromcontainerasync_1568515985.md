---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.LoadFileFromContainerAsync(Windows.Storage.IStorageFile,Windows.Storage.IStorageItem,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedContainerImportResult> LoadFileFromContainerAsync(Windows.Storage.IStorageFile containerFile, Windows.Storage.IStorageItem target, Windows.Storage.NameCollisionOption collisionOption)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.LoadFileFromContainerAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Create an enterprise-protected file in a specified storage item (such as a folder), and load it from a container file.

## -parameters
### -param containerFile
The enterprise protected file to be created and loaded.

### -param target
The storage item into which to create the enterprise protected file.

### -param collisionOption
The enum value that determines how Windows responds if the created file has the same name as an existing item in the container's location.

## -returns
When the call to this method completes successfully, it returns a [ProtectedContainerImportResult](protectedcontainerimportresult.md) object representing the newly created protected file.

## -remarks

## -examples

## -see-also
[LoadFileFromContainerAsync(IStorageFile)](fileprotectionmanager_loadfilefromcontainerasync_1464544117.md), [LoadFileFromContainerAsync(IStorageFile, IStorageItem)](fileprotectionmanager_loadfilefromcontainerasync_601376091.md)