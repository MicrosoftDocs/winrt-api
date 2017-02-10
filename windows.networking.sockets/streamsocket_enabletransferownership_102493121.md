---
-api-id: M:Windows.Networking.Sockets.StreamSocket.EnableTransferOwnership(System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public void EnableTransferOwnership(System.Guid taskId)
-->

# Windows.Networking.Sockets.StreamSocket.EnableTransferOwnership

## -description
Enables your app's background task to be triggered by the socket broker when traffic for this [StreamSocket](streamsocket.md) arrives while the app is not active.

## -parameters
### -param taskId
The [IBackgroundTaskRegistration.TaskId](../windows.applicationmodel.background/ibackgroundtaskregistration_taskid.md) of the background task that will be triggered by the socket broker when traffic arrives for this [StreamSocket](streamsocket.md).

## -remarks

## -examples

## -see-also
[EnableTransferOwnership(Guid, SocketActivityConnectedStandbyAction)](streamsocket_enabletransferownership_452874301.md)