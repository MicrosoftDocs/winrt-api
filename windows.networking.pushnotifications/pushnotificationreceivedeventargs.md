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
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)

## -capabilities
internetClient
