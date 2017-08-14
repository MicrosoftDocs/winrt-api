---
-api-id: M:Windows.Networking.Vpn.IVpnChannelStatics.ProcessEventAsync(System.Object,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void ProcessEventAsync(System.Object thirdPartyPlugIn, System.Object event)
-->

# Windows.Networking.Vpn.IVpnChannelStatics.ProcessEventAsync

## -description
A VPN plug-in must always call this function in its background tasks Run() method.

## -parameters
### -param thirdPartyPlugIn
The plug-in to be processed.

### -param event
The event object that was passed to the app from a background task **Run** method parameter. App code calling [ProcessEventAsync](vpnchannel_processeventasync.md) treats this object as an opaque blob it is passing from the background task to the event processing code. (In the event processing code, the object will be understood and parsed appropriately.)

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
