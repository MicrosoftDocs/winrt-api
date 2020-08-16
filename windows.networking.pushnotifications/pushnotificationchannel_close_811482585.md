---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannel.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Networking.PushNotifications.PushNotificationChannel.Close

## -description
Explicitly invalidates this channel. Any notifications pushed to this channel after this method is called are not delivered.

## -remarks
After it has been closed, the channel can never be used again. Channels that are closed through this method are no different than channels that have expired. To resume sending push notifications to this app, the app must request a new channel.

Calling Close on a channel invalidates the underlying URI as well as any non-expired, non-closed URIs previously created for the app.

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
