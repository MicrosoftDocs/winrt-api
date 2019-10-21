---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs
-api-type: winrt class
ms.custom: 19H1
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
[Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
