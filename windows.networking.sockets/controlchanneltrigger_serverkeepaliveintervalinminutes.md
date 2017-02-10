---
-api-id: P:Windows.Networking.Sockets.ControlChannelTrigger.ServerKeepAliveIntervalInMinutes
-api-type: winrt property
---

<!-- Property syntax
public uint ServerKeepAliveIntervalInMinutes { get;  set; }
-->

# Windows.Networking.Sockets.ControlChannelTrigger.ServerKeepAliveIntervalInMinutes

## -description
Get or set the server keep-alive interval, in minutes, registered with the system to indicate when the app and associated network connections used should wake up. 

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -property-value
The server keep-alive interval, in minutes, registered with the system to indicate when the app and associated network connections used should wake up.

## -remarks
The minimum value that can be set for this property is 15 minutes. The maximum value that can be set for this property is 1439 minutes (approximately 24 hours).

An app should set this to the maximum interval that works with the target network service.

## -examples

## -see-also
