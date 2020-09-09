---
-api-id: M:Windows.Networking.Sockets.ControlChannelTrigger.#ctor(System.String,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public ControlChannelTrigger(System.String channelId, System.UInt32 serverKeepAliveIntervalInMinutes)
-->

# Windows.Networking.Sockets.ControlChannelTrigger.ControlChannelTrigger

## -description
Creates a new [ControlChannelTrigger](controlchanneltrigger.md) object with a control channel trigger ID and a value for the server keep-alive interval. 

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -parameters
### -param channelId
A string used to differentiate various control channel triggers on the local computer. The maximum length allowed for this string is 64 characters.

### -param serverKeepAliveIntervalInMinutes
The keep-alive interval, in minutes, registered with the system to indicate when the app and network connections used should wake up.

The minimum value that can be set for this parameter is 15 minutes. The maximum value that can be set is 1439 minutes (approximately 24 hours).

## -remarks
The [ControlChannelTrigger(String, UInt32) constructor creates a [ControlChannelTrigger](controlchanneltrigger.md) object. By default, the resource type requested for the control channel trigger is a [ControlChannelTriggerResourceType](controlchanneltriggerresourcetype.md) set to **RequestSoftwareSlot**.

If an app needs a hardware slot to support connected standby, then the [ControlChannelTrigger(String, UInt32, ControlChannelTriggerResourceType)](controlchanneltrigger_controlchanneltrigger_2092736614.md) constructor should be used to create the [ControlChannelTrigger](controlchanneltrigger.md) object since this allows an app to specific the requested resource type.

## -examples

## -see-also
[How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)), [ControlChannelTrigger(String, UInt32, ControlChannelTriggerResourceType)](controlchanneltrigger_controlchanneltrigger_2092736614.md), [ControlChannelTriggerResourceType](controlchanneltriggerresourcetype.md)
