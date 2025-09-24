---
-api-id: T:Windows.Devices.Radios.RadioAccessStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Radios.RadioAccessStatus : int
-->

# RadioAccessStatus

## -description
Indicates the application's permission level for controlling radio devices, returned by both access requests and state change operations.

## -enum-fields
### -field Unspecified:0
Access state is unspecified.

### -field Allowed:1
Access is allowed.

### -field DeniedByUser:2
Access was denied because of user action, usually through denying an operation through the radio privacy settings page.

### -field DeniedBySystem:3
Access was denied by the system. One common reason is insufficient permission to manipulate the radio.

## -remarks

### Access status meanings

**Permission levels:**
- **Allowed**: Application has permission to control radio states
- **DeniedByUser**: User explicitly denied radio control permission through privacy settings
- **DeniedBySystem**: System policy prevents radio control (insufficient privileges, group policy, etc.)
- **Unspecified**: No specific access control is implemented for this radio

**User consent scenarios:**
- First-time access requests may prompt the user
- User can revoke permissions through system settings
- Administrative policies can override user choices

> [!NOTE]
> An access status other than **Allowed** does not mean radios are absent from the system. Applications can still 
> enumerate radios and read their current states, but cannot modify them.

## -examples

## -see-also
[Radio](radio.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[RadioState](radiostate.md)
