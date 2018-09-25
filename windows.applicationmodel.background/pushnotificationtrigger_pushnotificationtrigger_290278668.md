---
-api-id: M:Windows.ApplicationModel.Background.PushNotificationTrigger.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public PushNotificationTrigger(System.String applicationId)
-->

# Windows.ApplicationModel.Background.PushNotificationTrigger.PushNotificationTrigger

## -description
Invokes a background work item on a specified app in response to the receipt of a [raw notification](../windows.networking.pushnotifications/rawnotification.md).

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -remarks

## -examples

## -see-also
