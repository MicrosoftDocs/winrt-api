---
-api-id: M:Windows.ApplicationModel.AppService.AppServiceConnection.SendStatelessMessageAsync(Windows.ApplicationModel.AppService.AppServiceConnection,Windows.System.RemoteSystems.RemoteSystemConnectionRequest,Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperation<StatelessAppServiceResponse> AppServiceConnection.SendStatelessMessageAsync(AppServiceConnection connection, RemoteSystemConnectionRequest connectionRequest, ValueSet message)
-->

# Windows.ApplicationModel.AppService.AppServiceConnection.SendStatelessMessageAsync

## -description
Opens an app service connection, sends a single message, waits for a single response, and then closes the connection.

## -parameters
### -param connection
The app service to connect to.

### -param connectionRequest
Specifies the connection preferences for the AppServiceConnection, such as transport preferences (cloud/proximal/any) as well as the target System.RemoteSystems object.

### -param message
The message that you want to send.

## -returns
An asynchronous operation to send the message that optionally returns a response message when complete.

## -remarks
This API can optimize latency for remote app service scenarios which do not require state to be built up over several SendMessageAsync operations.

## -see-also

## -examples

