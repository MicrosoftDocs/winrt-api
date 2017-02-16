---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedContainerExportResult> SaveFileAsContainerAsync(Windows.Storage.IStorageFile protectedFile)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Save an enterprise-protected file as a containerized version.

## -parameters
### -param protectedFile
The protected source file being copied.

## -returns
When the call to this method completes successfully, it returns a [ProtectedContainerExportResult](protectedcontainerexportresult.md) object representing the newly created container file.

## -remarks

## -examples

## -see-also
[SaveFileAsContainerAsync(IStorageFile, IIterable(String))](fileprotectionmanager_savefileascontainerasync_462825355.md)