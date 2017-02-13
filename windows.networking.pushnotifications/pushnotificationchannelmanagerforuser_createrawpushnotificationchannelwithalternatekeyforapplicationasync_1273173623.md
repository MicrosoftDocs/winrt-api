---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(Windows.Storage.Streams.IBuffer,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(IBuffer appServerKey, String channelId, String appId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync

## -description
Creates an object bound to a specified app through which you retrieve a push notificaiton channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.

## -parameters

### -param appServerKey
The key for the application server that sends push notifications.

### -param channelId
The ID of the push notification channel.

### -param appId
The Package Relative Application ID of the app to bind to the push notification channel.

## -returns
The object, bound to the app server specified in appServerKey, that is used to request a [PushNotificationChannel](PushNotificationChannel.md) from WNS.

## -remarks

## -see-also

## -examples

