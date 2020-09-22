---
-api-id: T:Windows.UI.Notifications.ToastNotificationPriority
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ToastNotificationPriority : int 
-->

# Windows.UI.Notifications.ToastNotificationPriority

## -description
Specifies the priority of a [ToastNotification](toastnotification.md). 

## -enum-fields
### -field High:1
The notification should be treated as high priority. For desktop PCs, this means during connected standby mode the incoming notification can turn on the screen for Surface-like devices if it doesn't have a closed lid detected.


### -field Default:0
The notification should have default behavior in terms of delivery and display priority during connected standby mode. 

## -remarks
The priority setting provides hints on how and at what urgency level a notification should be presented to the user (whether to wake up the screen, etc).
Whether the notification is displayed in high priority is based on the state and power management policy of the device.

## -see-also

[ToastNotification.Priority](toastnotification_priority.md)

## -examples

