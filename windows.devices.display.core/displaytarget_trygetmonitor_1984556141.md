---
-api-id: M:Windows.Devices.Display.Core.DisplayTarget.TryGetMonitor
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayMonitor DisplayTarget.TryGetMonitor()
-->

# Windows.Devices.Display.Core.DisplayTarget.TryGetMonitor

## -description
Tries to retrieve an object describing the monitor currently connected to this [DisplayTarget](displaytarget.md). This method can fail or return a different monitor than the properties on the **DisplayTarget** describe if monitors have been plugged or unplugged from the **DisplayTarget** since the **DisplayTarget** object was created. **IsStale** returns true if the monitor *might* have changed since the **DisplayTarget** was created.

## -returns

A [DisplayMonitor](../windows.devices.display/displaymonitor.md) representing the monitor connected to this target, if one is connected, or else **null** if nothing is connected.

## -remarks

Since this method has **Try** in its name, it returns **null** instead of throwing an exception or returning a failure HRESULT.

## -see-also

## -examples
