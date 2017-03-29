---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TriggerAttentionRequired(System.String,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void TriggerAttentionRequired(System.String packageRelativeApplicationId, System.String applicationParameters)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TriggerAttentionRequired

## -description
Called by a background task handler to launch the foreground application when there is an authentication attempt to complete.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

Windows will launch the specified application.

## -parameters
### -param packageRelativeApplicationId
The foreground application ID within its application package. The application must belong to the same package as the background task handler.

### -param applicationParameters
Optional command line parameters that are passed to the application at launch.

## -remarks

## -examples

## -see-also
