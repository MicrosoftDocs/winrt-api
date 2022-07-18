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
[Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview), [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a push notification](/windows/apps/design/shell/tiles-and-notifications/quickstart-send-push-notification), [How to request, create, and save a notification channel](/windows/apps/design/shell/tiles-and-notifications/request-create-save-notification-channel), [Push notification service request and response headers](/windows/apps/design/shell/tiles-and-notifications/push-request-response-headers)

## -capabilities
internetClient
