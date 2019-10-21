---
-api-id: P:Windows.Networking.NetworkOperators.ESimDiscoverResult.Events
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IVectorView<ESimDiscoverEvent> Events { get; }
-->

# Windows.Networking.NetworkOperators.ESimDiscoverResult.Events

## -description
Gets a collection of the discovery events related to the eSIM profile discovery operation.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value
A collection of [ESimDiscoverEvent](esimdiscoverevent.md) objects representing the discovery events.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
