---
-api-id: P:Windows.Networking.Sockets.IControlChannelTriggerEventDetails.ControlChannelTrigger
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.ControlChannelTrigger ControlChannelTrigger { get; }
-->

# Windows.Networking.Sockets.IControlChannelTriggerEventDetails.ControlChannelTrigger

## -description
Gets the [ControlChannelTrigger](controlchanneltrigger.md) object associated with an [IControlChannelTriggerEventDetails](icontrolchanneltriggereventdetails.md) object. 

> [!NOTE]
> The IControlChannelTriggerEventDetails interface is not supported on Windows Phone.

## -property-value
A [ControlChannelTrigger](controlchanneltrigger.md) object.

## -remarks
The background broker infrastructure instantiates an [IControlChannelTriggerEventDetails](icontrolchanneltriggereventdetails.md) object when a background task is initialized. Applications receive a reference to this object in the [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method of the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md). Applications can use the [ControlChannelTrigger](icontrolchanneltriggereventdetails.md) property to retrieve the [ControlChannelTrigger](controlchanneltrigger.md) object associated with the control channel trigger event. This allows an application to map a specific control channel trigger event to a specific [ControlChannelTrigger](controlchanneltrigger.md) object and any other associated objects such as the [StreamSocket](streamsocket.md) object on which an application has registered to enable real-time network status and triggers.

## -examples

## -see-also
