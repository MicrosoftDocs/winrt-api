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
[Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
