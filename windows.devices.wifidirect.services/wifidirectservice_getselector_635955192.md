---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectService.GetSelector(System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetSelector(System.String serviceName, Windows.Storage.Streams.IBuffer serviceInfoFilter)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectService.GetSelector

## -description
Gets an Advanced Query Syntax (AQS) string to be used to find Wi-Fi Direct Service advertisers for a particular service, where a given byte sequence appears in the advertiser's service information blob.

## -parameters
### -param serviceName
The service name to be found.

### -param serviceInfoFilter
A byte sequence that must be found in the advertiser's service information blob.

## -returns
The AQS string for the requested advertiser query.

## -remarks
Your code uses AQS strings with the search and enumeration methods in the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) namespace.

## -examples

## -see-also
[GetSelector(String)](wifidirectservice_getselector_1490626236.md)