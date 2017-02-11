---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreatePushNotificationChannelForSecondaryTileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(System.String tileId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreatePushNotificationChannelForSecondaryTileAsync

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

## -see-also
