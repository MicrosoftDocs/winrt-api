---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.PushNotifications.PushNotificationType : int
-->

# PushNotificationType

## -description
The type of push notification that has been received from the app server. Used by the [NotificationType](pushnotificationreceivedeventargs_notificationtype.md) property.

## -enum-fields
### -field Toast:0
A push notification to display as toast.

### -field Tile:1
A push notification to update one or more elements of a tile.

### -field Badge:2
A push notification to update a tile's badge overlay.

### -field Raw:3
A push notification to perform an update to a tile that does not involve UI.

### -field TileFlyout:4
A push notification to update an app's tile flyout.


## -remarks

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](https://docs.microsoft.com/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](https://docs.microsoft.com/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities
internetClient
