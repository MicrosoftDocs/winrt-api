---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfileMetadata.ConfirmInstallAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<ESimProfileInstallProgress> ESimProfileMetadata.ConfirmInstallAsync(String confirmationCode)
-->

# Windows.Networking.NetworkOperators.ESimProfileMetadata.ConfirmInstallAsync

## -description
Asynchronously (with progress) downloads and installs an eSIM profile whose confirmation code is provided.

> [!NOTE]
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

## -parameters
### -param confirmationCode
The confirmation code for the eSIM profile being downloaded and installed.

## -returns
An asynchronous download and install operation with progress. On successful completion, contains an [ESimProfileInstallProgress](esimprofileinstallprogress.md) object representing the result of the download and install operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe