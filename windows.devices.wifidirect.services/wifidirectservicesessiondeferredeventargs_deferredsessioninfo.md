---
-api-id: P:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs.DeferredSessionInfo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer DeferredSessionInfo { get; }
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs.DeferredSessionInfo

## -description
Gets the service-defined session information returned by the service when it sends a deferral in response to a connection request. Note that a deferral does not indicate that the connection is refused. Rather, it indicates that the server is performing a time-consuming operation such as requesting user input. A seeker should implement a 120-second timeout after getting a deferral before giving up on the request.

## -property-value
A byte sequence of deferred session information, up to 144 bytes. Format is defined by the service.

## -remarks

## -examples

## -see-also
