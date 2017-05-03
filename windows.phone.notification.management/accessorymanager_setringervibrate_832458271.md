---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.SetRingerVibrate(System.Boolean,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void SetRingerVibrate(System.Boolean ringer, System.Boolean vibrate)
-->

# Windows.Phone.Notification.Management.AccessoryManager.SetRingerVibrate

## -description
An accessory can toggle on and off the ringer and vibrate settings on the phone.

## -parameters
### -param ringer
true if ringer is on; otherwise false.

### -param vibrate
true if vibrate mode is on; otherwise false.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

To set the phone to vibrate with no ringer, call this method passing (false, true). To set the phone ringer on and vibrate off, call passing (true, false). To set the ringer on and vibrate on, call passing (true, true). To set the phone ringer and vibrate off, call passing (false, false).



## -examples

## -see-also
