---
-api-id: T:Windows.Devices.Display.Core.DisplayFence
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class DisplayFence 
-->

# Windows.Devices.Display.Core.DisplayFence

## -description
Represents a fence object that can be used to synchronize rendering commands between [Direct3D](/windows/desktop/direct3d) devices and a [DisplayDevice](displaydevice.md) object.

## -remarks
A **DisplayFence** can be shared between [Direct3D](/windows/desktop/direct3d) devices and a [DisplayDevice](displaydevice.md) using the **IDisplayDeviceInterop** native COM interface. The **CreateSharedHandle** method can create a shared NT handle for a **DisplayFence** created by a **DisplayDevice**, and the **OpenSharedHandle** method can be used to create a **DisplayFence** object from an existing Direct3D shared fence handle.

## -see-also

## -examples
