---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfile.EnableAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESimProfile.EnableAsync()
-->

# Windows.Networking.NetworkOperators.ESimProfile.EnableAsync

## -description
Asynchronously enables the eSIM profile so that it's in use.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -returns
An asynchronous enable operation. On successful completion, contains an [ESimOperationResult](esimoperationresult.md) object representing the result of the enable operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe