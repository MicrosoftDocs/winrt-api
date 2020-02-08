---
-api-id: M:Windows.Devices.SmartCards.SmartCardReader.GetDeviceSelector(Windows.Devices.SmartCards.SmartCardReaderKind)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(Windows.Devices.SmartCards.SmartCardReaderKind kind)
-->

# Windows.Devices.SmartCards.SmartCardReader.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) string representing a set of a specific type of smart card readers connected to the device. This string is passed to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) method to enumerate the given set of smart card readers.

## -parameters
### -param kind
One of the enumeration values, representing a specific smart card reader type.

## -returns
The Advanced Query Syntax (AQS) string representing a set of the specified type of smart card readers connected to the device.

## -remarks
For info about AQS, see [Using Advanced Query Syntax Programmatically](https://msdn.microsoft.com/library/76e33903-d063-48c0-9afe-912c3daa8237).

## -examples

## -see-also
[GetDeviceSelector](smartcardreader_getdeviceselector_838466080.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
