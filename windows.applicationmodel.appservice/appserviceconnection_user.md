---
-api-id: P:Windows.ApplicationModel.AppService.AppServiceConnection.User
-api-type: winrt property
---

<!-- Property syntax
public Windows.System.User User { get;  set; }
-->

# Windows.ApplicationModel.AppService.AppServiceConnection.User

## -description
Gets/sets the user context. This property returns **null** if the caller did not specify a user.

## -property-value
The user of the app service.

## -remarks
This property is set by the caller. Callers that have the multi-user manifest entry must set this property even if the app is not running on a multi-user platform.

## -examples

## -see-also
