---
-api-id: M:Windows.Devices.WiFiDirect.WiFiDirectDevice.GetDeviceSelector(Windows.Devices.WiFiDirect.WiFiDirectDeviceSelectorType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelector(Windows.Devices.WiFiDirect.WiFiDirectDeviceSelectorType type)
-->

# Windows.Devices.WiFiDirect.WiFiDirectDevice.GetDeviceSelector

## -description
Returns the class selection string that you can use to enumerate Wi-Fi Direct devices for a specific Wi-Fi Direct device selector type.

## -parameters
### -param type
A specific Wi-Fi Direct device selector type.

## -returns
The class selection string that you can use to enumerate Wi-Fi Direct devices.

## -remarks
This method will return either Wi-Fi Direct device interfaces or associated endpoints for PCs, tablets, and phones that support Wi-Fi Direct depending on the value of the *type* parameter.

## -examples

## -see-also
[GetDeviceSelector](wifidirectdevice_getdeviceselector_838466080.md)