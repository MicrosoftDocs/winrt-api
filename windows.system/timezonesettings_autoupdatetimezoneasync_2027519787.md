---
-api-id: M:Windows.System.TimeZoneSettings.AutoUpdateTimeZoneAsync(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AutoUpdateTimeZoneStatus> TimeZoneSettings.AutoUpdateTimeZoneAsync(TimeSpan timeout)
-->

# Windows.System.TimeZoneSettings.AutoUpdateTimeZoneAsync

## -description
Attempts to automatically determine and set the time zone for embedded mode devices.

## -parameters
### -param timeout

## -returns

## -remarks
You can run this method at start up to set the set the time zone without prompting users for information.

This method can use information from any of the following sources to determine the time zone:

- GPS
- Cellular
- Wi-Fi
- IP Address

If your device does not have access to any method of determining location, you should not run this method. 

## -see-also

## -examples

