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
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

## -returns
A new instance of the [ESimWatcher](esimwatcher.md) class, or `null` if the caller's user security identifier (SID) is not authorized by the Windows service that handles eSIM-related operation requests.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe