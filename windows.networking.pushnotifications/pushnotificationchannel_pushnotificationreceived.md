---
-api-id: E:Windows.Networking.PushNotifications.PushNotificationChannel.PushNotificationReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PushNotificationReceived<Windows.Networking.PushNotifications.PushNotificationChannel,  Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>
-->

# Windows.Networking.PushNotifications.PushNotificationChannel.PushNotificationReceived

## -description
Fires when a push notification has arrived on this channel.
<!-- @WRITER erictill 10/21/2011 : Running apps subscribe to this event and call <xref rid="w_net_pushnotif.pushnotificationreceivedeventhandler" targtype="delegate">PushNotificationReceivedEventHandler</xref>in response. -->

## -remarks
Windows Push Notification Services (WNS) sends this event only when the notification's target app is in the foreground. If the app is suspended, it does not receive the event.

## -examples
The following example shows a listener for this event, which invokes the event handler.

```javascript

function listeningForPushNotification() {
    if (channel) {
        channel.addEventListener("pushnotificationreceived", pushNotificationReceivedHandler);
}
```



## -see-also
[Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_tile_push), [Quickstart: Sending a toast push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_toast_push), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](XREF:TODO:m_ui_tiles.guidelines_for_push_notifications), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)

## -capabilities
internetClient