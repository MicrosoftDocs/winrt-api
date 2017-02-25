---
-api-id: P:Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs.RawNotification
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.PushNotifications.RawNotification RawNotification { get; }
-->

# Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs.RawNotification

## -description
Gets the app-defined content contained in this push notification, the contents of which are used to perform a background task on the app.

## -property-value
Encapsulates the app-defined content of the raw notification. If [NotificationType](pushnotificationreceivedeventargs_notificationtype.md) is not of type **Raw**, this value is **NULL**.

## -remarks

## -examples

## -see-also
[RawNotification](rawnotification.md), [Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](http://msdn.microsoft.com/library/363b8b46-b494-44c9-b086-7f03c38212f7), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca), [RawNotification](rawnotification.md)