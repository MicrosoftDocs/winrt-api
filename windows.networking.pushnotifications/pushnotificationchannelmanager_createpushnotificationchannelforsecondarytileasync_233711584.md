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
[Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to update a badge through push notifications](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](http://msdn.microsoft.com/library/363b8b46-b494-44c9-b086-7f03c38212f7), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)