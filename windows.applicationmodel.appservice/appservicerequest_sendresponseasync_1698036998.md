---
-api-id: M:Windows.ApplicationModel.AppService.AppServiceRequest.SendResponseAsync(Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.AppService.AppServiceResponseStatus> SendResponseAsync(Windows.Foundation.Collections.ValueSet message)
-->

# Windows.ApplicationModel.AppService.AppServiceRequest.SendResponseAsync

## -description
Sends a response to a received request.

## -parameters
### -param message
The message that you want to include in the response.

## -returns
An asynchronous operation to send the response.

## -remarks
Calling [AppServiceRequest](appservicerequest.md) is optional. An endpoint for an app service does not have to return a response to a request.

## -examples

## -see-also
[AppServiceResponseStatus](appserviceresponsestatus.md), [IAsyncOperation](../windows.foundation/iasyncoperation_1.md)