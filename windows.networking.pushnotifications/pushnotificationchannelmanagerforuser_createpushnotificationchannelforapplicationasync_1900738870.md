---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(System.String applicationId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync

## -description
Creates an object, bound to a specified app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.

## -parameters
### -param applicationId
The Package Relative Application ID (PRAID) of the app to bind to the push notification channel.

## -returns
The object, bound to the app specified in *applicationId*, that is used to request a [PushNotificationChannel](pushnotificationchannel.md) from the Windows Push Notification Services (WNS).

## -remarks

## -examples

## -see-also
[CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanagerforuser_createpushnotificationchannelforapplicationasync_684392470.md)