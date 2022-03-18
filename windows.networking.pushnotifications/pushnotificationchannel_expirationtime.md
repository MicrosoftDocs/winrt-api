---
-api-id: P:Windows.Networking.PushNotifications.PushNotificationChannel.ExpirationTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime ExpirationTime { get; }
-->

# Windows.Networking.PushNotifications.PushNotificationChannel.ExpirationTime

## -description
Gets the time at which the channel expires. Notifications sent to this channel after this time are rejected.

## -property-value
The time at which the channel expires. Notifications sent to this channel after this time are rejected.

## -remarks
To prevent a channel from expiring, apps should request a new push notification channel every time that the app is run.

An expired channel behaves as though it was closed. Because channels cannot be renewed, after a channel expires, a secondary tile or application must request a new push notification channel.

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
