---
-api-id: M:Windows.Media.Protection.PlayReady.NDClient.LicenseFetchAsync(Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Protection.PlayReady.INDLicenseFetchResult> LicenseFetchAsync(Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor licenseFetchDescriptor)
-->

# Windows.Media.Protection.PlayReady.NDClient.LicenseFetchAsync

## -description
Performs a license fetch between a client receiver and a transmitter.

## -parameters
### -param licenseFetchDescriptor
Descriptor for the license being fetched.

## -returns
The result of the asynchronous license fetch call.

## -remarks
Apps typically call this method during key rotation for new root licenses.

## -examples

## -see-also
[INDLicenseFetchResult](indlicensefetchresult.md)