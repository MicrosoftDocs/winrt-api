---
-api-id: P:Windows.UI.Notifications.NotificationData.SequenceNumber
-api-type: winrt property
---

<!-- Property syntax.
public uint SequenceNumber { get;  set; }
-->

# Windows.UI.Notifications.NotificationData.SequenceNumber

## -description
Gets or sets the sequence number of this notification data. The system uses the sequence number to determine whether the notification data is out-of-date.

## -property-value
A value greater than or equal to 0 that specifies the sequence number of this notification data. When multiple [NotificationData](notificationdata.md) objects are received, the system displays the [NotificationData](notificationdata.md) with the greatest non-zero number. Setting this value to 0 causes it to always displays.  

## -remarks

## -see-also

## -examples

