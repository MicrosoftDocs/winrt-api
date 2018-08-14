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
This object is returned through an instance of the [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) interface which is returned through the [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanager_createpushnotificationchannelforapplicationasync_1900738870.md) method. When the asynchronous operation completes successfully, it returns the [PushNotificationChannel](pushnotificationchannel.md) object through a **then** or **done** method.

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to update a badge through push notifications](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](http://msdn.microsoft.com/library/363b8b46-b494-44c9-b086-7f03c38212f7), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)

## -capabilities
internetClient
