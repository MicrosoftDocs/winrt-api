---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.BeginServiceRequest
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BeginServiceRequest()
-->

# Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.BeginServiceRequest

## -description
Begins an asynchronous service request operation.

## -returns
The asynchronous service action.

## -remarks
Completion and results can be retrieved using the [IAsyncAction](../windows.foundation/iasyncaction.md) interface that is returned. Calling this method places the class in a read-only state.

If no data is available for metering, this method will return MSPR_E_NO_METERING_DATA_AVAILABLE.

## -examples

## -see-also
