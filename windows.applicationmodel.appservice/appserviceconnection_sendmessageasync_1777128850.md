---
-api-id: M:Windows.ApplicationModel.AppService.AppServiceConnection.SendMessageAsync(Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.AppService.AppServiceResponse> SendMessageAsync(Windows.Foundation.Collections.ValueSet message)
-->

# Windows.ApplicationModel.AppService.AppServiceConnection.SendMessageAsync

## -description
Sends a message to the other endpoint of the app service connection.

## -parameters
### -param message
The message that you want to send.

## -returns
An asynchronous operation to send the message that optionally returns a response message when complete.

## -remarks

Message delivery is not  guaranteed. The [AppServiceResponseStatus](appserviceresponsestatus.md) tells you whether delivery succeeded or not.

When multiple messages are sent, [RequestReceived](appserviceconnection_requestreceived.md) is not guaranteed to fire in the same order that the messages were sent. This method is asynchronous, meaning that it will return whenever the work that needs to be done is complete. No ordering is enforced.

## -examples

## -see-also

[ValueSet](../windows.foundation.collections/valueset.md), [IAsyncOperation](../windows.foundation/iasyncoperation_1.md), [AppServiceResponse](appserviceresponse.md)