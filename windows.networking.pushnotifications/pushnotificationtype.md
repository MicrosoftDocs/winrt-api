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
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)

## -capabilities
internetClient
