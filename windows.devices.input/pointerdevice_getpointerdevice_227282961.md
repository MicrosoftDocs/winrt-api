---
-api-id: M:Windows.Devices.Input.PointerDevice.GetPointerDevice(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Input.PointerDevice GetPointerDevice(System.UInt32 pointerId)
-->

# Windows.Devices.Input.PointerDevice.GetPointerDevice

## -description
Gets information about the pointer device associated with the specified input pointer ID.

## -parameters
### -param pointerId
The ID of the pointer input.

## -returns
The [PointerDevice](pointerdevice.md) object that represents the associated pointer device.

## -remarks
[GetPointerDevice](pointerdevice_getpointerdevice.md) is a static method.

The input pointer specified by *pointerId* must identify an active input.


<!--{annotation author="kbridge" time="11/4/2011 5:31:08 PM"}exception?-->

## -examples

## -see-also
[Quickstart: Identifying input devices](http://msdn.microsoft.com/library/7001b56d-081b-4683-84bb-24c361397c08)