---
-api-id: M:Windows.Networking.NetworkOperators.ESim.DiscoverAsync
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperation<ESimDiscoverResult> ESim.DiscoverAsync()
-->

# Windows.Networking.NetworkOperators.ESim.DiscoverAsync

## -description
Asynchronously performs an eSIM profile discovery operation using the default SMDS address.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -returns
An [ESimDiscoverResult](esimdiscoverresult.md) object representing the result of the operation.

## -remarks
See [Discover](esim_discover_155072993.md) for more info.

## -see-also

## -examples
See [Discover](esim_discover_155072993.md) for code examples.

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
