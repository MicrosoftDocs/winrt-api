---
-api-id: M:Windows.Devices.Input.PenDevice.GetFromPointerId(System.UInt32)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public PenDevice PenDevice.GetFromPointerId(UInt32 pointerId)
-->

# Windows.Devices.Input.PenDevice.GetFromPointerId

## -description

Obtains a [PenDevice](pendevice.md) object associated with the specified pointer, if available.

## -parameters

### -param pointerId

The unique pointer identifier associated with the pointer event.

## -returns

A [PenDevice](pendevice.md) object. 

Returns null if the pointer input does not correspond to the pen input, or if the pen does not support a unique ID.

## -remarks

## -see-also

## -examples
