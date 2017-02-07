---
-api-id: T:Windows.Media.Capture.AppBroadcastSignInState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.AppBroadcastSignInState : int
-->

# AppBroadcastSignInState

## -description
Specifies the current sign-in state for a broadcast app.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields
### -field NotSignedIn:0
The user is not signed in.

### -field MicrosoftSignInInProgress:1
A sign-in operation with the Microsoft service is in progress.

### -field MicrosoftSignInComplete:2
A sign-in operation with the Microsoft service is complete.

### -field OAuthSignInInProgress:3
A sign-in operation with the broadcast provider service is in progress.

### -field OAuthSignInComplete:4
A sign-in operation with the broadcast provider service is complete.


## -remarks
Get the current sign-in state by handling the [AppBroadcastBackgroundServiceSignInInfo.SignInStateChanged](appbroadcastbackgroundservicesignininfo_signinstatechanged.md) event.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings







