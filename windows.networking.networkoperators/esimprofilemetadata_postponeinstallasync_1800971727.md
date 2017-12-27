---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfileMetadata.PostponeInstallAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESimProfileMetadata.PostponeInstallAsync()
-->

# Windows.Networking.NetworkOperators.ESimProfileMetadata.PostponeInstallAsync

## -description
Asynchronously postpones the installation of an eSIM profile.

## -returns

## -remarks
An eSIM profile whose installation has been postponed is still reserved at the profile server. You can choose not to process the result of this asynchronous operation, since its purpose is to postpone installation. But an error can be the result of a timeout or a bad connection with the profile server. Any such error condition will effectively postpone the install.

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe