---
-api-id: T:Windows.Networking.Sockets.IControlChannelTriggerResetEventDetails
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IControlChannelTriggerResetEventDetails : 
-->

# Windows.Networking.Sockets.IControlChannelTriggerResetEventDetails

## -description
An object instantiated by the background broker infrastructure for a **ControlChannelReset** event to indicate that a [ControlChannelTrigger](controlchanneltrigger.md) was reset. 

> [!NOTE]
> This interface is not supported on Windows Phone.

## -remarks
The [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md) object is instantiated by the background broker infrastructure for a [SystemTriggerType](../windows.applicationmodel.background/systemtriggertype.md) set to the **ControlChannelReset** event.

An app must register with the system event broker for a background task to receive a **ControlChannelReset** event. In the [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method of the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), the *taskInstance* parameter contains a [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md) that can be cast to the [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md) interface. The app can then use the [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md) object to determine the reason the [ControlChannelTrigger](controlchanneltrigger.md) was reset. The app can also use the [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md) object to determine if a hardware slot or a software slot is affected by the **ControlChannelReset** event.

> [!NOTE]
> An app must be placed on the lock screen before it can successfully register a background task using the [SystemTriggerType](../windows.applicationmodel.background/systemtriggertype.md) set to the **ControlChannelReset** event.

## -examples

## -see-also
[ControlChannelTrigger](controlchanneltrigger.md), [ControlChannelTriggerResetReason](controlchanneltriggerresetreason.md), [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md), [SystemTriggerType](../windows.applicationmodel.background/systemtriggertype.md)