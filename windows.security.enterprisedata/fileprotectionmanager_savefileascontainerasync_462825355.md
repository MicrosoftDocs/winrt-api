---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync(Windows.Storage.IStorageFile,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedContainerExportResult> SaveFileAsContainerAsync(Windows.Storage.IStorageFile protectedFile, Windows.Foundation.Collections.IIterable<System.String> sharedWithIdentities)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Save an enterprise-protected file as a containerized version, and share it with a specified list of user identities.

## -parameters
### -param protectedFile
The protected source file being copied.

### -param sharedWithIdentities
A collection of strings representing the user identities to share the containerized file with. For example, email recipients.

## -returns
When the call to this method completes successfully, it returns a [ProtectedContainerExportResult](protectedcontainerexportresult.md) object representing the newly created container file.

## -remarks

## -examples

## -see-also
[SaveFileAsContainerAsync(IStorageFile)](fileprotectionmanager_savefileascontainerasync_116052457.md)