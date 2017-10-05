---
-api-id: T:Windows.Phone.Notification.Management.AccessoryNotificationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Notification.Management.AccessoryNotificationType : uint
-->

# AccessoryNotificationType

## -description
Represents the types of notifications that are raised on the phone. The [IAccessoryNotificationTriggerDetails](iaccessorynotificationtriggerdetails.md) are available to the **IBackgroundTask.Run** method which is executed upon triggering by the [AccessoryManager](accessorymanager.md). Inside the [IAccessoryNotificationTriggerDetails](iaccessorynotificationtriggerdetails.md) is an **INotification** object. The **BackgroundTask** developer needs to investigate this interface to determine what the specific notification type is. [IAccessoryNotificationTriggerDetails.AccessoryNotificationType](iaccessorynotificationtriggerdetails_accessorynotificationtype.md) contains a value from a [AccessoryNotificationType](accessorynotificationtype.md) enumeration, listed below.

With knowledge of the type of notification, the **BackgroundTask** developer can use the more specific interfaces to gather information about the notification. The values are bit flags. You can OR the enum values together to indicate which notification types to be alerted for.

## -enum-fields
### -field None:0
The notification type is "None".

### -field Phone:1
A notification indicating a phone call was received.

### -field Email:2
A notification indicating a new batch of emails received

### -field Reminder:4
A notification from a Reminder that has fired.

### -field Alarm:8
A notification from an Alarm that has fired.

### -field Toast:16
A notification from an app that manifests as a toast in the phone UI.

### -field AppUninstalled:32
A notification that an app is uninstalled.

### -field Dnd:64
A notification that do not disturb is turned on or off.

### -field DrivingMode:128
A notification that driving mode is turned on or off.

### -field BatterySaver:256
A notification that batter saver is turned on of off.

### -field Media:512
A notification indicating that the media playback status has changed.

### -field CortanaTile:1024
A notification from a Cortana tile. For more information, see [CortanaTileNotificationTriggerDetails](cortanatilenotificationtriggerdetails.md).

### -field ToastCleared:2048
A notification indicating a toast has been cleared.

### -field CalendarChanged:4096
A notification indicating a calendar event has changed.

### -field VolumeChanged:8192
A notification indicating the volume has changed.

### -field EmailReadStatusChanged:16384
A notification indicating the read status of an email has changed.


## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
## -capabilities
accessoryManager
