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

An exception is thrown if you attempt to register a WNS push notification channel when there is no data connection. For a list of error codes that can be received, see [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync.md).

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
[CreatePushNotificationChannelForApplicationAsync(String)](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_1900738870.md), [Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_tile_push), [Quickstart: Sending a toast push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_toast_push), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](XREF:TODO:m_ui_tiles.guidelines_for_push_notifications), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)