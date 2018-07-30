---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfile.DisableAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESimProfile.DisableAsync()
-->

# Windows.Networking.NetworkOperators.ESimProfile.DisableAsync

## -description
Asynchronously disables the eSIM profile so that it's no longer in use.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -returns
An asynchronous disable operation. On successful completion, contains an [ESimOperationResult](esimoperationresult.md) object representing the result of the disable operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe