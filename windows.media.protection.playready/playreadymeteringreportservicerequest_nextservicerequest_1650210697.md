---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.NextServiceRequest
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest NextServiceRequest()
-->

# Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.NextServiceRequest

## -description
Returns a new service request interface.

## -returns
The new service request interface.

## -remarks
This method should only be called after a completion event from the [IAsyncAction](../windows.foundation/iasyncaction.md) object returned from [BeginServiceRequest](playreadymeteringreportservicerequest_beginservicerequest.md) has indicated the current service request is complete (automatic enabling). This situation leaves the current service request in a read-only/complete state, although there could be additional service requests to perform. An app should call this method to determine if additional service requests are required.

If no data is available for metering, this method will return MSPR_E_NO_METERING_DATA_AVAILABLE.

## -examples

## -see-also
