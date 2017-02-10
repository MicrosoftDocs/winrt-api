---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyDomainLeaveServiceRequest.ProcessManualEnablingResponse(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.HResult ProcessManualEnablingResponse(System.Byte[] responseBytes)
-->

# Windows.Media.Protection.PlayReady.PlayReadyDomainLeaveServiceRequest.ProcessManualEnablingResponse

## -description
Process the raw binary result of a manual enabling challenge.

## -parameters
### -param responseBytes
The response result to be processed.

## -returns
If the methods succeeds, it returns S_OK. If it fails, it returns an error code.

## -remarks
The return value of this method is a failure only if the input data is invalid in some way. If the result is processed successfully but has a failure state, this method will return that failure in the result parameter.

The most common values to be returned in the result parameter are:


+ S_OK—The enabling response was processed and there are no more service requests necessary. A following call to [NextServiceRequest](playreadydomainleaveservicerequest_nextservicerequest.md) will return a **NULL** pointer.
+ MSPR_E_CONTENT_ENABLING_ACTION_REQUIRED—A new service request was generated when processing the current service request. A call to **NextServiceRequest** should be made.
+ DRM_E_SERVER_SERVICE_SPECIFIC—A PlayReady license or domain server failed.
+ MSPR_E_SDK_UPDATE_REQUIRED—The individualization service requires a client SDK update before a new individualization operation can complete. Refreshing the PlayReady SDK is required.


## -examples

## -see-also
