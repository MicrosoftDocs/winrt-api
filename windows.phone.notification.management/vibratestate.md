---
-api-id: T:Windows.Phone.Notification.Management.VibrateState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Notification.Management.VibrateState : int
-->

# VibrateState

## -description
Represents the state of the phone vibrate mode and ringer.

## -enum-fields
### -field RingerOffVibrateOff:0
Both the ringer and vibrate mode are off.

### -field RingerOffVibrateOn:1
The ringer is off and vibrate mode is on.

### -field RingerOnVibrateOff:2
The ringer is on and vibrate mode is off.

### -field RingerOnVibrateOn:3
Both the ringer and vibrate mode are on.


## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also