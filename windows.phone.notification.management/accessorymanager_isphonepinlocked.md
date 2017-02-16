---
-api-id: P:Windows.Phone.Notification.Management.AccessoryManager.IsPhonePinLocked
-api-type: winrt property
---

<!-- Property syntax
public bool IsPhonePinLocked { get; }
-->

# Windows.Phone.Notification.Management.AccessoryManager.IsPhonePinLocked

## -description
Gets a value indicating whether the phone is locked.

## -property-value
True if phone is locked, otherwise false.

## -remarks
> [!IMPORTANT]
> When the phone is pin locked, email notifications may come in with no information due to Data Protection Under pin Lock (DPUL). This feature is enabled by the end-user.

It may be useful for an accessory to know that the phone is currently locked. The associated background task can then choose whether or not to take certain actions if the phone is locked. This will be most useful with active cover apps where certain UI should not be shown if the phone is locked.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
