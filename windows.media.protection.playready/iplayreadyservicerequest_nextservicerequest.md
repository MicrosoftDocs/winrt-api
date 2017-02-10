---
-api-id: M:Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.NextServiceRequest
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest NextServiceRequest()
-->

# Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.NextServiceRequest

## -description
Returns a new service request interface.

## -returns
The new service request interface.

## -remarks
This method should only be called after:
+ A completion event from the [IAsyncAction](../windows.foundation/iasyncaction.md) object returned from [BeginServiceRequest](iplayreadyservicerequest_beginservicerequest.md) has indicated the current service request is complete (automatic enabling).
+ A call to [ProcessManualEnablingResponse](iplayreadyservicerequest_processmanualenablingresponse.md) (manual enabling).


Both of the above situations leave the current service request in a read-only/complete state, although there could be additional service requests to perform. An app should call this method to determine if additional service requests are required.

## -examples

## -see-also
