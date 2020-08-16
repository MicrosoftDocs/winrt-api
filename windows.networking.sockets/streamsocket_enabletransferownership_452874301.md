---
-api-id: M:Windows.Networking.Sockets.StreamSocket.EnableTransferOwnership(System.Guid,Windows.Networking.Sockets.SocketActivityConnectedStandbyAction)
-api-type: winrt method
---

<!-- Method syntax
public void EnableTransferOwnership(System.Guid taskId, Windows.Networking.Sockets.SocketActivityConnectedStandbyAction connectedStandbyAction)
-->

# Windows.Networking.Sockets.StreamSocket.EnableTransferOwnership

## -description
Enables or disables the ability of your app's background task to be triggered by the socket broker when traffic for this [StreamSocket](streamsocket.md) arrives while the system is in connected standby.

## -parameters

### -param taskId

The [IBackgroundTaskRegistration.TaskId](../windows.applicationmodel.background/ibackgroundtaskregistration_taskid.md) of the background task being enabled or disabled.

### -param connectedStandbyAction

Specifies whether to enable or disable the activation of the background task when traffic arrives.

## -remarks

The most common cause of an exception with a code of 0x80070490 and a message of "Element not found" is that your system doesn't support connected standby. You can verify that by calling `EnableTransferOwnership(taskId, SocketActivityConnectedStandbyAction.DoNotWake)`. If that alternate call succeeds without throwing an exception, then that confirms that the original exception is caused by the system not being set up for connected standby. And that's a condition that your code will need to handle.

The API calling pattern that we recommend is to call `EnableTransferOwnership(taskId, SocketActivityConnectedStandbyAction.Wake)`. If you experience the exception described above, then re-try the call with **SocketActivityConnectedStandbyAction.DoNotWake**.

## -examples

## -see-also

[EnableTransferOwnership(Guid)](streamsocket_enabletransferownership_102493121.md)