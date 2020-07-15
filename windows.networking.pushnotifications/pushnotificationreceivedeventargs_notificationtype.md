---
-api-id: P:Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs.NotificationType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.PushNotifications.PushNotificationType NotificationType { get; }
-->

# Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs.NotificationType

## -description
Gets the type of push notification that has been received from the app server.

## -property-value
The type (badge, tile, toast, or raw) of push notification that has been received.

## -remarks
Channels bound to secondary tiles will only accept push notifications for **Tile** and **Badge** updates. **Toast** and **Raw** notifications must use a channel bound to an application.

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
