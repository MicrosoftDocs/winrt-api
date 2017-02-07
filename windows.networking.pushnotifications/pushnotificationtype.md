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
[Windows Push Notification Services (WNS) overview](http://msdn.microsoft.com/library/2125b09f-db90-4515-9aa6-516c7e9acccd), [Push and periodic notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231476), [Quickstart: Sending a tile push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_tile_push), [Quickstart: Sending a toast push notification](XREF:TODO:m_ui_tiles.quickstart_sending_a_toast_push), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [How to authenticate with the Windows Push Notification Service (WNS)](http://msdn.microsoft.com/library/15975fe8-5e63-4d5d-b885-c4113c86b20e), [How to request, create, and save a notification channel](http://msdn.microsoft.com/library/7aae5dbd-f03e-4cfa-bcf2-c9ad1d7cdb42), [Guidelines and checklist for push notifications](XREF:TODO:m_ui_tiles.guidelines_for_push_notifications), [Push notification service request and response headers](http://msdn.microsoft.com/library/50575c54-b617-40c5-9dda-79a065e00cca)

## -capabilities
internetClient