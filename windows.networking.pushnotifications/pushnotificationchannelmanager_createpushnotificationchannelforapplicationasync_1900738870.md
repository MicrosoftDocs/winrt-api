---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(System.String applicationId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync

## -description
Creates an object, bound to a specified app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app. This overload should only be called from a multi-app package, most apps should use the method with no parameter. 

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app to bind to the push notification channel. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
The object, bound to the app specified in *applicationId*, that is used to request a [PushNotificationChannel](pushnotificationchannel.md) from the Windows Push Notification Services (WNS).

## -remarks
Tile update, toast, and badge notifications that arrive on this channel are delivered to the app's main or default tile.

An exception is thrown if you attempt to register a WNS push notification channel when there is no data connection.

## -examples

## -see-also
[CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_684392470.md), [Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](/windows/uwp/controls-and-patterns/tiles-and-notifications-sending-a-local-tile-notification), [Quickstart: Sending a toast push notification](/windows/uwp/controls-and-patterns/tiles-and-notifications-adaptive-interactive-toasts), [How to update a badge through push notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-badges), [How to authenticate with the Windows Push Notification Service (WNS)](/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-sending-a-local-tile-notification), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)
