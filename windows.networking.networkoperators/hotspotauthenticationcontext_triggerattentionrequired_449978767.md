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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

Windows will launch the specified application.

## -parameters
### -param packageRelativeApplicationId
The foreground application ID within its application package. The application must belong to the same package as the background task handler.

### -param applicationParameters
Optional command line parameters that are passed to the application at launch.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
