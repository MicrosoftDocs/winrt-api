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
Enumeration that describes possible access states that a user can have to a given radio.

## -enum-fields
### -field Unspecified:0
Access state is unspecified.

### -field Allowed:1
Access is allowed.

### -field DeniedByUser:2
Access was denied because of user action, usually through denying an operation through the radio privacy settings page.

### -field DeniedBySystem:3
Access was denied by the system. One common reason for this result is that the user does not have suitable permission to manipulate the radio in question.


## -remarks

## -examples

## -see-also