---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfileMetadata.ConfirmInstallAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<ESimProfileInstallProgress> ESimProfileMetadata.ConfirmInstallAsync()
-->

# Windows.Networking.NetworkOperators.ESimProfileMetadata.ConfirmInstallAsync

## -description
Asynchronously (with progress) downloads and installs an eSIM profile.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -returns

## -remarks
An asynchronous download and install operation with progress. On successful completion, contains an [ESimProfileInstallProgress](esimprofileinstallprogress.md) object representing the result of the download and install operation.

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe