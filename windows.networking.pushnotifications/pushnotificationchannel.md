---
-api-id: T:Windows.Networking.PushNotifications.PushNotificationChannel
-api-type: winrt class
---

<!-- Class syntax.
public class PushNotificationChannel : Windows.Networking.PushNotifications.IPushNotificationChannel
-->

# Windows.Networking.PushNotifications.PushNotificationChannel

## -description

Represents a delivery vehicle and addressing mechanism for push notifications.

The channel Uniform Resource Identifier (URI)represented by this interface is used by a third-party application server to communicate with the Windows Push Notification Services (WNS). The push notification channel is used by the client to intercept notifications.

## -remarks

This object is returned through an instance of the [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) interface which is returned through the [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_1900738870.md) method. When the asynchronous operation completes successfully, it returns the PushNotificationChannel object through a **then** or **done** method.

## -examples

## -see-also

[Windows Push Notification Services (WNS) overview](/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push and periodic notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample), [Quickstart: Sending a tile push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [How to authenticate with the Windows Push Notification Service (WNS)](/previous-versions/windows/apps/hh465407(v=win.10)), [How to request, create, and save a notification channel](/previous-versions/windows/apps/hh465412(v=win.10)), [Guidelines and checklist for push notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview), [Push notification service request and response headers](/previous-versions/windows/apps/hh465435(v=win.10))

## -capabilities

internetClient
