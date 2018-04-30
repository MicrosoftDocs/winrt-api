---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfileMetadata.DenyInstallAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESimProfileMetadata.DenyInstallAsync()
-->

# Windows.Networking.NetworkOperators.ESimProfileMetadata.DenyInstallAsync

## -description
Asynchronously denies installation of the profile. The profile is revoked at the profile server.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -returns
An asynchronous deny-installation operation. On successful completion, contains an [ESimOperationResult](esimoperationresult.md) object representing the result of the deny-installation operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe