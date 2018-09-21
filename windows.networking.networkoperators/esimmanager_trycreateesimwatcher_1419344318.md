---
-api-id: M:Windows.Networking.NetworkOperators.ESimManager.TryCreateESimWatcher
-api-type: winrt method
---

<!-- Method syntax.
public ESimWatcher ESimManager.TryCreateESimWatcher()
-->

# Windows.Networking.NetworkOperators.ESimManager.TryCreateESimWatcher

## -description
Attempts to create a new instance of the [ESimWatcher](esimwatcher.md) class.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -returns
A new instance of the [ESimWatcher](esimwatcher.md) class, or `null` if the caller's user security identifier (SID) is not authorized by the Windows service that handles eSIM-related operation requests.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe