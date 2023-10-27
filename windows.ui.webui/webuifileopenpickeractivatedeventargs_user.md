---
-api-id: P:Windows.UI.WebUI.WebUIFileOpenPickerActivatedEventArgs.User
-api-type: winrt property
---

<!-- Property syntax
public Windows.System.User User { get; }
-->

# Windows.UI.WebUI.WebUIFileOpenPickerActivatedEventArgs.User

## -description
Gets the user that the app was activated for.

## -property-value
The user that the app was activated for.

## -remarks
This property returns the logged-in user on platforms that only support single-user sessions. For platforms that support multiple users in a session, this property returns the logged-in user that the app was activated for.

This property returns **null** when a multi-user application is activated with no specific user context.

Multi-user apps can use this property to allow or restrict app behavior. For example, you might restrict access to content or features based on the user’s credentials.

## -examples

## -see-also
