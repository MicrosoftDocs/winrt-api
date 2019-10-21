---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationChannelManager
-api-type: winrt class
---

<!-- Class syntax.
public class PushNotificationChannelManager 
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManager

## -description
Creates objects that you use to retrieve push notification channels from the Windows Push Notification Services (WNS). These channels are bound to an app or [secondary tile](../windows.ui.startscreen/secondarytile.md).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetForUser |
| 1703 | 15063 | GetDefault |

## -examples
The following example shows the use of the [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_684392470.md) method to retrieve a push notification channel for the calling app.

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

The following example shows the use of the [CreatePushNotificationChannelForSecondaryTileAsync](pushnotificationchannelmanager_createpushnotificationchannelforsecondarytileasync_233711584.md) method to retrieve a push notification channel for a secondary tile.

```javascript

var pushNotifications = Windows.Networking.PushNotifications;
var channel;

pushNotifications.PushNotificationChannelManager.createPushNotificationChannelForSecondaryTileAsync(myTileId).then(function (channel) {
    // Your code here.
})
```

## -see-also
[PushNotificationChannel](pushnotificationchannel.md), [Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
