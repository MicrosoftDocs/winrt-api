---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.EnableTransferOwnership(System.Guid,Windows.Networking.Sockets.SocketActivityConnectedStandbyAction)
-api-type: winrt method
---

<!-- Method syntax
public void EnableTransferOwnership(System.Guid taskId, Windows.Networking.Sockets.SocketActivityConnectedStandbyAction connectedStandbyAction)
-->

# Windows.Networking.Sockets.StreamSocketListener.EnableTransferOwnership

## -description
Enables your app's background task to be triggered by the socket broker when traffic for this [StreamSocketListener](streamsocketlistener.md) arrives while the system is in connected standby.

## -parameters
### -param taskId
The [IBackgroundTaskRegistration.TaskId](../windows.applicationmodel.background/ibackgroundtaskregistration_taskid.md) of the background task that will be triggered by the socket broker when traffic arrives for this [StreamSocketListener](streamsocketlistener.md).

### -param connectedStandbyAction
Specifies whether to enable or disable the activation of the background task when traffic arrives.

## -remarks

## -examples

## -see-also
[EnableTransferOwnership(Guid)](streamsocketlistener_enabletransferownership_102493121.md)