---
-api-id: T:Windows.Media.Capture.AppBroadcastSignInResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.AppBroadcastSignInResult : int
-->

# AppBroadcastSignInResult

## -description
Specifies the result of a sign-in operation.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields
### -field Success:0
The sign-in was successful.

### -field AuthenticationFailed:1
The sign-in authentication failed.

### -field Unauthorized:2
The authenticated user does not have permission to access to the requested resource.

### -field ServiceUnavailable:3
The sign-in service is unavailable.

### -field Unknown:4
The sign-in result is unknown.


## -remarks
Get the result of a sign-in operation by handling the [AppBroadcastBackgroundServiceSignInInfo.SignInStateChanged](appbroadcastbackgroundservicesignininfo_signinstatechanged.md) event.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings