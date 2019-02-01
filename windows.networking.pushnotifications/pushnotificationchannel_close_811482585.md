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

Calling [Close](pushnotificationchannel_close_811482585.md) on a channel invalidates the underlying URI as well as any non-expired, non-closed URIs previously created for the app.

## -examples

## -see-also
[Windows Push Notification Services (WNS) overview](https://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [How to authenticate with the Windows Push Notification Service (WNS)](https://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](https://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](https://msdn.microsoft.com/library/363b8b46-b494-44c9-b086-7f03c38212f7), [Push notification service request and response headers](https://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)

## -capabilities
internetClient
