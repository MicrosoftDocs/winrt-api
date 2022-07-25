---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync()
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync

## -description
Creates an object, bound to the calling app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS).

## -returns
The object, bound to the calling app, that is used to request a [PushNotificationChannel](pushnotificationchannel.md) from the Windows Push Notification Services (WNS).

## -remarks
Tile update, toast, and badge notifications that arrive on this channel are delivered to the app's main or default tile.

An exception is thrown if you attempt to register a WNS push notification channel when there is no data connection.

## -examples
The following example shows the use of this method to retrieve a channel for the calling app.

```javascript

var pushNotifications = Windows.Networking.PushNotifications;
var channel;

function openNotificationsChannel() {
    var channelOperation = pushNotifications.PushNotificationChannelManager.createPushNotificationChannelForApplicationAsync();
    return channelOperation.then(function (newChannel) {
        channel = newChannel;
    }
);
```

## -see-also
[CreatePushNotificationChannelForApplicationAsync(String)](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_1900738870.md), [Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)
