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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

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