---
-api-id: E:Windows.Devices.WiFiDirect.Services.WiFiDirectService.SessionDeferred
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SessionDeferred<Windows.Devices.WiFiDirect.Services.WiFiDirectService,  Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs>
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectService.SessionDeferred

## -description
Event raised when a session request has been deferred. Note that this does not mean that the request has failed or been denied. It is a notification that the server is performing a long operation, such as waiting for a user to enter a PIN. The seeker that receives this message should begin a 120-second wait before it times out the session request, to give the server time to complete its operation. The event arguments include a buffer supplied by the server in the deferral notification with additional information.

## -remarks

## -examples

## -see-also
