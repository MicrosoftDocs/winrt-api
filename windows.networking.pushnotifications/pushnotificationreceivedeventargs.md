---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PushNotificationReceivedEventArgs : Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs
-->

# Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs

## -description
Encapsulates a push notification that has been received from the app server, identifying the type and supplying the content of the notification. Windows passes this information in the [PushNotificationReceived](pushnotificationchannel_pushnotificationreceived.md) event.

## -remarks
Your app receives this class when processing the [PushNotificationReceived](pushnotificationchannel_pushnotificationreceived.md) event.

## -examples
The following example shows the members of this class in use.

```javascript

function listeningForPushNotification() {
    if (channel) {
        channel.addEventListener("pushnotificationreceived", pushNotificationReceivedHandler);
}

function pushNotificationReceivedHandler(e) {
    var notificationTypeName = "";
    var notificationPayload;
    switch (e.notificationType) {
        // You can get the toast, tile, or badge notification object.
        // In this example, we take the XML from the notification.
        case pushNotifications.PushNotificationType.toast:
            notificationTypeName = "Toast";
            notificationPayload = e.toastNotification.content.getXml();
            break;
        case pushNotifications.PushNotificationType.tile:
            notificationTypeName = "Tile";
            notificationPayload = e.tileNotification.content.getXml();
            break;
        case pushNotifications.PushNotificationType.badge:
            notificationTypeName = "Badge";
            notificationPayload = e.badgeNotification.content.getXml();
            break;
    }
    e.cancel = true;
}
```



## -see-also
[Windows Push Notification Services (WNS) overview](https://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to authenticate with the Windows Push Notification Service (WNS)](https://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](https://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](https://msdn.microsoft.com/library/363b8b46-b494-44c9-b086-7f03c38212f7), [Push notification service request and response headers](https://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)

## -capabilities
internetClient
