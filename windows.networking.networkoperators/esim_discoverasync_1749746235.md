---
-api-id: M:Windows.Networking.NetworkOperators.ESim.DiscoverAsync(System.String,System.String)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperation<ESimDiscoverResult> ESim.DiscoverAsync(String serverAddress, String matchingId)
-->

# Windows.Networking.NetworkOperators.ESim.DiscoverAsync

## -description
Asynchronously performs an eSIM profile discovery operation for the supplied RSP server address and matching ID.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -parameters
### -param serverAddress
A string containing an RSP server address. If `serverAddress` is empty, the API uses the default SMDS address.

### -param matchingId
A string containing the matching ID.

## -returns
An [ESimDiscoverResult](esimdiscoverresult.md) object representing the result of the operation.

## -remarks
See [Discover](esim_discover_155072993.md) for more info.

## -see-also

## -examples
See [Discover](esim_discover_155072993.md) for code examples.

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
