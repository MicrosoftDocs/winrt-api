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

An application cannot provision a key credential until the user has successfully done the following:

+ Connected their user account to their Microsoft account.
+ Provided an unlock gesture (PIN or biometric) to protect the container that stores their key credential.


## -examples

## -see-also
