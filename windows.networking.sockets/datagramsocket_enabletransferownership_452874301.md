---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.EnableTransferOwnership(System.Guid,Windows.Networking.Sockets.SocketActivityConnectedStandbyAction)
-api-type: winrt method
---

<!-- Method syntax
public void EnableTransferOwnership(System.Guid taskId, Windows.Networking.Sockets.SocketActivityConnectedStandbyAction connectedStandbyAction)
-->

# Windows.Networking.Sockets.DatagramSocket.EnableTransferOwnership

## -description
Enables your app's background task to be triggered by the socket broker when traffic for this [DatagramSocket](datagramsocket.md) arrives while the system is in connected standby.

## -parameters
### -param taskId
The [IBackgroundTaskRegistration.TaskId](../windows.applicationmodel.background/ibackgroundtaskregistration_taskid.md) of the background task that will be triggered by the socket broker when traffic arrives for this [DatagramSocket](datagramsocket.md).

### -param connectedStandbyAction
Specifies whether to enable or disable the activation of the background task when traffic arrives.

## -remarks

## -examples

## -see-also
[EnableTransferOwnership(Guid)](datagramsocket_enabletransferownership_102493121.md)