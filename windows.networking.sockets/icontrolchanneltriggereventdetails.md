---
-api-id: T:Windows.Networking.Sockets.IControlChannelTriggerEventDetails
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IControlChannelTriggerEventDetails : 
-->

# Windows.Networking.Sockets.IControlChannelTriggerEventDetails

## -description
An object instantiated by the background broker infrastructure that is used to differentiate control channel triggers. 

> [!NOTE]
> This interface is not supported on Windows Phone.

## -remarks
The background broker infrastructure instantiates an object of this type when a background task is initialized. Applications receive a reference to this object in the [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method of the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md). Applications can use the [ControlChannelTrigger](icontrolchanneltriggereventdetails.md) property on the [IControlChannelTriggerEventDetails](icontrolchanneltriggereventdetails.md) object to retrieve the [ControlChannelTrigger](controlchanneltrigger.md) object associated with the control channel trigger event. This allows an application to map a specific control channel trigger event to a specific [ControlChannelTrigger](controlchanneltrigger.md) object and any other associated objects such as the [StreamSocket](streamsocket.md) object on which an application has registered to enable real-time network status and triggers.

## -examples

## -see-also
[ControlChannelTrigger](controlchanneltrigger.md), [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), [StreamSocket](streamsocket.md)