---
-api-id: M:Windows.Security.Credentials.KeyCredentialManager.IsSupportedAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsSupportedAsync()
-->

# Windows.Security.Credentials.KeyCredentialManager.IsSupportedAsync

## -description

Determines if the current device and user is capable of provisioning a key credential.

## -returns

When this method completes, it returns true if the current device and user is capable of provisioning a key credential. Otherwise, it returns false.

## -remarks

The `IsSupportedAsync` method checks if the current device and user can provision a key credential. This requires:

1. A Microsoft account linked to the user.
1. An unlock gesture (PIN or biometric) set up to protect the key container.


## -examples

## -see-also
