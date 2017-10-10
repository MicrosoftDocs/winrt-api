---
-api-id: T:Windows.Phone.Notification.Management.PhoneNotificationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Notification.Management.PhoneNotificationType : int
-->

# PhoneNotificationType

## -description
Represents the type of notification sent to the accessory application.

## -enum-fields
### -field NewCall:0
The notification is of a new call.

### -field CallChanged:1
The notification is of a changed call.

### -field LineChanged:2
The notification is of a changed phone line.

### -field PhoneCallAudioEndpointChanged:3
The notification is of the audio enpoint--hand's free, speaker, or phone--changing.

### -field PhoneMuteChanged:4
The notification is of the phone mute state changing.


## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
## -capabilities
accessoryManager
