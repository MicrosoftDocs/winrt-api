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
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)

## -capabilities
internetClient
