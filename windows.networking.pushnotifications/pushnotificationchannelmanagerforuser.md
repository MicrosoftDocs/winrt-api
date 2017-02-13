---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser
-api-type: winrt class
---

<!-- Class syntax.
public class PushNotificationChannelManagerForUser : Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser, Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser2
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser

## -description
Creates objects that you use to retrieve push notification channels from the Windows Push Notification Services (WNS). These channels are bound to the current user through an app or [secondary tile](../windows.ui.startscreen/secondarytile.md).

## -remarks
This class does not have a constructor. For more information about usage, see the examples section.

## -examples
The following example shows the use of the [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanagerforuser_createpushnotificationchannelforapplicationasync_1900738870.md) method to retrieve a push notification channel for the calling app.

```javascript

var pushNotifications = Windows.Networking.PushNotifications;
var channel;

function openNotificationsChannel() {
    var channelOperation = pushNotifications.PushNotificationChannelManagerForUser.createPushNotificationChannelForApplicationAsync();
    return channelOperation.then(function (newChannel) {
        channel = newChannel;
    }
);
```

The following example shows the use of the [CreatePushNotificationChannelForSecondaryTileAsync](pushnotificationchannelmanagerforuser_createpushnotificationchannelforsecondarytileasync.md) method to retrieve a push notification channel for a secondary tile.

```javascript

var pushNotifications = Windows.Networking.PushNotifications;
var channel;

pushNotifications.PushNotificationChannelManagerForUser.createPushNotificationChannelForSecondaryTileAsync(myTileId).then(function (channel) {
    // Your code here.
})
```



## -see-also
