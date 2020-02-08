---
-api-id: M:Windows.Devices.SmartCards.SmartCardReader.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.SmartCards.SmartCardReader.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) string representing all smart card readers connected to the device. This string is passed to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) method to enumerate the given set of smart card readers.

## -returns
The Advanced Query Syntax (AQS) string representing all smart card readers connected to the device.

## -remarks
For info about AQS, see [Using Advanced Query Syntax Programmatically](https://msdn.microsoft.com/library/76e33903-d063-48c0-9afe-912c3daa8237).

## -examples

## -see-also
[GetDeviceSelector(SmartCardReaderKind)](smartcardreader_getdeviceselector_1037956577.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
