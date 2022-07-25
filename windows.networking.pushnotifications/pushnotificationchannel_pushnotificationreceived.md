---
-api-id: E:Windows.Networking.PushNotifications.PushNotificationChannel.PushNotificationReceived
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PushNotificationReceived<Windows.Networking.PushNotifications.PushNotificationChannel,  Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>
-->

# Windows.Networking.PushNotifications.PushNotificationChannel.PushNotificationReceived

## -description
Raised when a push notification arrives on this channel.

## -remarks
Windows Push Notification Services (WNS) sends this event only when the notification's target app is in the foreground. If the app is suspended, it does not receive the event.

## -examples
The following example shows a listener for this event, which invokes the event handler.

```javascript

function listeningForPushNotification() {
    if (channel) {
        channel.addEventListener("pushnotificationreceived", pushNotificationReceivedHandler);
}
```

## -see-also
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)

## -capabilities
internetClient
