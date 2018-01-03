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
If the time-out period is exceeded, this method returns a value of **TimedOut** for the [AutoUpdateTimeZoneStatus](autoupdatetimezonestatus.md).

The recommended time-out value is 60 seconds. 

## -returns

## -remarks
You can run this method at start up to set the time zone without prompting users for information.

This method does not necessarily change the time zone or find the correct time zone. 
For the results of the attempt, see the [AutoUpdateTimeZoneStatus](autoupdatetimezonestatus.md) enumeration.

Separately, you can include a way for the user to set the time zone at a later time.

This method can use information from any of the following sources to determine the time zone:

- GPS
- Cellular
- Wi-Fi
- IP Address

If your device does not have access to any method of determining location, you should not run this method. 

## -see-also
[AutoUpdateTimeZoneStatus](autoupdatetimezonestatus.md)

## -examples

