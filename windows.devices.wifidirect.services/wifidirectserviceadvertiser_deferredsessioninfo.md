---
-api-id: P:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.DeferredSessionInfo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer DeferredSessionInfo { get;  set; }
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.DeferredSessionInfo

## -description
Gets or sets the service-specific information that is passed to a session requester when establishing a session will not be completed immediately, as when, for example, the service is waiting for user input to complete the request. A requester should implement a 120 second timeout when its request is deferred.

## -property-value
The information to be sent to the session requester. Format is service-specific, and total size cannot exceed 144 bytes.

## -remarks

## -examples

## -see-also
