---
-api-id: M:Windows.Devices.PointOfService.Provider.BarcodeScannerHideVideoPreviewRequest.ReportFailedAsync(System.Int32,System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction BarcodeScannerHideVideoPreviewRequest.ReportFailedAsync(Int32 reason, String failedReasonDescription)
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerHideVideoPreviewRequest.ReportFailedAsync

## -description
Notifies the client that the request was not processed successfully.

## -parameters
### -param reason
An **Int32** error code that will be converted to an HRESULT and raised as an exception in the calling application. The following values are supported:

<table>
   <tr><td>Name</td><td>Value</td><td>Description</td></tr>
   <tr><td>E_ABORT</td><td>0x80004004</td><td>Operation aborted</td></tr>
   <tr><td>E_ACCESSDENIED</td><td>0x80070005</td><td>General access denied error</td></tr>
   <tr><td>E_APPLICATION_EXITING</td><td>0x8000001a</td><td>The application is exiting and cannot service this request</td></tr>
   <tr><td>E_BOUNDS</td><td>0x8000000b</td><td>The operation attempted to access data outside the valid range</td></tr>
   <tr><td>E_ILLEGAL_METHOD_CALL</td><td>0x8000000e</td><td>A method was called at an unexpected time</td></tr>
   <tr><td>E_INVALIDARG</td><td>0x80070057</td><td>One or more arguments are invalid</td></tr>
   <tr><td>E_FAIL</td><td>0x80004005</td><td>Unspecified error</td></tr>
   <tr><td>E_NOTIMPL</td><td>0x80004001</td><td>Not implemented</td></tr>
   <tr><td>E_OUTOFMEMORY</td><td>0x8007000e</td><td>Ran out of memory</td></tr>
</table>

### -param failedReasonDescription
A description of what caused the failure, for use in debugging.

## -returns
An asynchronous operation.

## -remarks
This method should be called if the provider app is unable to complete the operation.

## -see-also

## -examples

