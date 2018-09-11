---
-api-id: M:Windows.Networking.Sockets.ControlChannelTrigger.WaitForPushEnabled
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Sockets.ControlChannelTriggerStatus WaitForPushEnabled()
-->

# Windows.Networking.Sockets.ControlChannelTrigger.WaitForPushEnabled

## -description
Allows an app to notify the system that a connection has been established and the system should complete the internal configuration of the control channel trigger. 

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -returns
A value that indicates if the system was able to complete configuration of a [ControlChannelTrigger](controlchanneltrigger.md) object.

## -remarks
Once an app is connected, it must call the [WaitForPushEnabled](controlchanneltrigger_waitforpushenabled_418123072.md) method in order to enable the system to complete the internal configuration of the control channel trigger. If an app tries to use the network trigger mechanism without calling the [WaitForPushEnabled](controlchanneltrigger_waitforpushenabled_418123072.md) method, it will get an exception.

This call to the [WaitForPushEnabled](controlchanneltrigger_waitforpushenabled_418123072.md) method is to be made only after the transport connection is established.

## -examples

## -see-also
