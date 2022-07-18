---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForSecondaryTileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(System.String tileId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManager.CreatePushNotificationChannelForSecondaryTileAsync

## -description
Creates an object, bound to a [secondary tile](../windows.ui.startscreen/secondarytile.md), through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The tile can be a secondary tile of the calling app or any other app in the same package.

## -parameters
### -param tileId
The ID of the secondary tile to bind to the push notification channel.

## -returns
The object, bound to the secondary tile, that is used to request a [PushNotificationChannel](pushnotificationchannel.md) from the Windows Push Notification Services (WNS).

## -remarks
> [!NOTE]
> Channels bound to secondary tiles only accept push notifications for **Tile** and **Badge** update types.

## -examples
This example shows the use of this method to retrieve a push notification channel for a secondary tile.

```javascript

var pushNotifications = Windows.Networking.PushNotifications;
var channel;

pushNotifications.PushNotificationChannelManager.createPushNotificationChannelForSecondaryTileAsync(myTileId).then(function (channel) {
    // Your code here.
})
```



## -see-also
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)
